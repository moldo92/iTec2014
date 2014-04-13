using Client.GUI_items.Login;
using Networking;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Networking

namespace Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var dic = Helper.Util.LoadXml();
            string host = dic["Ip"];
            ushort port = ushort.Parse(dic["Port"]);
            IServer server = new Proxy(host, port);

            var clientController = new ClientController(server);
            var login = new Login(clientController);

            var mainWindow = new MainWindow(login, clientController);
            Application.Run(mainWindow);
        }
    }
}
