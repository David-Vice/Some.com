namespace WinForm_app10.View
{
    partial class EntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.logButton = new System.Windows.Forms.Button();
            this.regButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hideButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.accListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 29F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 95);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(426, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Some.com";
            // 
            // logButton
            // 
            this.logButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.logButton.ForeColor = System.Drawing.SystemColors.Control;
            this.logButton.Location = new System.Drawing.Point(63, 254);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(110, 50);
            this.logButton.TabIndex = 1;
            this.logButton.Text = "Login";
            this.logButton.UseVisualStyleBackColor = false;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.regButton.ForeColor = System.Drawing.SystemColors.Control;
            this.regButton.Location = new System.Drawing.Point(381, 254);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(110, 50);
            this.regButton.TabIndex = 2;
            this.regButton.Text = "Registration";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Desktop;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllUsersToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // showAllUsersToolStripMenuItem
            // 
            this.showAllUsersToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.showAllUsersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.showAllUsersToolStripMenuItem.Name = "showAllUsersToolStripMenuItem";
            this.showAllUsersToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.showAllUsersToolStripMenuItem.Text = "Show All Users";
            this.showAllUsersToolStripMenuItem.Click += new System.EventHandler(this.showAllUsersToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hideButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.accListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 393);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(487, 0);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(75, 23);
            this.hideButton.TabIndex = 2;
            this.hideButton.Text = "Hide";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "All Accounts";
            // 
            // accListBox
            // 
            this.accListBox.Font = new System.Drawing.Font("Sitka Subheading", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accListBox.FormattingEnabled = true;
            this.accListBox.ItemHeight = 21;
            this.accListBox.Location = new System.Drawing.Point(155, 47);
            this.accListBox.Name = "accListBox";
            this.accListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.accListBox.Size = new System.Drawing.Size(220, 319);
            this.accListBox.TabIndex = 0;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 421);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(580, 468);
            this.MinimumSize = new System.Drawing.Size(580, 468);
            this.Name = "EntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllUsersToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox accListBox;
        private System.Windows.Forms.Button hideButton;
    }
}