namespace PositionChanger
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
            this.lbElements = new System.Windows.Forms.ListBox();
            this.btnBottom = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnOneUp = new System.Windows.Forms.Button();
            this.btnOneDown = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbAddElement = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblAddItem = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbElements
            // 
            this.lbElements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lbElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbElements.ForeColor = System.Drawing.SystemColors.Window;
            this.lbElements.FormattingEnabled = true;
            this.lbElements.ItemHeight = 15;
            this.lbElements.Location = new System.Drawing.Point(29, 115);
            this.lbElements.Name = "lbElements";
            this.lbElements.Size = new System.Drawing.Size(239, 199);
            this.lbElements.TabIndex = 0;
            // 
            // btnBottom
            // 
            this.btnBottom.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnBottom.FlatAppearance.BorderSize = 2;
            this.btnBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBottom.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnBottom.Location = new System.Drawing.Point(286, 115);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(107, 25);
            this.btnBottom.TabIndex = 1;
            this.btnBottom.Text = "Move To Bottom";
            this.btnBottom.UseVisualStyleBackColor = true;
            this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
            // 
            // btnTop
            // 
            this.btnTop.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnTop.FlatAppearance.BorderSize = 2;
            this.btnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTop.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnTop.Location = new System.Drawing.Point(286, 158);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(107, 25);
            this.btnTop.TabIndex = 2;
            this.btnTop.Text = "Move To Top";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnOneUp
            // 
            this.btnOneUp.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnOneUp.FlatAppearance.BorderSize = 2;
            this.btnOneUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOneUp.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnOneUp.Location = new System.Drawing.Point(286, 200);
            this.btnOneUp.Name = "btnOneUp";
            this.btnOneUp.Size = new System.Drawing.Size(107, 25);
            this.btnOneUp.TabIndex = 3;
            this.btnOneUp.Text = "One Up";
            this.btnOneUp.UseVisualStyleBackColor = true;
            this.btnOneUp.Click += new System.EventHandler(this.btnOneUp_Click);
            // 
            // btnOneDown
            // 
            this.btnOneDown.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnOneDown.FlatAppearance.BorderSize = 2;
            this.btnOneDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOneDown.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnOneDown.Location = new System.Drawing.Point(286, 244);
            this.btnOneDown.Name = "btnOneDown";
            this.btnOneDown.Size = new System.Drawing.Size(107, 25);
            this.btnOneDown.TabIndex = 4;
            this.btnOneDown.Text = "One Down";
            this.btnOneDown.UseVisualStyleBackColor = true;
            this.btnOneDown.Click += new System.EventHandler(this.btnOneDown_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.Crimson;
            this.btnExit.Location = new System.Drawing.Point(157, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 25);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbAddElement
            // 
            this.tbAddElement.Location = new System.Drawing.Point(29, 89);
            this.tbAddElement.Name = "tbAddElement";
            this.tbAddElement.Size = new System.Drawing.Size(239, 20);
            this.tbAddElement.TabIndex = 6;
            this.tbAddElement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddElement_KeyPress);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnRemove.FlatAppearance.BorderSize = 2;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnRemove.Location = new System.Drawing.Point(286, 289);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(107, 25);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove Element";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblAddItem
            // 
            this.lblAddItem.AutoSize = true;
            this.lblAddItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddItem.Location = new System.Drawing.Point(26, 73);
            this.lblAddItem.Name = "lblAddItem";
            this.lblAddItem.Size = new System.Drawing.Size(80, 13);
            this.lblAddItem.TabIndex = 8;
            this.lblAddItem.Text = "Add New Item: ";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLogo.Location = new System.Drawing.Point(133, 32);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(155, 25);
            this.lblLogo.TabIndex = 9;
            this.lblLogo.Text = "Position Changer";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(422, 451);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblAddItem);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tbAddElement);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOneDown);
            this.Controls.Add(this.btnOneUp);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.lbElements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Position Changer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbElements;
        private System.Windows.Forms.Button btnBottom;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnOneUp;
        private System.Windows.Forms.Button btnOneDown;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbAddElement;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblAddItem;
        private System.Windows.Forms.Label lblLogo;
    }
}

