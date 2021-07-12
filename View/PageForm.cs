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
    public partial class PageForm : Form
    {
        Repository.UserRepository repository = new Repository.UserRepository(Application.StartupPath);

        public PagePresenter pagePresenter { get; set; }
        public int CurrentUserID { get; set; }
        public PageForm(int selectedUserID)
        {
            InitializeComponent();
            CurrentUserID = selectedUserID;
        }
        public Form parWindow { get; set; }

        public void PageForm_Load(object sender, EventArgs e)
        {
            lab.Text = repository.GetAllUsers().ToList()[CurrentUserID].Name + " " + repository.GetAllUsers().ToList()[CurrentUserID].SurName;
            pagePresenter.DisplayAllStatus(CurrentUserID);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            pagePresenter.NewStatus(CurrentUserID,textBoxStatus.Text);
            textBoxStatus.Text = string.Empty;
            panel1.Visible = false;
        }

        private void newStatus_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void PageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parWindow.Visible = true;
        }
    }
}
