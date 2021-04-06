namespace GuessTheNumber
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
            this.pnlButtonHolder = new System.Windows.Forms.Panel();
            this.pnlPlayButton = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlChooseDiff = new System.Windows.Forms.Panel();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.cbDifficulty = new System.Windows.Forms.ComboBox();
            this.pnlThumbsHolder = new System.Windows.Forms.Panel();
            this.lblTriesLeft = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tbNumberGuess = new System.Windows.Forms.TextBox();
            this.pbThumbs = new System.Windows.Forms.PictureBox();
            this.lblGenerated = new System.Windows.Forms.Label();
            this.pnlReset = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbRestartButtonHolder = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlButtonHolder.SuspendLayout();
            this.pnlPlayButton.SuspendLayout();
            this.pnlChooseDiff.SuspendLayout();
            this.pnlThumbsHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbs)).BeginInit();
            this.pnlReset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestartButtonHolder)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.pbLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(424, 61);
            this.pnlHeader.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::GuessTheNumber.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(424, 61);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlButtonHolder
            // 
            this.pnlButtonHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtonHolder.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtonHolder.Controls.Add(this.pnlPlayButton);
            this.pnlButtonHolder.Controls.Add(this.pnlChooseDiff);
            this.pnlButtonHolder.Location = new System.Drawing.Point(0, 110);
            this.pnlButtonHolder.Name = "pnlButtonHolder";
            this.pnlButtonHolder.Size = new System.Drawing.Size(424, 77);
            this.pnlButtonHolder.TabIndex = 1;
            // 
            // pnlPlayButton
            // 
            this.pnlPlayButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlPlayButton.BackgroundImage = global::GuessTheNumber.Properties.Resources.Bar;
            this.pnlPlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPlayButton.Controls.Add(this.btnStart);
            this.pnlPlayButton.Location = new System.Drawing.Point(253, 1);
            this.pnlPlayButton.Name = "pnlPlayButton";
            this.pnlPlayButton.Size = new System.Drawing.Size(139, 76);
            this.pnlPlayButton.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::GuessTheNumber.Properties.Resources.PlayButton;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStart.Location = new System.Drawing.Point(14, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStart_MouseDown);
            this.btnStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStart_MouseUp);
            // 
            // pnlChooseDiff
            // 
            this.pnlChooseDiff.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlChooseDiff.BackgroundImage = global::GuessTheNumber.Properties.Resources.Bar;
            this.pnlChooseDiff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlChooseDiff.Controls.Add(this.lblDifficulty);
            this.pnlChooseDiff.Controls.Add(this.cbDifficulty);
            this.pnlChooseDiff.Location = new System.Drawing.Point(30, 1);
            this.pnlChooseDiff.Name = "pnlChooseDiff";
            this.pnlChooseDiff.Size = new System.Drawing.Size(149, 76);
            this.pnlChooseDiff.TabIndex = 0;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDifficulty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDifficulty.Location = new System.Drawing.Point(15, 12);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(131, 20);
            this.lblDifficulty.TabIndex = 2;
            this.lblDifficulty.Text = "Choose difficulty level!";
            // 
            // cbDifficulty
            // 
            this.cbDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDifficulty.BackColor = System.Drawing.Color.SlateGray;
            this.cbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDifficulty.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.cbDifficulty.Items.AddRange(new object[] {
            "1-10",
            "1-50",
            "1-100",
            "1-1000"});
            this.cbDifficulty.Location = new System.Drawing.Point(15, 35);
            this.cbDifficulty.MaxLength = 4;
            this.cbDifficulty.Name = "cbDifficulty";
            this.cbDifficulty.Size = new System.Drawing.Size(116, 21);
            this.cbDifficulty.TabIndex = 0;
            // 
            // pnlThumbsHolder
            // 
            this.pnlThumbsHolder.BackColor = System.Drawing.Color.Transparent;
            this.pnlThumbsHolder.BackgroundImage = global::GuessTheNumber.Properties.Resources.panelBackground2;
            this.pnlThumbsHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlThumbsHolder.Controls.Add(this.lblTriesLeft);
            this.pnlThumbsHolder.Controls.Add(this.btnCheck);
            this.pnlThumbsHolder.Controls.Add(this.tbNumberGuess);
            this.pnlThumbsHolder.Controls.Add(this.pbThumbs);
            this.pnlThumbsHolder.Location = new System.Drawing.Point(0, 209);
            this.pnlThumbsHolder.Name = "pnlThumbsHolder";
            this.pnlThumbsHolder.Size = new System.Drawing.Size(428, 111);
            this.pnlThumbsHolder.TabIndex = 2;
            // 
            // lblTriesLeft
            // 
            this.lblTriesLeft.AutoSize = true;
            this.lblTriesLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTriesLeft.Location = new System.Drawing.Point(268, 86);
            this.lblTriesLeft.Name = "lblTriesLeft";
            this.lblTriesLeft.Size = new System.Drawing.Size(110, 13);
            this.lblTriesLeft.TabIndex = 5;
            this.lblTriesLeft.Text = "You have 10 tries left!";
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCheck.FlatAppearance.BorderSize = 2;
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(267, 53);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(111, 30);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check number";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tbNumberGuess
            // 
            this.tbNumberGuess.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbNumberGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNumberGuess.Enabled = false;
            this.tbNumberGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNumberGuess.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tbNumberGuess.Location = new System.Drawing.Point(242, 14);
            this.tbNumberGuess.MaxLength = 4;
            this.tbNumberGuess.Name = "tbNumberGuess";
            this.tbNumberGuess.Size = new System.Drawing.Size(161, 22);
            this.tbNumberGuess.TabIndex = 3;
            this.tbNumberGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbThumbs
            // 
            this.pbThumbs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbThumbs.Image = global::GuessTheNumber.Properties.Resources.NumberHolder2;
            this.pbThumbs.Location = new System.Drawing.Point(33, 0);
            this.pbThumbs.Name = "pbThumbs";
            this.pbThumbs.Size = new System.Drawing.Size(143, 111);
            this.pbThumbs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbThumbs.TabIndex = 0;
            this.pbThumbs.TabStop = false;
            // 
            // lblGenerated
            // 
            this.lblGenerated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGenerated.BackColor = System.Drawing.Color.Transparent;
            this.lblGenerated.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGenerated.Location = new System.Drawing.Point(111, 190);
            this.lblGenerated.Name = "lblGenerated";
            this.lblGenerated.Size = new System.Drawing.Size(203, 16);
            this.lblGenerated.TabIndex = 3;
            this.lblGenerated.Text = "A Random Number Has Been Generated!";
            this.lblGenerated.Visible = false;
            // 
            // pnlReset
            // 
            this.pnlReset.BackColor = System.Drawing.Color.Transparent;
            this.pnlReset.Controls.Add(this.btnReset);
            this.pnlReset.Controls.Add(this.pbRestartButtonHolder);
            this.pnlReset.Location = new System.Drawing.Point(0, 336);
            this.pnlReset.Name = "pnlReset";
            this.pnlReset.Size = new System.Drawing.Size(424, 107);
            this.pnlReset.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.btnReset.BackgroundImage = global::GuessTheNumber.Properties.Resources.ResetButton1;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Location = new System.Drawing.Point(169, 26);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 50);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset Game";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnReset_MouseDown);
            this.btnReset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnReset_MouseUp);
            // 
            // pbRestartButtonHolder
            // 
            this.pbRestartButtonHolder.Image = global::GuessTheNumber.Properties.Resources.Bar;
            this.pbRestartButtonHolder.Location = new System.Drawing.Point(153, 0);
            this.pbRestartButtonHolder.Name = "pbRestartButtonHolder";
            this.pbRestartButtonHolder.Size = new System.Drawing.Size(139, 107);
            this.pbRestartButtonHolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRestartButtonHolder.TabIndex = 0;
            this.pbRestartButtonHolder.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::GuessTheNumber.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(424, 509);
            this.Controls.Add(this.pnlReset);
            this.Controls.Add(this.lblGenerated);
            this.Controls.Add(this.pnlThumbsHolder);
            this.Controls.Add(this.pnlButtonHolder);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Guess The Number";
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlButtonHolder.ResumeLayout(false);
            this.pnlPlayButton.ResumeLayout(false);
            this.pnlChooseDiff.ResumeLayout(false);
            this.pnlThumbsHolder.ResumeLayout(false);
            this.pnlThumbsHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbs)).EndInit();
            this.pnlReset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRestartButtonHolder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlButtonHolder;
        private System.Windows.Forms.Panel pnlChooseDiff;
        private System.Windows.Forms.Panel pnlPlayButton;
        private System.Windows.Forms.ComboBox cbDifficulty;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlThumbsHolder;
        private System.Windows.Forms.PictureBox pbThumbs;
        private System.Windows.Forms.TextBox tbNumberGuess;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblGenerated;
        private System.Windows.Forms.Label lblTriesLeft;
        private System.Windows.Forms.Panel pnlReset;
        private System.Windows.Forms.PictureBox pbRestartButtonHolder;
        private System.Windows.Forms.Button btnReset;
    }
}

