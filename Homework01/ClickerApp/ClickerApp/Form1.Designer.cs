namespace ClickerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.logoText = new System.Windows.Forms.Label();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblClickCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // logoImage
            // 
            this.logoImage.Image = global::ClickerApp.Properties.Resources.logo;
            this.logoImage.Location = new System.Drawing.Point(285, 26);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(234, 66);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoImage.TabIndex = 0;
            this.logoImage.TabStop = false;
            // 
            // logoText
            // 
            this.logoText.AutoSize = true;
            this.logoText.ForeColor = System.Drawing.Color.White;
            this.logoText.Location = new System.Drawing.Point(338, 69);
            this.logoText.Name = "logoText";
            this.logoText.Size = new System.Drawing.Size(123, 13);
            this.logoText.TabIndex = 1;
            this.logoText.Text = "Click away the boredom!";
            // 
            // btnClickMe
            // 
            this.btnClickMe.FlatAppearance.BorderSize = 2;
            this.btnClickMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClickMe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClickMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(69)))), ((int)(((byte)(165)))));
            this.btnClickMe.Location = new System.Drawing.Point(309, 330);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(193, 30);
            this.btnClickMe.TabIndex = 2;
            this.btnClickMe.Text = "CLICK ME!";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(69)))), ((int)(((byte)(165)))));
            this.btnReset.Location = new System.Drawing.Point(363, 366);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 25);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset Score";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblClickCounter
            // 
            this.lblClickCounter.AutoSize = true;
            this.lblClickCounter.Font = new System.Drawing.Font("Franklin Gothic Demi", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClickCounter.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblClickCounter.Location = new System.Drawing.Point(343, 152);
            this.lblClickCounter.Name = "lblClickCounter";
            this.lblClickCounter.Size = new System.Drawing.Size(106, 120);
            this.lblClickCounter.TabIndex = 4;
            this.lblClickCounter.Text = "0";
            this.lblClickCounter.Click += new System.EventHandler(this.lblClickCounter_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblClickCounter);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClickMe);
            this.Controls.Add(this.logoText);
            this.Controls.Add(this.logoImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "Impressive Cliker";
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Label logoText;
        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblClickCounter;
    }
}

