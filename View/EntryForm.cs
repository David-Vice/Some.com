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
    public partial class EntryForm : Form
    {
        Repository.UserRepository repository;
        public EntryForm()
        {
            InitializeComponent();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            repository = new Repository.UserRepository(Application.StartupPath);
            LoginForm logForm = new LoginForm();
            LoginPresenter loginPresenter = new LoginPresenter(logForm,repository);
            this.Visible = false;
            logForm.parWindow = this;
            logForm.ShowDialog();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            repository = new Repository.UserRepository(Application.StartupPath);
            RegistrationForm registrationForm = new RegistrationForm();
            RegistrationPresenter registrationPresenter = new RegistrationPresenter(registrationForm, repository);
            this.Visible = false;
            registrationForm.parWindow = this;
            registrationForm.ShowDialog();
        }

        private void showAllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            repository = new Repository.UserRepository(Application.StartupPath);
            panel1.Visible = true;
            accListBox.DataSource = repository.GetAllUsers().Select(x => x.Name + " " + x.SurName).ToList();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
