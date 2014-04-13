using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUI_items.Login
{
    public partial class Login : UserControl
    {
        private event EventHandler<LoginEventArgs> ErrorCodeShow;
        public event EventHandler LoginSuccesfull;
        private ClientController lc;
        public Login()
        {
            InitializeComponent();
            this.ErrorCodeShow += Login_ErrorCodeShow;
        }

        public Login(ClientController lc)
        {
            InitializeComponent();
            this.ErrorCodeShow += Login_ErrorCodeShow;
            this.lc = lc;
        }

        void Login_ErrorCodeShow(object sender, LoginEventArgs e)
        {
            errorMessage.Visible = true;
            errorMessage.Text = e.Message;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorMessage.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoLogin();
            }
        }

        private void ShowError(string message)
        {
            ErrorCodeShow(this, new LoginEventArgs(message));
        }

        private void DoLogin()
        {
            if (string.IsNullOrEmpty(usernameLine.Text))
            {
                ShowError("Username line is empty!");
                return;
            }
            if (string.IsNullOrEmpty(passwordLine.Text))
            {
                ShowError("Password line is empty!");
                return;
            }
            try
            {
                lc.Login(usernameLine.Text, passwordLine.Text);
                if (LoginSuccesfull != null)
                {
                    LoginSuccesfull(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
    }

    public class LoginEventArgs : EventArgs
    {
        private string _message;

        public LoginEventArgs(string message)
        {
            this.Message = message;
        }
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
    }
}
