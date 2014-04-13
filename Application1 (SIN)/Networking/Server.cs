using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Networking
{
    public abstract class AbstractServer
    {
        private TcpListener _Server;
        private string _Host;
        private ushort _Port;

        public AbstractServer(string Host, ushort Port)
        {
            _Host = Host;
            _Port = Port;
        }

        public void Start()
        {
            IPAddress addr = IPAddress.Parse(_Host);
            IPEndPoint endp = new IPEndPoint(addr, _Port);
            _Server = new TcpListener(endp);
            _Server.Start();
            while (true)
            {
                Console.WriteLine("Insert Client.");
                TcpClient client = _Server.AcceptTcpClient();
                client.SendBufferSize = 1024 * 1024;
                Console.WriteLine("Client has connected.");
                ProcessRequest(client);
            }
        }

        public abstract void ProcessRequest(TcpClient client);
    }

    public abstract class ConcurrentServer : AbstractServer
    {
        public ConcurrentServer(string Host, ushort Port)
            : base(Host, Port)
        {

        }

        public override void ProcessRequest(TcpClient client)
        {
            Thread thread = CreateWorker(client);
            thread.Start();
        }

        protected abstract Thread CreateWorker(TcpClient client);
    }
}
