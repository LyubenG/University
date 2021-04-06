namespace Queens
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.pbFortune = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnGetFortune = new System.Windows.Forms.Button();
            this.lbFortunes = new System.Windows.Forms.ListBox();
            this.tbAddFortune = new System.Windows.Forms.TextBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblFortune = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.tbEdit = new System.Windows.Forms.TextBox();
            this.lblEdit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFortune)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(347, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 25);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add fortune";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pbFortune
            // 
            this.pbFortune.Image = global::Queens.Properties.Resources.Cap;
            this.pbFortune.Location = new System.Drawing.Point(41, 55);
            this.pbFortune.Name = "pbFortune";
            this.pbFortune.Size = new System.Drawing.Size(262, 230);
            this.pbFortune.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFortune.TabIndex = 1;
            this.pbFortune.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRemove.FlatAppearance.BorderSize = 2;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRemove.Location = new System.Drawing.Point(347, 209);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(109, 25);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove fortune";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChange.FlatAppearance.BorderSize = 2;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChange.Location = new System.Drawing.Point(347, 250);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(109, 25);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Change fortune";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnGetFortune
            // 
            this.btnGetFortune.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGetFortune.FlatAppearance.BorderSize = 2;
            this.btnGetFortune.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetFortune.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGetFortune.Location = new System.Drawing.Point(326, 127);
            this.btnGetFortune.Name = "btnGetFortune";
            this.btnGetFortune.Size = new System.Drawing.Size(145, 25);
            this.btnGetFortune.TabIndex = 4;
            this.btnGetFortune.Text = "Get your daily fortune";
            this.btnGetFortune.UseVisualStyleBackColor = true;
            this.btnGetFortune.Click += new System.EventHandler(this.btnGetFortune_Click);
            // 
            // lbFortunes
            // 
            this.lbFortunes.FormattingEnabled = true;
            this.lbFortunes.Location = new System.Drawing.Point(513, 56);
            this.lbFortunes.Name = "lbFortunes";
            this.lbFortunes.Size = new System.Drawing.Size(289, 264);
            this.lbFortunes.TabIndex = 5;
            // 
            // tbAddFortune
            // 
            this.tbAddFortune.Location = new System.Drawing.Point(62, 342);
            this.tbAddFortune.Name = "tbAddFortune";
            this.tbAddFortune.Size = new System.Drawing.Size(203, 20);
            this.tbAddFortune.TabIndex = 6;
            this.tbAddFortune.Visible = false;
            this.tbAddFortune.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddFortune_KeyPress);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAdd.Location = new System.Drawing.Point(59, 326);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(206, 13);
            this.lblAdd.TabIndex = 7;
            this.lblAdd.Text = "Add your fortune: (Press enter when done)";
            this.lblAdd.Visible = false;
            // 
            // lblFortune
            // 
            this.lblFortune.BackColor = System.Drawing.Color.Transparent;
            this.lblFortune.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFortune.ForeColor = System.Drawing.Color.Black;
            this.lblFortune.Location = new System.Drawing.Point(59, 85);
            this.lblFortune.Name = "lblFortune";
            this.lblFortune.Size = new System.Drawing.Size(144, 58);
            this.lblFortune.TabIndex = 8;
            this.lblFortune.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShow
            // 
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShow.FlatAppearance.BorderSize = 2;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShow.Location = new System.Drawing.Point(326, 169);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(145, 25);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Show/Hide admin panel";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // tbEdit
            // 
            this.tbEdit.Location = new System.Drawing.Point(558, 342);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(203, 20);
            this.tbEdit.TabIndex = 10;
            this.tbEdit.Visible = false;
            this.tbEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEdit_KeyPress);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEdit.Location = new System.Drawing.Point(555, 326);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(205, 13);
            this.lblEdit.TabIndex = 11;
            this.lblEdit.Text = "Edit your fortune: (Press enter when done)";
            this.lblEdit.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(824, 379);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.tbEdit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblFortune);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.tbAddFortune);
            this.Controls.Add(this.lbFortunes);
            this.Controls.Add(this.btnGetFortune);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.pbFortune);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Your Daily Fortune";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFortune)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pbFortune;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnGetFortune;
        private System.Windows.Forms.ListBox lbFortunes;
        private System.Windows.Forms.TextBox tbAddFortune;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblFortune;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox tbEdit;
        private System.Windows.Forms.Label lblEdit;
    }
}

