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
    public class Worker : IObserver
    {
        private IServer server;
        private TcpClient connection;

        private XmlSerializer formattter;
        private NetworkStream nStream;
        private IFormatter formatter;

        private volatile bool connected;

        public Worker(IServer server, TcpClient connection)
        {
            this.server = server;
            this.connection = connection;
            try
            {
                nStream = connection.GetStream();
                formatter = new BinaryFormatter();
                connected = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + e.StackTrace);
            }
        }

        public virtual void run()
        {
            while (connected)
            {
                try
                {
                    if (!connected) continue;
                    object request = null;
                    try
                    {
                        request = formatter.Deserialize(nStream);
                    }
                    catch (Exception) { break; }
                    object response = HandleRequest((Request)request);
                    if (response != null)
                    {
                        SendResponse(response as Response);
                    }
                }
                catch (ServicesException e)
                {
                    Console.WriteLine(e.Message + e.StackTrace);
                }
                try
                {
                    Thread.Sleep(100);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + e.StackTrace);
                }
            }
            try
            {
                nStream.Close();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + e.StackTrace);
            }
        }

        private void SendResponse(Response response)
        {
            formatter.Serialize(nStream, response);
            nStream.Flush();
            //Console.WriteLine("SendResponse: " + response.GetType().ToString());
            if (response is ErrorResponse)
            {
                Console.WriteLine("ErrorResponse: " + (response as ErrorResponse).Message);
            }
        }

        private object HandleRequest(Request request)
        {
            Response response = null;
            if (request is LoginRequest)
            {
                var logReq = request as LoginRequest;
                var username = logReq.Username;
                var password = logReq.Password;

                try
                {
                    Person user = null;
                    lock (server)
                    {
                        user = server.Login(username, password, this);
                    }
                    return new GoodResponse(user);
                }
                catch (Exception e)
                {
                    connected = false;
                    return new ErrorResponse(e.Message);
                }
            }
            if (request is LogoutRequest)
            {
                var logReq = request as LogoutRequest;
                
                try
                {
                    lock (server)
                    {
                        server.Logout(logReq.Username);
                    }
                    return new GoodResponse();
                }
                catch (Exception e)
                {
                    connected = false;
                    return new ErrorResponse(e.Message);
                }
            }
            if (request is VoteItemRequest)
            {
                var voteReq = request as VoteItemRequest;
                try
                {
                    lock (server)
                    {
                        server.voteItem(voteReq.user, voteReq.item);
                    }
                    return new VoteItemResponse();
                }
                catch (Exception e)
                {
                    return new ErrorResponse(e.Message + e.StackTrace);
                }
            }
            if (request is CategoriesRequest)
            {
                var catReq = request as CategoriesRequest;
                try
                {
                    Category[] categories;
                    lock (server)
                    {
                        categories = server.getCategories();
                    }
                    //return new GoodResponse();
                    return new CategoryResponse(categories);
                }
                catch (Exception e)
                {
                    return new ErrorResponse(e.Message + e.StackTrace);
                }
            }
            if (request is VotedCategoriesRequest)
            {
                var catReq = request as VotedCategoriesRequest;
                try
                {
                    VotedCategories[] items;
                    lock (server)
                    {
                        items = server.getVotedItems();
                    }
                    //return new GoodResponse();
                    return new VotedCategoriesResponse(items);
                }
                catch (Exception e)
                {
                    return new ErrorResponse(e.Message + e.StackTrace);
                }
            }
            if (request is UpdateUserRequest)
            {
                var updtReq = request as UpdateUserRequest;
                try
                {
                    Group[] groups;
                    Person user = null;
                    lock (server)
                    {
                        user = server.updateUser(updtReq.User);
                        groups = server.getGroups();
                    }
                    return new UpdateUserResponse(groups, user);
                }
                catch (Exception ex)
                {
                    return new ErrorResponse(ex.Message);
                }
            }
            if (request is GetGroupsRequest)
            {
                var getReq = request as GetGroupsRequest;
                try
                {
                    Group[] groups;
                    lock (server)
                    {
                        groups = server.getGroups();
                    }
                    return new GetGroupsResponse(groups);
                }
                catch (Exception e)
                {
                    return new ErrorResponse(e.Message);
                }
            }
            if (request is ChangeCategoryRequest)
            {
                var changeCateReq = request as ChangeCategoryRequest;
                try
                {
                    lock (server)
                    {
                        server.changeCategory(changeCateReq.item, changeCateReq.newCategory);
                    }
                    return new GoodResponse();
                }
                catch (ServicesException ex)
                {
                    return new ErrorResponse(ex.Message);
                }
            }
            if (request is AddCategoryRequest)
            {
                var addCatReq = request as AddCategoryRequest;
                try
                {
                    lock (server)
                    {
                        server.addCategory(addCatReq.newItem);
                    }
                    return new GoodResponse();
                }
                catch (ServicesException ex)
                {
                    return new ErrorResponse(ex.Message);
                }
            }

            return response;
        }


        public void ModifyCategory(Category[] newItems)
        {
            try
            {
                SendResponse(new ChangeCategory(newItems));
            }
            catch (Exception ex)
            {
                SendResponse(new ErrorResponse(ex.Message));
            }
        }


        public void ModifyUser(Group[] groups)
        {
            
        }

        public void NotifyUser(Person user)
        {
            try
            {
                SendResponse(new UpdateUserNotifyResponse(user));
            }
            catch (Exception ex)
            {
                SendResponse(new ErrorResponse(ex.Message));
            }
        }
    }
}
