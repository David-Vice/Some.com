using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm_app10.View;
using WinForm_app10.Repository;
using System.Windows.Forms;

namespace WinForm_app10.Presenter
{
    public class PagePresenter
    {
        UserRepository repository;
        PageForm view;
        int startingY = 50;
        Control currentGP;
        Panel tmpPanel;

        public PagePresenter() { CreatePanel(0, 0); }
        public PagePresenter(PageForm pageForm, UserRepository userRepository)
        {
            this.view = pageForm;
            this.view.pagePresenter = this;
            this.repository = userRepository;
            CreatePanel(0, 0);
        }

        public void DisplayAllStatus(int ID)
        {
            for(int i=0;i<repository.users[ID].StatusList.Count;i++)
            {
                CreateStatusWindow(repository.users[ID].StatusList[i]);
            }
        }
        public void NewStatus(int ID, string myText)
        {
            repository.users[ID].StatusList.Add(myText);
            CreateStatusWindow(myText);
            repository.SaveUsers(repository.users);
        }
        public void RefreshForm()
        {
            view.Controls.Clear();
            view.InitializeComponent();
            view.PageForm_Load(new object(), new EventArgs());
        }
        private void edit_Click(object sender, EventArgs e)
        {
            tmpPanel.Visible = false;
            tmpPanel.Controls.Clear();
            CreatePanel(((sender as Button).Parent as GroupBox).Location.X, ((sender as Button).Parent as GroupBox).Location.Y);
            tmpPanel.BringToFront();
            tmpPanel.Visible = true;
            (tmpPanel.Controls["tmpTBPanel"] as TextBox).Text = (((sender as Button).Parent as GroupBox).Controls["tmpL"] as Label).Text;
            currentGP = (sender as Button).Parent;
        }
        private void save_Click(object sender, EventArgs e)
        {
            for(int i=0;i< repository.users[view.CurrentUserID].StatusList.Count;i++)
            {
                if(repository.users[view.CurrentUserID].StatusList[i] == ((currentGP as GroupBox).Controls["tmpL"] as Label).Text)
                {
                    repository.users[view.CurrentUserID].StatusList[i] = (tmpPanel.Controls["tmpTBPanel"] as TextBox).Text;
                    break;
                }
            }
            ((currentGP as GroupBox).Controls["tmpL"] as Label).Text = (tmpPanel.Controls["tmpTBPanel"] as TextBox).Text;
            tmpPanel.Visible = false;
            repository.SaveUsers(repository.users);
        }
        private void delete_Click(object sender, EventArgs e)
        {
            repository.users.ToList()[view.CurrentUserID].StatusList.Remove(((currentGP as GroupBox).Controls["tmpL"] as Label).Text);
            repository.SaveUsers(repository.users);
            tmpPanel.Visible = false;
            startingY = 50;

            RefreshForm();
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            tmpPanel.Visible = false;
        }
        public void CreatePanel(int X, int Y)
        {
            tmpPanel = new Panel();
            tmpPanel.SuspendLayout();

            TextBox tmpTBPanel = new TextBox();
            tmpTBPanel.BackColor = System.Drawing.SystemColors.Control;
            tmpTBPanel.ForeColor = System.Drawing.SystemColors.Desktop;
            tmpTBPanel.Location = new System.Drawing.Point(5, 5);
            tmpTBPanel.Multiline = true;
            tmpTBPanel.Name = "tmpTBPanel";
            tmpTBPanel.Size = new System.Drawing.Size(355, 70);
            tmpTBPanel.TabIndex = 1;

            Button tmpSave = new Button();
            tmpSave.BackColor = System.Drawing.SystemColors.Desktop;
            tmpSave.ForeColor = System.Drawing.SystemColors.Control;
            tmpSave.Location = new System.Drawing.Point(370, 5);
            tmpSave.Name = "tmpSave";
            tmpSave.Size = new System.Drawing.Size(50, 20);
            tmpSave.TabIndex = 2;
            tmpSave.Text = "Save";
            tmpSave.UseVisualStyleBackColor = false;
            tmpSave.Click += new System.EventHandler(this.save_Click);

            Button tmpDelete = new Button();
            tmpDelete.BackColor = System.Drawing.SystemColors.Desktop;
            tmpDelete.ForeColor = System.Drawing.SystemColors.Control;
            tmpDelete.Location = new System.Drawing.Point(370, 30);
            tmpDelete.Name = "tmpdelete";
            tmpDelete.Size = new System.Drawing.Size(50, 20);
            tmpDelete.TabIndex = 3;
            tmpDelete.Text = "Delete";
            tmpDelete.UseVisualStyleBackColor = false;
            tmpDelete.Click += new System.EventHandler(this.delete_Click);

            Button tmpCancel = new Button();
            tmpCancel.BackColor = System.Drawing.SystemColors.Desktop;
            tmpCancel.ForeColor = System.Drawing.SystemColors.Control;
            tmpCancel.Location = new System.Drawing.Point(370, 55);
            tmpCancel.Name = "tmpCancel";
            tmpCancel.Size = new System.Drawing.Size(50, 20);
            tmpCancel.TabIndex = 3;
            tmpCancel.Text = "Cancel";
            tmpCancel.UseVisualStyleBackColor = false;
            tmpCancel.Click += new System.EventHandler(this.cancel_Click);

            tmpPanel.BackColor = System.Drawing.SystemColors.Desktop;
            tmpPanel.Controls.Add(tmpTBPanel);
            tmpPanel.Controls.Add(tmpSave);
            tmpPanel.Controls.Add(tmpDelete);
            tmpPanel.Controls.Add(tmpCancel);
            tmpPanel.Location = new System.Drawing.Point(X, Y);
            tmpPanel.Name = "panel1";
            tmpPanel.Size = new System.Drawing.Size(430, 80);
            tmpPanel.TabIndex = 3;
            tmpPanel.Visible = false;

            view.Controls.Add(tmpPanel);
            tmpPanel.ResumeLayout(false);
            tmpPanel.PerformLayout();
        }
        private void CreateStatusWindow(string myText)
        {
            GroupBox tmpGB = new GroupBox();
            tmpGB.SuspendLayout();
            
            Button tmpB = new Button();

            tmpB.Location = new System.Drawing.Point(370, 15);//
            tmpB.Name = "tmpB";
            tmpB.Size = new System.Drawing.Size(50, 38);//
            tmpB.TabIndex = 0;
            tmpB.Text = "Edit";
            tmpB.UseVisualStyleBackColor = true;
            tmpB.Click += new System.EventHandler(this.edit_Click);

            Label tmpL = new Label();

            tmpL.AutoSize = true;
            tmpL.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tmpL.Location = new System.Drawing.Point(6, 15);//
            tmpL.MaximumSize = new System.Drawing.Size(360, 0);//
            tmpL.Name = "tmpL";
            tmpL.Size = new System.Drawing.Size(360, 38);//
            tmpL.TabIndex = 1;
            tmpL.Text = myText;

            tmpGB.Controls.Add(tmpB);
            tmpGB.Controls.Add(tmpL);
            tmpGB.Location = new System.Drawing.Point(8, startingY);//
            tmpGB.Name = "tmpGB";
            tmpGB.Size = new System.Drawing.Size(430, 64);//
            tmpGB.TabIndex = 4;
            tmpGB.TabStop = false;

            view.Controls.Add(tmpGB);
            tmpGB.ResumeLayout(false);
            tmpGB.PerformLayout();

            startingY += 70;
        }
    }
}
