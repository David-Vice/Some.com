using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_app10.Presenter;

namespace WinForm_app10.View
{
    public partial class LoginForm : Form
    {
        Repository.UserRepository repository = new Repository.UserRepository(Application.StartupPath);
        public LoginPresenter loginPresenter { get; set; }
        public int CurrentUserID { get; set; }
        public Form parWindow { get; set; }

        public string NickName 
        {
            get { return nick.Text; }
            set { nick.Text = value; }
        }
        public string Password 
        {
            get { return pass.Text; }
            set { pass.Text = value; }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            PageForm pageForm;
            PagePresenter pagePresenter;
            if(loginPresenter.Continue())
            {
                pageForm = new PageForm(CurrentUserID);
                pagePresenter = new PagePresenter(pageForm, repository);
                this.Visible = false;
                pageForm.parWindow = this;
                pageForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong NickName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parWindow.Visible = true;
        }
    }
}
