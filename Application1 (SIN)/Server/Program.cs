using Networking;
using Persistance;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var uRepository = new UserRepository();
            var iRepository = new ItemsRepository();
            var server = new ServerImplementation(uRepository, iRepository);
            string host = ConfigurationManager.AppSettings["ip"];
            ushort port = ushort.Parse(ConfigurationManager.AppSettings["port"]);
            var ss = new SerialServer(host, port, server);
            ss.Start();
            Console.ReadLine();
        }
    }

    public class SerialServer : ConcurrentServer
    {
        private IServer server;
        private Networking.Worker worker;

        public SerialServer(string host, ushort port, IServer server) :
            base(host, port)
        {
            this.server = server;
        }

        protected override System.Threading.Thread CreateWorker(System.Net.Sockets.TcpClient client)
        {
            worker = new Worker(server, client);
            return new Thread(new ThreadStart(worker.run));
        }
    }
}