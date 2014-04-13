using Model;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Networking
{
    public class Proxy : IServer
    {
        private ushort _Port;
        private string _Host;
        private IObserver observer;
        private NetworkStream nStream;
        private IFormatter formatter = new BinaryFormatter();
        private TcpClient connection;

        private Queue<Response> responses;
        private volatile bool finished;
        private EventWaitHandle _WaitHandle;


        public Proxy(string Host, ushort Port)
        {
            this._Host = Host;
            this._Port = Port;
            this.responses = new Queue<Response>();
        }

        private void closeConnection()
        {
            Console.WriteLine("I want to close the connection");
            responses.Clear();
            finished = true;
            try
            {
                nStream.Close();
                connection.Close();
                _WaitHandle.Close();
                observer = null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + e.StackTrace);
            }
        }

        private Response readResponse()
        {
            Response response = null;
            try
            {
                _WaitHandle.WaitOne();
                Console.WriteLine("Response has arrived. Locking responses queue of size: " + responses.Count.ToString());
                lock (responses)
                {
                    response = responses.Dequeue();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message + e.StackTrace);
            }
            return response;
        }

        private void sendRequest(Request request)
        {
            try
            {
                formatter.Serialize(nStream, request);
                nStream.Flush();
                Console.WriteLine(request.GetType().ToString() + " request send.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + e.StackTrace);
                throw new ServicesException("Error: " + e.Message + e.StackTrace);
            }
        }

        private void initializeConnection()
        {
            try
            {
                connection = new TcpClient(_Host, (int)_Port);
                connection.ReceiveBufferSize = 1024 * 1024;
                nStream = connection.GetStream();
                formatter = new BinaryFormatter();
                finished = false;
                _WaitHandle = new AutoResetEvent(false);
                startReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + e.StackTrace);
            }
        }

        private void startReader()
        {
            Thread thread = new Thread(run);
            thread.Start();
        }

        private void run(object obj)
        {
            while (!finished)
            {
                try
                {
                    Console.WriteLine("Value of finished before sleep: " + finished);
                    Console.WriteLine("Trying to read response");
                    if (finished) continue;
                    if (!nStream.CanRead) Console.WriteLine("nStream is closed " + finished);
                    bool dataAvailable = nStream.DataAvailable;
                    while (!dataAvailable)
                    {
                        Thread.Sleep(5);
                        dataAvailable = nStream.DataAvailable;
                    }
                    var response = formatter.Deserialize(nStream);

                    if (response is UpdateResponse)
                    {
                        handleUpdate((response as UpdateResponse));
                        Console.WriteLine("Received a response of type: " + response.GetType().ToString());
                        Console.WriteLine("Handling the update");
                    }
                    else
                    {
                        lock (responses)
                        {
                            responses.Enqueue((response as Response));
                        }
                        _WaitHandle.Set();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + e.StackTrace);
                }
            }
        }

        private void handleUpdate(UpdateResponse updateResponse)
        {
            if (updateResponse is ChangeCategory)
            {
                var updateResp = (updateResponse as ChangeCategory);
                try
                {
                    observer.ModifyCategory(updateResp.newCategories);

                }
                catch (ServicesException e)
                {
                    Console.WriteLine(e.Message + e.StackTrace);
                }
            }
            if (updateResponse is UpdateUserNotifyResponse)
            {
                var user = (updateResponse as UpdateUserNotifyResponse).User;
                try
                {
                    observer.NotifyUser(user);
                }
                catch (ServicesException e)
                {
                    Console.WriteLine(e.Message + e.StackTrace);
                }
            }
        }

        public Model.Person Login(string username, string password, IObserver client)
        {
            initializeConnection();
            sendRequest(new LoginRequest(username, password));
            Response response = readResponse();
            if (response is GoodResponse)
            {
                this.observer = client;
                Person user = (response as GoodResponse).User;
                return user;
            }
            if (response is ErrorResponse)
            {
                var err = response as ErrorResponse;
                closeConnection();
                throw new ServicesException(err.Message);
            }
            return null;
        }

        public void Logout(string username)
        {
            var userLogout = new LogoutRequest(username);
            sendRequest(userLogout);
            Thread.Sleep(1000);
            var response = readResponse();
            if (response is GoodResponse)
            {
                closeConnection();
            }
            Thread.Sleep(100);
            if (response is ErrorResponse)
            {
                var err = response as ErrorResponse;
            }
            closeConnection();
        }

        public VotedCategories[] getVotedItems()
        {
            sendRequest(new VotedCategoriesRequest());
            Response response = readResponse();
            if (response is VotedCategoriesResponse)
            {
                if (response == null || (response as VotedCategoriesResponse).Items == null) throw new ServicesException("Return value is null");
                return (response as VotedCategoriesResponse).Items;
            }
            if (response is ErrorResponse)
            {
                var err = response as ErrorResponse;
                throw new ServicesException(err.Message);
            }
            Console.WriteLine("Here");
            return null;
        }

        public Category[] getCategories()
        {
            sendRequest(new CategoriesRequest());
            Response response = readResponse();
            if (response is CategoryResponse)
            {
                if (response == null || (response as CategoryResponse).Categories == null) throw new ServicesException("Return value is null");
                return (response as CategoryResponse).Categories;
            }
            if (response is ErrorResponse)
            {
                var err = response as ErrorResponse;
                throw new ServicesException(err.Message);
            }
            return null;
        }

        public Group[] getGroups()
        {
            sendRequest(new GetGroupsRequest());
            var response = readResponse();
            if (response is GetGroupsResponse)
            {
                return (response as GetGroupsResponse).Groups;
            }
            if (response is ErrorResponse)
            {
                throw new ServicesException((response as ErrorResponse).Message);
            }
            return null;
        }


        public void changeCategory(Item item, Category newCategory)
        {
            if (item != null && newCategory != null)
            {
                sendRequest(new ChangeCategoryRequest(item, newCategory));
                Console.WriteLine("Sent request of type changecategoryrequest");
            }
        }


        public void addCategory(Category newCategory)
        {
            if (newCategory != null)
            {
                sendRequest(new AddCategoryRequest(newCategory));
            }
        }


        public void addUser(Person user, Group group)
        {
            throw new NotImplementedException();
        }

        public Person updateUser(Person user)
        {
            sendRequest(new UpdateUserRequest(user));
            var response = readResponse();
            if (response is UpdateUserResponse)
            {
                var resp = (response as UpdateUserResponse);
                observer.ModifyUser(resp.Groups);
                return (resp.User);
            }
            if (response is ErrorResponse)
            {
                throw new ServicesException((response as ErrorResponse).Message);
            }
            return null;
        }


        public void voteItem(Person user, Item item)
        {
            sendRequest(new VoteItemRequest(user, item));
            var response = readResponse();
            if (response is VoteItemResponse)
            {
                return;
            }
            if (response is ErrorResponse)
            {
                throw new ServicesException((response as ErrorResponse).Message);
            }
        }
    }
}
