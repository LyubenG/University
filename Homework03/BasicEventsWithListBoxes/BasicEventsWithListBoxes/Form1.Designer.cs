namespace BasicEventsWithListBoxes
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
            this.lbNumbers = new System.Windows.Forms.ListBox();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.lbNames = new System.Windows.Forms.ListBox();
            this.lblCountNumbers = new System.Windows.Forms.Label();
            this.lblCountNames = new System.Windows.Forms.Label();
            this.lbThird = new System.Windows.Forms.ListBox();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnClearItem = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblEnter = new System.Windows.Forms.Label();
            this.tbEnter = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNumbers
            // 
            this.lbNumbers.FormattingEnabled = true;
            this.lbNumbers.Location = new System.Drawing.Point(29, 58);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbNumbers.Size = new System.Drawing.Size(210, 95);
            this.lbNumbers.TabIndex = 0;
            // 
            // lblNumbers
            // 
            this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumbers.Location = new System.Drawing.Point(26, 42);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(213, 13);
            this.lblNumbers.TabIndex = 1;
            this.lblNumbers.Text = "Numbers";
            this.lblNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNames
            // 
            this.lblNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNames.Location = new System.Drawing.Point(353, 42);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(213, 13);
            this.lblNames.TabIndex = 3;
            this.lblNames.Text = "Names";
            this.lblNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNames
            // 
            this.lbNames.FormattingEnabled = true;
            this.lbNames.Location = new System.Drawing.Point(356, 58);
            this.lbNames.Name = "lbNames";
            this.lbNames.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbNames.Size = new System.Drawing.Size(210, 95);
            this.lbNames.TabIndex = 2;
            // 
            // lblCountNumbers
            // 
            this.lblCountNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountNumbers.Location = new System.Drawing.Point(26, 186);
            this.lblCountNumbers.Name = "lblCountNumbers";
            this.lblCountNumbers.Size = new System.Drawing.Size(213, 13);
            this.lblCountNumbers.TabIndex = 4;
            this.lblCountNumbers.Text = "Count numbers: ";
            this.lblCountNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountNames
            // 
            this.lblCountNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountNames.Location = new System.Drawing.Point(353, 186);
            this.lblCountNames.Name = "lblCountNames";
            this.lblCountNames.Size = new System.Drawing.Size(213, 13);
            this.lblCountNames.TabIndex = 5;
            this.lblCountNames.Text = "Count names: ";
            this.lblCountNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbThird
            // 
            this.lbThird.FormattingEnabled = true;
            this.lbThird.Location = new System.Drawing.Point(162, 239);
            this.lbThird.Name = "lbThird";
            this.lbThird.Size = new System.Drawing.Size(232, 95);
            this.lbThird.TabIndex = 6;
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.Location = new System.Drawing.Point(93, 160);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(75, 23);
            this.btnAddNumber.TabIndex = 7;
            this.btnAddNumber.Text = "Add Number";
            this.btnAddNumber.UseVisualStyleBackColor = true;
            this.btnAddNumber.Click += new System.EventHandler(this.btnAddNumber_Click);
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(424, 159);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(75, 23);
            this.btnAddName.TabIndex = 8;
            this.btnAddName.Text = "Add Names";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(453, 239);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 9;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnClearItem
            // 
            this.btnClearItem.Location = new System.Drawing.Point(453, 268);
            this.btnClearItem.Name = "btnClearItem";
            this.btnClearItem.Size = new System.Drawing.Size(75, 23);
            this.btnClearItem.TabIndex = 10;
            this.btnClearItem.Text = "Clear Item";
            this.btnClearItem.UseVisualStyleBackColor = true;
            this.btnClearItem.Click += new System.EventHandler(this.btnClearItem_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(453, 297);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 11;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(453, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblEnter
            // 
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnter.Location = new System.Drawing.Point(58, 394);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(156, 32);
            this.lblEnter.TabIndex = 13;
            this.lblEnter.Text = "Enter: ";
            this.lblEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEnter
            // 
            this.tbEnter.Location = new System.Drawing.Point(162, 401);
            this.tbEnter.Name = "tbEnter";
            this.tbEnter.Size = new System.Drawing.Size(229, 20);
            this.tbEnter.TabIndex = 14;
            this.tbEnter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEnter_KeyPress);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(183, 424);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(172, 13);
            this.lblInfo.TabIndex = 15;
            this.lblInfo.Text = "(Use enter button on the keyboard)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tbEnter);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClearItem);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.btnAddNumber);
            this.Controls.Add(this.lbThird);
            this.Controls.Add(this.lblCountNames);
            this.Controls.Add(this.lblCountNumbers);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.lbNames);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.lbNumbers);
            this.Name = "MainForm";
            this.Text = "Basic Events With ListBoxes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNumbers;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.ListBox lbNames;
        private System.Windows.Forms.Label lblCountNumbers;
        private System.Windows.Forms.Label lblCountNames;
        private System.Windows.Forms.ListBox lbThird;
        private System.Windows.Forms.Button btnAddNumber;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnClearItem;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox tbEnter;
        private System.Windows.Forms.Label lblInfo;
    }
}

