namespace WinForm_app10.View
{
    partial class PageForm
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
        public void InitializeComponent()
        {
            this.lab = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hideButton = new System.Windows.Forms.Button();
            this.newStatus = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Harlow Solid Italic", 16.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(12, 18);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(195, 35);
            this.lab.TabIndex = 0;
            this.lab.Text = "Name Surname";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxStatus.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxStatus.Location = new System.Drawing.Point(3, 3);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(460, 75);
            this.textBoxStatus.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.addButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addButton.Location = new System.Drawing.Point(466, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(98, 31);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add Status";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.hideButton);
            this.panel1.Controls.Add(this.textBoxStatus);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 81);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // hideButton
            // 
            this.hideButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.hideButton.ForeColor = System.Drawing.SystemColors.Control;
            this.hideButton.Location = new System.Drawing.Point(466, 47);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(98, 31);
            this.hideButton.TabIndex = 3;
            this.hideButton.Text = "Hide";
            this.hideButton.UseVisualStyleBackColor = false;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // newStatus
            // 
            this.newStatus.Font = new System.Drawing.Font("MV Boli", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStatus.Location = new System.Drawing.Point(456, 18);
            this.newStatus.Name = "newStatus";
            this.newStatus.Size = new System.Drawing.Size(126, 33);
            this.newStatus.TabIndex = 4;
            this.newStatus.Text = "New Status";
            this.newStatus.UseVisualStyleBackColor = true;
            this.newStatus.Click += new System.EventHandler(this.newStatus_Click);
            // 
            // PageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.newStatus);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(612, 497);
            this.MinimumSize = new System.Drawing.Size(612, 497);
            this.Name = "PageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PageForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PageForm_FormClosed);
            this.Load += new System.EventHandler(this.PageForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Button newStatus;
    }
}