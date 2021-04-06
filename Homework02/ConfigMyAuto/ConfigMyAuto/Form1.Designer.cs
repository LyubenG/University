namespace ConfigMyAuto
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
            this.panelAdditionalOptions = new System.Windows.Forms.Panel();
            this.cbChains = new System.Windows.Forms.CheckBox();
            this.cbFogLights = new System.Windows.Forms.CheckBox();
            this.cbAbsOption = new System.Windows.Forms.CheckBox();
            this.panelCars = new System.Windows.Forms.Panel();
            this.picAllCars = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.lblAdditionalFeatures = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.rbCheck = new System.Windows.Forms.RadioButton();
            this.rbInCash = new System.Windows.Forms.RadioButton();
            this.panelTotalSum = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.rbBmw = new System.Windows.Forms.RadioButton();
            this.panelChooseCar = new System.Windows.Forms.Panel();
            this.rbMercedes = new System.Windows.Forms.RadioButton();
            this.rbAudi = new System.Windows.Forms.RadioButton();
            this.lblChooseCar = new System.Windows.Forms.Label();
            this.panelAdditionalInfo = new System.Windows.Forms.Panel();
            this.lblAdditionalInfo = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblGearType = new System.Windows.Forms.Label();
            this.lblNrOfDoors = new System.Windows.Forms.Label();
            this.lblKilometersDriven = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.btnCalculateSum = new System.Windows.Forms.Button();
            this.lblDiscountFeature = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSavedMoney = new System.Windows.Forms.Label();
            this.panelAdditionalOptions.SuspendLayout();
            this.panelCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAllCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelPayment.SuspendLayout();
            this.panelTotalSum.SuspendLayout();
            this.panelChooseCar.SuspendLayout();
            this.panelAdditionalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdditionalOptions
            // 
            this.panelAdditionalOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panelAdditionalOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAdditionalOptions.Controls.Add(this.lblDiscountFeature);
            this.panelAdditionalOptions.Controls.Add(this.lblAdditionalFeatures);
            this.panelAdditionalOptions.Controls.Add(this.cbChains);
            this.panelAdditionalOptions.Controls.Add(this.cbFogLights);
            this.panelAdditionalOptions.Controls.Add(this.cbAbsOption);
            this.panelAdditionalOptions.Location = new System.Drawing.Point(24, 337);
            this.panelAdditionalOptions.Name = "panelAdditionalOptions";
            this.panelAdditionalOptions.Size = new System.Drawing.Size(308, 134);
            this.panelAdditionalOptions.TabIndex = 11;
            // 
            // cbChains
            // 
            this.cbChains.AutoSize = true;
            this.cbChains.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbChains.Location = new System.Drawing.Point(36, 83);
            this.cbChains.Name = "cbChains";
            this.cbChains.Size = new System.Drawing.Size(91, 17);
            this.cbChains.TabIndex = 2;
            this.cbChains.Text = "Chains (+20$)";
            this.cbChains.UseVisualStyleBackColor = true;
            // 
            // cbFogLights
            // 
            this.cbFogLights.AutoSize = true;
            this.cbFogLights.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbFogLights.Location = new System.Drawing.Point(36, 60);
            this.cbFogLights.Name = "cbFogLights";
            this.cbFogLights.Size = new System.Drawing.Size(108, 17);
            this.cbFogLights.TabIndex = 1;
            this.cbFogLights.Text = "Fog Lights (+15$)";
            this.cbFogLights.UseVisualStyleBackColor = true;
            // 
            // cbAbsOption
            // 
            this.cbAbsOption.AutoSize = true;
            this.cbAbsOption.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbAbsOption.Location = new System.Drawing.Point(36, 37);
            this.cbAbsOption.Name = "cbAbsOption";
            this.cbAbsOption.Size = new System.Drawing.Size(80, 17);
            this.cbAbsOption.TabIndex = 0;
            this.cbAbsOption.Text = "ABS (+30$)";
            this.cbAbsOption.UseVisualStyleBackColor = true;
            // 
            // panelCars
            // 
            this.panelCars.Controls.Add(this.picAllCars);
            this.panelCars.Location = new System.Drawing.Point(24, 75);
            this.panelCars.Name = "panelCars";
            this.panelCars.Size = new System.Drawing.Size(308, 181);
            this.panelCars.TabIndex = 7;
            // 
            // picAllCars
            // 
            this.picAllCars.Image = global::ConfigMyAuto.Properties.Resources.FirstCarBmw;
            this.picAllCars.Location = new System.Drawing.Point(0, 0);
            this.picAllCars.Name = "picAllCars";
            this.picAllCars.Size = new System.Drawing.Size(308, 181);
            this.picAllCars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAllCars.TabIndex = 0;
            this.picAllCars.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Image = global::ConfigMyAuto.Properties.Resources.Logo;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(776, 58);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 12;
            this.picLogo.TabStop = false;
            // 
            // panelPayment
            // 
            this.panelPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panelPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPayment.Controls.Add(this.label1);
            this.panelPayment.Controls.Add(this.rbInCash);
            this.panelPayment.Controls.Add(this.rbCheck);
            this.panelPayment.Controls.Add(this.rbCreditCard);
            this.panelPayment.Controls.Add(this.lblPayment);
            this.panelPayment.Location = new System.Drawing.Point(429, 314);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(308, 91);
            this.panelPayment.TabIndex = 12;
            // 
            // lblAdditionalFeatures
            // 
            this.lblAdditionalFeatures.AutoSize = true;
            this.lblAdditionalFeatures.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblAdditionalFeatures.Location = new System.Drawing.Point(103, 13);
            this.lblAdditionalFeatures.Name = "lblAdditionalFeatures";
            this.lblAdditionalFeatures.Size = new System.Drawing.Size(97, 13);
            this.lblAdditionalFeatures.TabIndex = 3;
            this.lblAdditionalFeatures.Text = "Additional Features";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblPayment.Location = new System.Drawing.Point(108, 10);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(87, 13);
            this.lblPayment.TabIndex = 4;
            this.lblPayment.Text = "Payment Options";
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbCreditCard.Location = new System.Drawing.Point(21, 36);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(77, 17);
            this.rbCreditCard.TabIndex = 5;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "Credit Card";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            // 
            // rbCheck
            // 
            this.rbCheck.AutoSize = true;
            this.rbCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbCheck.Location = new System.Drawing.Point(123, 36);
            this.rbCheck.Name = "rbCheck";
            this.rbCheck.Size = new System.Drawing.Size(56, 17);
            this.rbCheck.TabIndex = 6;
            this.rbCheck.TabStop = true;
            this.rbCheck.Text = "Check";
            this.rbCheck.UseVisualStyleBackColor = true;
            // 
            // rbInCash
            // 
            this.rbInCash.AutoSize = true;
            this.rbInCash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbInCash.Location = new System.Drawing.Point(210, 36);
            this.rbInCash.Name = "rbInCash";
            this.rbInCash.Size = new System.Drawing.Size(61, 17);
            this.rbInCash.TabIndex = 7;
            this.rbInCash.TabStop = true;
            this.rbInCash.Text = "In Cash";
            this.rbInCash.UseVisualStyleBackColor = true;
            // 
            // panelTotalSum
            // 
            this.panelTotalSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panelTotalSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTotalSum.Controls.Add(this.lblSavedMoney);
            this.panelTotalSum.Controls.Add(this.lblTotal);
            this.panelTotalSum.Location = new System.Drawing.Point(429, 449);
            this.panelTotalSum.Name = "panelTotalSum";
            this.panelTotalSum.Size = new System.Drawing.Size(308, 35);
            this.panelTotalSum.TabIndex = 13;
            this.panelTotalSum.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotal.Location = new System.Drawing.Point(18, 7);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Your total is:";
            // 
            // rbBmw
            // 
            this.rbBmw.AutoSize = true;
            this.rbBmw.Checked = true;
            this.rbBmw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbBmw.Location = new System.Drawing.Point(9, 35);
            this.rbBmw.Name = "rbBmw";
            this.rbBmw.Size = new System.Drawing.Size(74, 17);
            this.rbBmw.TabIndex = 14;
            this.rbBmw.TabStop = true;
            this.rbBmw.Text = "BMW E60";
            this.rbBmw.UseVisualStyleBackColor = true;
            this.rbBmw.CheckedChanged += new System.EventHandler(this.rbBmw_CheckedChanged);
            // 
            // panelChooseCar
            // 
            this.panelChooseCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panelChooseCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelChooseCar.Controls.Add(this.lblChooseCar);
            this.panelChooseCar.Controls.Add(this.rbAudi);
            this.panelChooseCar.Controls.Add(this.rbMercedes);
            this.panelChooseCar.Controls.Add(this.rbBmw);
            this.panelChooseCar.Location = new System.Drawing.Point(24, 262);
            this.panelChooseCar.Name = "panelChooseCar";
            this.panelChooseCar.Size = new System.Drawing.Size(308, 69);
            this.panelChooseCar.TabIndex = 14;
            // 
            // rbMercedes
            // 
            this.rbMercedes.AutoSize = true;
            this.rbMercedes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbMercedes.Location = new System.Drawing.Point(89, 35);
            this.rbMercedes.Name = "rbMercedes";
            this.rbMercedes.Size = new System.Drawing.Size(137, 17);
            this.rbMercedes.TabIndex = 15;
            this.rbMercedes.Text = "Mercedes-Benz C-Class";
            this.rbMercedes.UseVisualStyleBackColor = true;
            this.rbMercedes.CheckedChanged += new System.EventHandler(this.rbMercedes_CheckedChanged);
            // 
            // rbAudi
            // 
            this.rbAudi.AutoSize = true;
            this.rbAudi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbAudi.Location = new System.Drawing.Point(232, 35);
            this.rbAudi.Name = "rbAudi";
            this.rbAudi.Size = new System.Drawing.Size(62, 17);
            this.rbAudi.TabIndex = 16;
            this.rbAudi.Text = "Audi A3";
            this.rbAudi.UseVisualStyleBackColor = true;
            this.rbAudi.CheckedChanged += new System.EventHandler(this.rbAudi_CheckedChanged);
            // 
            // lblChooseCar
            // 
            this.lblChooseCar.AutoSize = true;
            this.lblChooseCar.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblChooseCar.Location = new System.Drawing.Point(65, 10);
            this.lblChooseCar.Name = "lblChooseCar";
            this.lblChooseCar.Size = new System.Drawing.Size(181, 13);
            this.lblChooseCar.TabIndex = 4;
            this.lblChooseCar.Text = "Choose the car you would like to buy";
            // 
            // panelAdditionalInfo
            // 
            this.panelAdditionalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panelAdditionalInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAdditionalInfo.Controls.Add(this.lblBasePrice);
            this.panelAdditionalInfo.Controls.Add(this.lblKilometersDriven);
            this.panelAdditionalInfo.Controls.Add(this.lblNrOfDoors);
            this.panelAdditionalInfo.Controls.Add(this.lblGearType);
            this.panelAdditionalInfo.Controls.Add(this.lblCondition);
            this.panelAdditionalInfo.Controls.Add(this.lblYear);
            this.panelAdditionalInfo.Controls.Add(this.lblAdditionalInfo);
            this.panelAdditionalInfo.Location = new System.Drawing.Point(429, 75);
            this.panelAdditionalInfo.Name = "panelAdditionalInfo";
            this.panelAdditionalInfo.Size = new System.Drawing.Size(308, 212);
            this.panelAdditionalInfo.TabIndex = 12;
            // 
            // lblAdditionalInfo
            // 
            this.lblAdditionalInfo.AutoSize = true;
            this.lblAdditionalInfo.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblAdditionalInfo.Location = new System.Drawing.Point(102, 10);
            this.lblAdditionalInfo.Name = "lblAdditionalInfo";
            this.lblAdditionalInfo.Size = new System.Drawing.Size(108, 13);
            this.lblAdditionalInfo.TabIndex = 3;
            this.lblAdditionalInfo.Text = "Additional Information";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYear.Location = new System.Drawing.Point(36, 47);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(62, 13);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year : 2008";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCondition.Location = new System.Drawing.Point(178, 47);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(82, 13);
            this.lblCondition.TabIndex = 5;
            this.lblCondition.Text = "Condition: Used";
            // 
            // lblGearType
            // 
            this.lblGearType.AutoSize = true;
            this.lblGearType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGearType.Location = new System.Drawing.Point(32, 94);
            this.lblGearType.Name = "lblGearType";
            this.lblGearType.Size = new System.Drawing.Size(113, 13);
            this.lblGearType.TabIndex = 6;
            this.lblGearType.Text = "Gear Type: Automatic ";
            // 
            // lblNrOfDoors
            // 
            this.lblNrOfDoors.AutoSize = true;
            this.lblNrOfDoors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNrOfDoors.Location = new System.Drawing.Point(178, 94);
            this.lblNrOfDoors.Name = "lblNrOfDoors";
            this.lblNrOfDoors.Size = new System.Drawing.Size(78, 13);
            this.lblNrOfDoors.TabIndex = 7;
            this.lblNrOfDoors.Text = "Nr. Of Doors: 4";
            // 
            // lblKilometersDriven
            // 
            this.lblKilometersDriven.AutoSize = true;
            this.lblKilometersDriven.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKilometersDriven.Location = new System.Drawing.Point(82, 136);
            this.lblKilometersDriven.Name = "lblKilometersDriven";
            this.lblKilometersDriven.Size = new System.Drawing.Size(145, 13);
            this.lblKilometersDriven.TabIndex = 8;
            this.lblKilometersDriven.Text = "Kilometers Driven: 76 435 km";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBasePrice.Location = new System.Drawing.Point(95, 166);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(100, 13);
            this.lblBasePrice.TabIndex = 9;
            this.lblBasePrice.Text = "Base Price: 7,800$ ";
            // 
            // btnCalculateSum
            // 
            this.btnCalculateSum.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnCalculateSum.FlatAppearance.BorderSize = 2;
            this.btnCalculateSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculateSum.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnCalculateSum.Location = new System.Drawing.Point(516, 415);
            this.btnCalculateSum.Name = "btnCalculateSum";
            this.btnCalculateSum.Size = new System.Drawing.Size(129, 28);
            this.btnCalculateSum.TabIndex = 15;
            this.btnCalculateSum.Text = "Calculate total";
            this.btnCalculateSum.UseVisualStyleBackColor = true;
            this.btnCalculateSum.Click += new System.EventHandler(this.btnCalculateSum_Click);
            // 
            // lblDiscountFeature
            // 
            this.lblDiscountFeature.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDiscountFeature.Location = new System.Drawing.Point(189, 39);
            this.lblDiscountFeature.Name = "lblDiscountFeature";
            this.lblDiscountFeature.Size = new System.Drawing.Size(89, 56);
            this.lblDiscountFeature.TabIndex = 4;
            this.lblDiscountFeature.Text = "If the three features are selected you will get 10% off them";
            this.lblDiscountFeature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "If you choose to pay in cash you get additional 5% discount!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSavedMoney
            // 
            this.lblSavedMoney.AutoSize = true;
            this.lblSavedMoney.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSavedMoney.Location = new System.Drawing.Point(149, 7);
            this.lblSavedMoney.Name = "lblSavedMoney";
            this.lblSavedMoney.Size = new System.Drawing.Size(64, 13);
            this.lblSavedMoney.TabIndex = 5;
            this.lblSavedMoney.Text = "You saved: ";
            this.lblSavedMoney.Visible = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(776, 496);
            this.Controls.Add(this.btnCalculateSum);
            this.Controls.Add(this.panelAdditionalInfo);
            this.Controls.Add(this.panelChooseCar);
            this.Controls.Add(this.panelTotalSum);
            this.Controls.Add(this.panelPayment);
            this.Controls.Add(this.panelAdditionalOptions);
            this.Controls.Add(this.panelCars);
            this.Controls.Add(this.picLogo);
            this.Name = "MainPage";
            this.Text = "ConfigureMyAuto";
            this.panelAdditionalOptions.ResumeLayout(false);
            this.panelAdditionalOptions.PerformLayout();
            this.panelCars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAllCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelPayment.ResumeLayout(false);
            this.panelPayment.PerformLayout();
            this.panelTotalSum.ResumeLayout(false);
            this.panelTotalSum.PerformLayout();
            this.panelChooseCar.ResumeLayout(false);
            this.panelChooseCar.PerformLayout();
            this.panelAdditionalInfo.ResumeLayout(false);
            this.panelAdditionalInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAllCars;
        private System.Windows.Forms.Panel panelAdditionalOptions;
        private System.Windows.Forms.CheckBox cbChains;
        private System.Windows.Forms.CheckBox cbFogLights;
        private System.Windows.Forms.CheckBox cbAbsOption;
        private System.Windows.Forms.Panel panelCars;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblAdditionalFeatures;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.RadioButton rbInCash;
        private System.Windows.Forms.RadioButton rbCheck;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Panel panelTotalSum;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.RadioButton rbBmw;
        private System.Windows.Forms.Panel panelChooseCar;
        private System.Windows.Forms.RadioButton rbAudi;
        private System.Windows.Forms.RadioButton rbMercedes;
        private System.Windows.Forms.Label lblChooseCar;
        private System.Windows.Forms.Panel panelAdditionalInfo;
        private System.Windows.Forms.Label lblAdditionalInfo;
        private System.Windows.Forms.Label lblGearType;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblKilometersDriven;
        private System.Windows.Forms.Label lblNrOfDoors;
        private System.Windows.Forms.Label lblDiscountFeature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculateSum;
        private System.Windows.Forms.Label lblSavedMoney;
    }
}

