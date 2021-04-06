namespace TicketManager
{
    partial class MainPage
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.contentHolder = new System.Windows.Forms.Panel();
            this.lblTickets = new System.Windows.Forms.Label();
            this.txtFieldAmountTickets = new System.Windows.Forms.TextBox();
            this.lblSelectKind = new System.Windows.Forms.Label();
            this.radioChild = new System.Windows.Forms.RadioButton();
            this.radioStudent = new System.Windows.Forms.RadioButton();
            this.radioSchoolStudent = new System.Windows.Forms.RadioButton();
            this.btnCalculatePirce = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.contentHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.LightGray;
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Controls.Add(this.btnAbout);
            this.pnlHeader.Controls.Add(this.btnHome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 22);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(570, -1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Location = new System.Drawing.Point(651, -1);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(741, 4);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            this.lblDate.Click += new System.EventHandler(this.label1_Click);
            this.lblDate.MouseHover += new System.EventHandler(this.lblDate_MouseHover);
            // 
            // contentHolder
            // 
            this.contentHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentHolder.Controls.Add(this.lblSum);
            this.contentHolder.Controls.Add(this.btnCalculatePirce);
            this.contentHolder.Controls.Add(this.radioSchoolStudent);
            this.contentHolder.Controls.Add(this.radioStudent);
            this.contentHolder.Controls.Add(this.radioChild);
            this.contentHolder.Controls.Add(this.lblSelectKind);
            this.contentHolder.Controls.Add(this.txtFieldAmountTickets);
            this.contentHolder.Controls.Add(this.lblTickets);
            this.contentHolder.Location = new System.Drawing.Point(60, 147);
            this.contentHolder.Name = "contentHolder";
            this.contentHolder.Size = new System.Drawing.Size(666, 267);
            this.contentHolder.TabIndex = 2;
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Location = new System.Drawing.Point(220, 10);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(228, 13);
            this.lblTickets.TabIndex = 0;
            this.lblTickets.Text = "Please select how many tickets you would like!";
            // 
            // txtFieldAmountTickets
            // 
            this.txtFieldAmountTickets.Location = new System.Drawing.Point(223, 26);
            this.txtFieldAmountTickets.Name = "txtFieldAmountTickets";
            this.txtFieldAmountTickets.Size = new System.Drawing.Size(225, 20);
            this.txtFieldAmountTickets.TabIndex = 1;
            // 
            // lblSelectKind
            // 
            this.lblSelectKind.AutoSize = true;
            this.lblSelectKind.Location = new System.Drawing.Point(250, 77);
            this.lblSelectKind.Name = "lblSelectKind";
            this.lblSelectKind.Size = new System.Drawing.Size(176, 13);
            this.lblSelectKind.TabIndex = 2;
            this.lblSelectKind.Text = "Select what kind of ticket you want!";
            // 
            // radioChild
            // 
            this.radioChild.AutoSize = true;
            this.radioChild.Location = new System.Drawing.Point(99, 122);
            this.radioChild.Name = "radioChild";
            this.radioChild.Size = new System.Drawing.Size(114, 17);
            this.radioChild.TabIndex = 3;
            this.radioChild.TabStop = true;
            this.radioChild.Text = "Ticket For Children";
            this.radioChild.UseVisualStyleBackColor = true;
            this.radioChild.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioStudent
            // 
            this.radioStudent.AutoSize = true;
            this.radioStudent.Location = new System.Drawing.Point(253, 122);
            this.radioStudent.Name = "radioStudent";
            this.radioStudent.Size = new System.Drawing.Size(167, 17);
            this.radioStudent.TabIndex = 4;
            this.radioStudent.TabStop = true;
            this.radioStudent.Text = "Ticket For University Students";
            this.radioStudent.UseVisualStyleBackColor = true;
            // 
            // radioSchoolStudent
            // 
            this.radioSchoolStudent.AutoSize = true;
            this.radioSchoolStudent.Location = new System.Drawing.Point(451, 122);
            this.radioSchoolStudent.Name = "radioSchoolStudent";
            this.radioSchoolStudent.Size = new System.Drawing.Size(154, 17);
            this.radioSchoolStudent.TabIndex = 5;
            this.radioSchoolStudent.TabStop = true;
            this.radioSchoolStudent.Text = "Ticket For School Students";
            this.radioSchoolStudent.UseVisualStyleBackColor = true;
            // 
            // btnCalculatePirce
            // 
            this.btnCalculatePirce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculatePirce.Image = global::TicketManager.Properties.Resources.buttonDesign;
            this.btnCalculatePirce.Location = new System.Drawing.Point(259, 172);
            this.btnCalculatePirce.Name = "btnCalculatePirce";
            this.btnCalculatePirce.Size = new System.Drawing.Size(156, 29);
            this.btnCalculatePirce.TabIndex = 6;
            this.btnCalculatePirce.Text = "Calculate Price!";
            this.btnCalculatePirce.UseVisualStyleBackColor = true;
            this.btnCalculatePirce.Click += new System.EventHandler(this.btnCalculatePirce_Click);
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.picLogo.Image = global::TicketManager.Properties.Resources.TickerManagerLogo;
            this.picLogo.Location = new System.Drawing.Point(284, 28);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(192, 113);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(284, 227);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(102, 13);
            this.lblSum.TabIndex = 7;
            this.lblSum.Text = "Your total sum is: 0$";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contentHolder);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.picLogo);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.contentHolder.ResumeLayout(false);
            this.contentHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel contentHolder;
        private System.Windows.Forms.RadioButton radioChild;
        private System.Windows.Forms.Label lblSelectKind;
        private System.Windows.Forms.TextBox txtFieldAmountTickets;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.Button btnCalculatePirce;
        private System.Windows.Forms.RadioButton radioSchoolStudent;
        private System.Windows.Forms.RadioButton radioStudent;
        private System.Windows.Forms.Label lblSum;
    }
}

