using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.GUI_items.Login;

namespace Client.GUI_items.Report
{
    public partial class ReportView : UserControl
    {
        private ClientController generalController;

        public ReportView()
        {
            InitializeComponent();
        }

        public ReportView(Login.ClientController generalController)
        {
            // TODO: Complete member initialization
            this.generalController = generalController;
        }

        private void ReportView_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
