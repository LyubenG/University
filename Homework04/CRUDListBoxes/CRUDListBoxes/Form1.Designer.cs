namespace CRUDListBoxes
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemoveElement = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbAddElement = new System.Windows.Forms.TextBox();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.tbUpdate = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblPressEnter = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbElements
            // 
            this.lbElements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lbElements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbElements.ForeColor = System.Drawing.SystemColors.Window;
            this.lbElements.FormattingEnabled = true;
            this.lbElements.ItemHeight = 15;
            this.lbElements.Location = new System.Drawing.Point(47, 78);
            this.lbElements.Name = "lbElements";
            this.lbElements.Size = new System.Drawing.Size(274, 257);
            this.lbElements.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(348, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add element";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoveElement
            // 
            this.btnRemoveElement.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnRemoveElement.FlatAppearance.BorderSize = 2;
            this.btnRemoveElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveElement.ForeColor = System.Drawing.Color.Lime;
            this.btnRemoveElement.Location = new System.Drawing.Point(348, 146);
            this.btnRemoveElement.Name = "btnRemoveElement";
            this.btnRemoveElement.Size = new System.Drawing.Size(130, 27);
            this.btnRemoveElement.TabIndex = 2;
            this.btnRemoveElement.Text = "Remove Element";
            this.btnRemoveElement.UseVisualStyleBackColor = true;
            this.btnRemoveElement.Click += new System.EventHandler(this.btnRemoveElement_Click);
            // 
            // btnSort
            // 
            this.btnSort.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnSort.FlatAppearance.BorderSize = 2;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.ForeColor = System.Drawing.Color.Lime;
            this.btnSort.Location = new System.Drawing.Point(348, 296);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(130, 39);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Sort Elements";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.Lime;
            this.btnSearch.Location = new System.Drawing.Point(348, 258);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 32);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Lime;
            this.btnUpdate.Location = new System.Drawing.Point(348, 220);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 32);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Element";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbAddElement
            // 
            this.tbAddElement.Location = new System.Drawing.Point(348, 78);
            this.tbAddElement.Name = "tbAddElement";
            this.tbAddElement.Size = new System.Drawing.Size(130, 20);
            this.tbAddElement.TabIndex = 7;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnRemoveAll.FlatAppearance.BorderSize = 2;
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveAll.ForeColor = System.Drawing.Color.Lime;
            this.btnRemoveAll.Location = new System.Drawing.Point(348, 179);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(130, 35);
            this.btnRemoveAll.TabIndex = 8;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // tbUpdate
            // 
            this.tbUpdate.Location = new System.Drawing.Point(47, 370);
            this.tbUpdate.Name = "tbUpdate";
            this.tbUpdate.Size = new System.Drawing.Size(194, 20);
            this.tbUpdate.TabIndex = 9;
            this.tbUpdate.Visible = false;
            this.tbUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUpdate_KeyPress);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChange.Location = new System.Drawing.Point(69, 354);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(145, 13);
            this.lblChange.TabIndex = 10;
            this.lblChange.Text = "Change the selected element";
            this.lblChange.Visible = false;
            // 
            // lblPressEnter
            // 
            this.lblPressEnter.AutoSize = true;
            this.lblPressEnter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPressEnter.Location = new System.Drawing.Point(82, 393);
            this.lblPressEnter.Name = "lblPressEnter";
            this.lblPressEnter.Size = new System.Drawing.Size(122, 13);
            this.lblPressEnter.TabIndex = 11;
            this.lblPressEnter.Text = "(Press enter when done)";
            this.lblPressEnter.Visible = false;
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEnter.Location = new System.Drawing.Point(319, 393);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(122, 13);
            this.lblEnter.TabIndex = 14;
            this.lblEnter.Text = "(Press enter when done)";
            this.lblEnter.Visible = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearch.Location = new System.Drawing.Point(345, 354);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(84, 13);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Text = "Search for item: ";
            this.lblSearch.Visible = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(284, 370);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(194, 20);
            this.tbSearch.TabIndex = 12;
            this.tbSearch.Visible = false;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLogo.Location = new System.Drawing.Point(205, 23);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(103, 39);
            this.lblLogo.TabIndex = 15;
            this.lblLogo.Text = "CRUD";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(511, 418);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblPressEnter);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.tbUpdate);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.tbAddElement);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemoveElement);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbElements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD List Boxes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbElements;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemoveElement;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbAddElement;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.TextBox tbUpdate;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblPressEnter;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblLogo;
    }
}

