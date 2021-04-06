namespace Library
{
    partial class Form1
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
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblNameOfBook = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.tbNameAuthor = new System.Windows.Forms.TextBox();
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.btnEnterData = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.lblNameToSearch = new System.Windows.Forms.Label();
            this.tbAuthorSearch = new System.Windows.Forms.TextBox();
            this.lblAuthorSearch = new System.Windows.Forms.Label();
            this.btnSearchNow = new System.Windows.Forms.Button();
            this.tbNameEdit = new System.Windows.Forms.TextBox();
            this.lblEditName = new System.Windows.Forms.Label();
            this.lblEditAuthor = new System.Windows.Forms.Label();
            this.tbAuthorEdit = new System.Windows.Forms.TextBox();
            this.btnEditNow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(221, 46);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(112, 13);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Enter Name of Author:";
            // 
            // lblNameOfBook
            // 
            this.lblNameOfBook.AutoSize = true;
            this.lblNameOfBook.Location = new System.Drawing.Point(74, 46);
            this.lblNameOfBook.Name = "lblNameOfBook";
            this.lblNameOfBook.Size = new System.Drawing.Size(106, 13);
            this.lblNameOfBook.TabIndex = 1;
            this.lblNameOfBook.Text = "Enter Name of Book:";
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(77, 62);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(112, 20);
            this.tbBookName.TabIndex = 2;
            // 
            // tbNameAuthor
            // 
            this.tbNameAuthor.Location = new System.Drawing.Point(224, 62);
            this.tbNameAuthor.Name = "tbNameAuthor";
            this.tbNameAuthor.Size = new System.Drawing.Size(112, 20);
            this.tbNameAuthor.TabIndex = 3;
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(60, 161);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(256, 186);
            this.lbBooks.TabIndex = 4;
            // 
            // btnEnterData
            // 
            this.btnEnterData.Location = new System.Drawing.Point(144, 107);
            this.btnEnterData.Name = "btnEnterData";
            this.btnEnterData.Size = new System.Drawing.Size(126, 28);
            this.btnEnterData.TabIndex = 5;
            this.btnEnterData.Text = "Enter Data!";
            this.btnEnterData.UseVisualStyleBackColor = true;
            this.btnEnterData.Click += new System.EventHandler(this.btnEnterData_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(347, 161);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search for a book!";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(347, 206);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(141, 35);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove the selected book!";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(347, 258);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(141, 35);
            this.btnSort.TabIndex = 8;
            this.btnSort.Text = "Sort items";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(347, 312);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(141, 35);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit selected element";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(60, 389);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(145, 20);
            this.tbSearchName.TabIndex = 10;
            this.tbSearchName.Visible = false;
            // 
            // lblNameToSearch
            // 
            this.lblNameToSearch.AutoSize = true;
            this.lblNameToSearch.Location = new System.Drawing.Point(44, 373);
            this.lblNameToSearch.Name = "lblNameToSearch";
            this.lblNameToSearch.Size = new System.Drawing.Size(190, 13);
            this.lblNameToSearch.TabIndex = 11;
            this.lblNameToSearch.Text = "Enter Name of Book To Be Searched: ";
            this.lblNameToSearch.Visible = false;
            // 
            // tbAuthorSearch
            // 
            this.tbAuthorSearch.Location = new System.Drawing.Point(60, 436);
            this.tbAuthorSearch.Name = "tbAuthorSearch";
            this.tbAuthorSearch.Size = new System.Drawing.Size(145, 20);
            this.tbAuthorSearch.TabIndex = 12;
            this.tbAuthorSearch.Visible = false;
            // 
            // lblAuthorSearch
            // 
            this.lblAuthorSearch.AutoSize = true;
            this.lblAuthorSearch.Location = new System.Drawing.Point(42, 420);
            this.lblAuthorSearch.Name = "lblAuthorSearch";
            this.lblAuthorSearch.Size = new System.Drawing.Size(189, 13);
            this.lblAuthorSearch.TabIndex = 13;
            this.lblAuthorSearch.Text = "Enter Name of Author to be searched: ";
            this.lblAuthorSearch.Visible = false;
            // 
            // btnSearchNow
            // 
            this.btnSearchNow.Location = new System.Drawing.Point(70, 468);
            this.btnSearchNow.Name = "btnSearchNow";
            this.btnSearchNow.Size = new System.Drawing.Size(118, 30);
            this.btnSearchNow.TabIndex = 14;
            this.btnSearchNow.Text = "Search for the book!";
            this.btnSearchNow.UseVisualStyleBackColor = true;
            this.btnSearchNow.Visible = false;
            this.btnSearchNow.Click += new System.EventHandler(this.btnSearchNow_Click);
            // 
            // tbNameEdit
            // 
            this.tbNameEdit.Location = new System.Drawing.Point(323, 389);
            this.tbNameEdit.Name = "tbNameEdit";
            this.tbNameEdit.Size = new System.Drawing.Size(145, 20);
            this.tbNameEdit.TabIndex = 15;
            this.tbNameEdit.Visible = false;
            // 
            // lblEditName
            // 
            this.lblEditName.AutoSize = true;
            this.lblEditName.Location = new System.Drawing.Point(320, 373);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(138, 13);
            this.lblEditName.TabIndex = 16;
            this.lblEditName.Text = "Edit the current Book Name";
            this.lblEditName.Visible = false;
            // 
            // lblEditAuthor
            // 
            this.lblEditAuthor.AutoSize = true;
            this.lblEditAuthor.Location = new System.Drawing.Point(320, 420);
            this.lblEditAuthor.Name = "lblEditAuthor";
            this.lblEditAuthor.Size = new System.Drawing.Size(141, 13);
            this.lblEditAuthor.TabIndex = 18;
            this.lblEditAuthor.Text = "Edit the current Book Author";
            this.lblEditAuthor.Visible = false;
            // 
            // tbAuthorEdit
            // 
            this.tbAuthorEdit.Location = new System.Drawing.Point(323, 436);
            this.tbAuthorEdit.Name = "tbAuthorEdit";
            this.tbAuthorEdit.Size = new System.Drawing.Size(145, 20);
            this.tbAuthorEdit.TabIndex = 17;
            this.tbAuthorEdit.Visible = false;
            // 
            // btnEditNow
            // 
            this.btnEditNow.Location = new System.Drawing.Point(340, 472);
            this.btnEditNow.Name = "btnEditNow";
            this.btnEditNow.Size = new System.Drawing.Size(118, 30);
            this.btnEditNow.TabIndex = 19;
            this.btnEditNow.Text = "Edit!";
            this.btnEditNow.UseVisualStyleBackColor = true;
            this.btnEditNow.Visible = false;
            this.btnEditNow.Click += new System.EventHandler(this.btnEditNow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 514);
            this.Controls.Add(this.btnEditNow);
            this.Controls.Add(this.lblEditAuthor);
            this.Controls.Add(this.tbAuthorEdit);
            this.Controls.Add(this.lblEditName);
            this.Controls.Add(this.tbNameEdit);
            this.Controls.Add(this.btnSearchNow);
            this.Controls.Add(this.lblAuthorSearch);
            this.Controls.Add(this.tbAuthorSearch);
            this.Controls.Add(this.lblNameToSearch);
            this.Controls.Add(this.tbSearchName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEnterData);
            this.Controls.Add(this.lbBooks);
            this.Controls.Add(this.tbNameAuthor);
            this.Controls.Add(this.tbBookName);
            this.Controls.Add(this.lblNameOfBook);
            this.Controls.Add(this.lblAuthor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblNameOfBook;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.TextBox tbNameAuthor;
        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button btnEnterData;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.Label lblNameToSearch;
        private System.Windows.Forms.TextBox tbAuthorSearch;
        private System.Windows.Forms.Label lblAuthorSearch;
        private System.Windows.Forms.Button btnSearchNow;
        private System.Windows.Forms.TextBox tbNameEdit;
        private System.Windows.Forms.Label lblEditName;
        private System.Windows.Forms.Label lblEditAuthor;
        private System.Windows.Forms.TextBox tbAuthorEdit;
        private System.Windows.Forms.Button btnEditNow;
    }
}

