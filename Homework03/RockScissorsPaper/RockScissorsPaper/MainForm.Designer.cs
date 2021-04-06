namespace RockScissorsPaper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlContentHolder = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.pbNameHolder = new System.Windows.Forms.PictureBox();
            this.pbStartHolder = new System.Windows.Forms.PictureBox();
            this.pnlGamePlay = new System.Windows.Forms.Panel();
            this.pbUserChoice = new System.Windows.Forms.PictureBox();
            this.pbComputerChoice = new System.Windows.Forms.PictureBox();
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pbGameProgressUser = new System.Windows.Forms.PictureBox();
            this.pbGameProgressComputer = new System.Windows.Forms.PictureBox();
            this.lblWeapon = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.rbPaper = new System.Windows.Forms.RadioButton();
            this.rbScissors = new System.Windows.Forms.RadioButton();
            this.rbRock = new System.Windows.Forms.RadioButton();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlContentHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNameHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartHolder)).BeginInit();
            this.pnlGamePlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameProgressUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameProgressComputer)).BeginInit();
            this.pnlMainContent.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlHeader.Controls.Add(this.pbLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(548, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.Image = global::RockScissorsPaper.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(180, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(180, 97);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlContentHolder
            // 
            this.pnlContentHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContentHolder.BackColor = System.Drawing.Color.Transparent;
            this.pnlContentHolder.Controls.Add(this.btnReset);
            this.pnlContentHolder.Controls.Add(this.btnStart);
            this.pnlContentHolder.Controls.Add(this.tbUsername);
            this.pnlContentHolder.Controls.Add(this.lblEnterName);
            this.pnlContentHolder.Controls.Add(this.pbNameHolder);
            this.pnlContentHolder.Controls.Add(this.pbStartHolder);
            this.pnlContentHolder.Location = new System.Drawing.Point(0, 27);
            this.pnlContentHolder.Name = "pnlContentHolder";
            this.pnlContentHolder.Size = new System.Drawing.Size(549, 100);
            this.pnlContentHolder.TabIndex = 7;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.btnReset.Location = new System.Drawing.Point(355, 58);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 33);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset!";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.btnStart.Location = new System.Drawing.Point(334, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 33);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Game!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(207)))));
            this.tbUsername.Location = new System.Drawing.Point(91, 48);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(140, 20);
            this.tbUsername.TabIndex = 2;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEnterName
            // 
            this.lblEnterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.lblEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(207)))));
            this.lblEnterName.Location = new System.Drawing.Point(88, 19);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(152, 26);
            this.lblEnterName.TabIndex = 1;
            this.lblEnterName.Text = "Please Enter Your Name: ";
            // 
            // pbNameHolder
            // 
            this.pbNameHolder.BackColor = System.Drawing.Color.Transparent;
            this.pbNameHolder.BackgroundImage = global::RockScissorsPaper.Properties.Resources.Box;
            this.pbNameHolder.Location = new System.Drawing.Point(72, 0);
            this.pbNameHolder.Name = "pbNameHolder";
            this.pbNameHolder.Size = new System.Drawing.Size(176, 100);
            this.pbNameHolder.TabIndex = 0;
            this.pbNameHolder.TabStop = false;
            // 
            // pbStartHolder
            // 
            this.pbStartHolder.BackColor = System.Drawing.Color.Transparent;
            this.pbStartHolder.BackgroundImage = global::RockScissorsPaper.Properties.Resources.Box;
            this.pbStartHolder.Location = new System.Drawing.Point(316, 0);
            this.pbStartHolder.Name = "pbStartHolder";
            this.pbStartHolder.Size = new System.Drawing.Size(157, 100);
            this.pbStartHolder.TabIndex = 4;
            this.pbStartHolder.TabStop = false;
            // 
            // pnlGamePlay
            // 
            this.pnlGamePlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGamePlay.BackColor = System.Drawing.Color.Transparent;
            this.pnlGamePlay.Controls.Add(this.pbUserChoice);
            this.pnlGamePlay.Controls.Add(this.pbComputerChoice);
            this.pnlGamePlay.Controls.Add(this.lblComputer);
            this.pnlGamePlay.Controls.Add(this.lblUsername);
            this.pnlGamePlay.Controls.Add(this.pbGameProgressUser);
            this.pnlGamePlay.Controls.Add(this.pbGameProgressComputer);
            this.pnlGamePlay.Location = new System.Drawing.Point(0, 155);
            this.pnlGamePlay.Name = "pnlGamePlay";
            this.pnlGamePlay.Size = new System.Drawing.Size(549, 128);
            this.pnlGamePlay.TabIndex = 9;
            // 
            // pbUserChoice
            // 
            this.pbUserChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.pbUserChoice.Location = new System.Drawing.Point(82, 29);
            this.pbUserChoice.Name = "pbUserChoice";
            this.pbUserChoice.Size = new System.Drawing.Size(158, 84);
            this.pbUserChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserChoice.TabIndex = 7;
            this.pbUserChoice.TabStop = false;
            // 
            // pbComputerChoice
            // 
            this.pbComputerChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.pbComputerChoice.Location = new System.Drawing.Point(326, 29);
            this.pbComputerChoice.Name = "pbComputerChoice";
            this.pbComputerChoice.Size = new System.Drawing.Size(133, 84);
            this.pbComputerChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbComputerChoice.TabIndex = 6;
            this.pbComputerChoice.TabStop = false;
            // 
            // lblComputer
            // 
            this.lblComputer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.lblComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblComputer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(207)))));
            this.lblComputer.Location = new System.Drawing.Point(363, 10);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(69, 26);
            this.lblComputer.TabIndex = 5;
            this.lblComputer.Text = "Computer";
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(207)))));
            this.lblUsername.Location = new System.Drawing.Point(113, 4);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(95, 26);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Your Username ";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbGameProgressUser
            // 
            this.pbGameProgressUser.BackColor = System.Drawing.Color.Transparent;
            this.pbGameProgressUser.BackgroundImage = global::RockScissorsPaper.Properties.Resources.Box;
            this.pbGameProgressUser.Location = new System.Drawing.Point(72, 0);
            this.pbGameProgressUser.Name = "pbGameProgressUser";
            this.pbGameProgressUser.Size = new System.Drawing.Size(176, 128);
            this.pbGameProgressUser.TabIndex = 0;
            this.pbGameProgressUser.TabStop = false;
            // 
            // pbGameProgressComputer
            // 
            this.pbGameProgressComputer.BackColor = System.Drawing.Color.Transparent;
            this.pbGameProgressComputer.BackgroundImage = global::RockScissorsPaper.Properties.Resources.Box;
            this.pbGameProgressComputer.Location = new System.Drawing.Point(316, 0);
            this.pbGameProgressComputer.Name = "pbGameProgressComputer";
            this.pbGameProgressComputer.Size = new System.Drawing.Size(157, 128);
            this.pbGameProgressComputer.TabIndex = 4;
            this.pbGameProgressComputer.TabStop = false;
            // 
            // lblWeapon
            // 
            this.lblWeapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.lblWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWeapon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(207)))));
            this.lblWeapon.Location = new System.Drawing.Point(211, 305);
            this.lblWeapon.Name = "lblWeapon";
            this.lblWeapon.Size = new System.Drawing.Size(132, 19);
            this.lblWeapon.TabIndex = 8;
            this.lblWeapon.Text = "Choose Your Weapon!";
            this.lblWeapon.Visible = false;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.lblScore);
            this.pnlMainContent.Controls.Add(this.lblWeapon);
            this.pnlMainContent.Controls.Add(this.pnlFooter);
            this.pnlMainContent.Controls.Add(this.pnlGamePlay);
            this.pnlMainContent.Controls.Add(this.pnlContentHolder);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 100);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(548, 430);
            this.pnlMainContent.TabIndex = 1;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(207)))));
            this.lblScore.Location = new System.Drawing.Point(240, 133);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(80, 19);
            this.lblScore.TabIndex = 11;
            this.lblScore.Text = "Score - 0 : 0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScore.Visible = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackgroundImage = global::RockScissorsPaper.Properties.Resources.Box;
            this.pnlFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFooter.Controls.Add(this.rbPaper);
            this.pnlFooter.Controls.Add(this.rbScissors);
            this.pnlFooter.Controls.Add(this.rbRock);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 324);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(548, 106);
            this.pnlFooter.TabIndex = 10;
            // 
            // rbPaper
            // 
            this.rbPaper.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPaper.BackColor = System.Drawing.Color.Transparent;
            this.rbPaper.BackgroundImage = global::RockScissorsPaper.Properties.Resources.Paper;
            this.rbPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbPaper.Enabled = false;
            this.rbPaper.FlatAppearance.BorderSize = 0;
            this.rbPaper.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.rbPaper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.rbPaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.rbPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPaper.Location = new System.Drawing.Point(366, 0);
            this.rbPaper.Name = "rbPaper";
            this.rbPaper.Size = new System.Drawing.Size(146, 106);
            this.rbPaper.TabIndex = 2;
            this.rbPaper.TabStop = true;
            this.rbPaper.UseVisualStyleBackColor = false;
            this.rbPaper.Click += new System.EventHandler(this.rbPaper_Click);
            // 
            // rbScissors
            // 
            this.rbScissors.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbScissors.BackColor = System.Drawing.Color.Transparent;
            this.rbScissors.BackgroundImage = global::RockScissorsPaper.Properties.Resources.Scissors1;
            this.rbScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbScissors.Enabled = false;
            this.rbScissors.FlatAppearance.BorderSize = 0;
            this.rbScissors.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.rbScissors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.rbScissors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.rbScissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbScissors.Location = new System.Drawing.Point(197, 0);
            this.rbScissors.Name = "rbScissors";
            this.rbScissors.Size = new System.Drawing.Size(146, 106);
            this.rbScissors.TabIndex = 1;
            this.rbScissors.TabStop = true;
            this.rbScissors.UseVisualStyleBackColor = false;
            this.rbScissors.Click += new System.EventHandler(this.rbScissors_Click);
            // 
            // rbRock
            // 
            this.rbRock.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRock.BackColor = System.Drawing.Color.Transparent;
            this.rbRock.BackgroundImage = global::RockScissorsPaper.Properties.Resources.rock2;
            this.rbRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbRock.Enabled = false;
            this.rbRock.FlatAppearance.BorderSize = 0;
            this.rbRock.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.rbRock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.rbRock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.rbRock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbRock.Location = new System.Drawing.Point(48, 0);
            this.rbRock.Name = "rbRock";
            this.rbRock.Size = new System.Drawing.Size(130, 106);
            this.rbRock.TabIndex = 0;
            this.rbRock.TabStop = true;
            this.rbRock.UseVisualStyleBackColor = false;
            this.rbRock.Click += new System.EventHandler(this.rbRock_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(548, 530);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock-Scissors-Paper";
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlContentHolder.ResumeLayout(false);
            this.pnlContentHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNameHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartHolder)).EndInit();
            this.pnlGamePlay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameProgressUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameProgressComputer)).EndInit();
            this.pnlMainContent.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlContentHolder;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.PictureBox pbNameHolder;
        private System.Windows.Forms.PictureBox pbStartHolder;
        private System.Windows.Forms.Panel pnlGamePlay;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pbGameProgressUser;
        private System.Windows.Forms.PictureBox pbGameProgressComputer;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblWeapon;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.RadioButton rbRock;
        private System.Windows.Forms.RadioButton rbScissors;
        private System.Windows.Forms.RadioButton rbPaper;
        private System.Windows.Forms.PictureBox pbUserChoice;
        private System.Windows.Forms.PictureBox pbComputerChoice;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnReset;
    }
}

