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
    public partial class RegistrationForm : Form
    {
        public RegistrationPresenter registrationPresenter { get; set; }
        public Form parWindow { get; set; }

        public string UserName
        {
            get { return name.Text; }
            set { name.Text = value; }
        }
        public string UserSurname
        {
            get { return surname.Text; }
            set { surname.Text = value; }
        }
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
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (registrationPresenter.CreateAccount())
            {
                MessageBox.Show("Account was created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("This NickName already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parWindow.Visible = true;
        }
    }
}
