
namespace Week_4_A
{
    partial class frmJoesAutomotive
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblServiceLabor = new System.Windows.Forms.Label();
            this.lblParts2 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblActualServiceLabor = new System.Windows.Forms.Label();
            this.lblActualParts = new System.Windows.Forms.Label();
            this.lblActualPartsTax = new System.Windows.Forms.Label();
            this.lblActualTotalFees = new System.Windows.Forms.Label();
            this.lblParts1 = new System.Windows.Forms.Label();
            this.lblLabor = new System.Windows.Forms.Label();
            this.txtParts = new System.Windows.Forms.TextBox();
            this.txtLabor = new System.Windows.Forms.TextBox();
            this.chkOilChange = new System.Windows.Forms.CheckBox();
            this.grbOilLube = new System.Windows.Forms.GroupBox();
            this.chkLubeJob = new System.Windows.Forms.CheckBox();
            this.grbPartsLabor = new System.Windows.Forms.GroupBox();
            this.grbFlushes = new System.Windows.Forms.GroupBox();
            this.chkTransmission = new System.Windows.Forms.CheckBox();
            this.chkRadiator = new System.Windows.Forms.CheckBox();
            this.grbMisc = new System.Windows.Forms.GroupBox();
            this.chkTireRotation = new System.Windows.Forms.CheckBox();
            this.chkReplaceMuffler = new System.Windows.Forms.CheckBox();
            this.chkInspection = new System.Windows.Forms.CheckBox();
            this.grRental = new System.Windows.Forms.GroupBox();
            this.chkRentalCars = new System.Windows.Forms.CheckBox();
            this.lblDailyPrice = new System.Windows.Forms.Label();
            this.txtDailyPrice = new System.Windows.Forms.TextBox();
            this.lblNumDays = new System.Windows.Forms.Label();
            this.txtNumDays = new System.Windows.Forms.TextBox();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.grbOilLube.SuspendLayout();
            this.grbPartsLabor.SuspendLayout();
            this.grbFlushes.SuspendLayout();
            this.grbMisc.SuspendLayout();
            this.grRental.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(469, 59);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(72, 37);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(469, 115);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(72, 37);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(469, 172);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblServiceLabor
            // 
            this.lblServiceLabor.AutoSize = true;
            this.lblServiceLabor.Location = new System.Drawing.Point(9, 22);
            this.lblServiceLabor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceLabor.Name = "lblServiceLabor";
            this.lblServiceLabor.Size = new System.Drawing.Size(97, 13);
            this.lblServiceLabor.TabIndex = 3;
            this.lblServiceLabor.Text = "Service and Labor:";
            // 
            // lblParts2
            // 
            this.lblParts2.AutoSize = true;
            this.lblParts2.Location = new System.Drawing.Point(70, 48);
            this.lblParts2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParts2.Name = "lblParts2";
            this.lblParts2.Size = new System.Drawing.Size(34, 13);
            this.lblParts2.TabIndex = 4;
            this.lblParts2.Text = "Parts:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(28, 80);
            this.lblTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(75, 13);
            this.lblTax.TabIndex = 5;
            this.lblTax.Text = "Tax (on parts):";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Location = new System.Drawing.Point(43, 121);
            this.lblTotalFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(60, 13);
            this.lblTotalFees.TabIndex = 6;
            this.lblTotalFees.Text = "Total Fees:";
            // 
            // lblActualServiceLabor
            // 
            this.lblActualServiceLabor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblActualServiceLabor.Location = new System.Drawing.Point(108, 18);
            this.lblActualServiceLabor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActualServiceLabor.Name = "lblActualServiceLabor";
            this.lblActualServiceLabor.Size = new System.Drawing.Size(65, 23);
            this.lblActualServiceLabor.TabIndex = 7;
            this.lblActualServiceLabor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActualParts
            // 
            this.lblActualParts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblActualParts.Location = new System.Drawing.Point(108, 47);
            this.lblActualParts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActualParts.Name = "lblActualParts";
            this.lblActualParts.Size = new System.Drawing.Size(65, 23);
            this.lblActualParts.TabIndex = 8;
            this.lblActualParts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActualPartsTax
            // 
            this.lblActualPartsTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblActualPartsTax.Location = new System.Drawing.Point(108, 78);
            this.lblActualPartsTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActualPartsTax.Name = "lblActualPartsTax";
            this.lblActualPartsTax.Size = new System.Drawing.Size(65, 25);
            this.lblActualPartsTax.TabIndex = 9;
            this.lblActualPartsTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActualTotalFees
            // 
            this.lblActualTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblActualTotalFees.Location = new System.Drawing.Point(108, 115);
            this.lblActualTotalFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActualTotalFees.Name = "lblActualTotalFees";
            this.lblActualTotalFees.Size = new System.Drawing.Size(65, 24);
            this.lblActualTotalFees.TabIndex = 10;
            this.lblActualTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblParts1
            // 
            this.lblParts1.AutoSize = true;
            this.lblParts1.Location = new System.Drawing.Point(29, 32);
            this.lblParts1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParts1.Name = "lblParts1";
            this.lblParts1.Size = new System.Drawing.Size(49, 13);
            this.lblParts1.TabIndex = 11;
            this.lblParts1.Text = "Parts ($):";
            // 
            // lblLabor
            // 
            this.lblLabor.AutoSize = true;
            this.lblLabor.Location = new System.Drawing.Point(16, 57);
            this.lblLabor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLabor.Name = "lblLabor";
            this.lblLabor.Size = new System.Drawing.Size(62, 13);
            this.lblLabor.TabIndex = 12;
            this.lblLabor.Text = "Labor (Hrs):";
            // 
            // txtParts
            // 
            this.txtParts.Location = new System.Drawing.Point(82, 29);
            this.txtParts.Margin = new System.Windows.Forms.Padding(2);
            this.txtParts.Name = "txtParts";
            this.txtParts.Size = new System.Drawing.Size(52, 20);
            this.txtParts.TabIndex = 13;
            // 
            // txtLabor
            // 
            this.txtLabor.Location = new System.Drawing.Point(82, 57);
            this.txtLabor.Margin = new System.Windows.Forms.Padding(2);
            this.txtLabor.Name = "txtLabor";
            this.txtLabor.Size = new System.Drawing.Size(52, 20);
            this.txtLabor.TabIndex = 14;
            // 
            // chkOilChange
            // 
            this.chkOilChange.AutoSize = true;
            this.chkOilChange.Location = new System.Drawing.Point(10, 21);
            this.chkOilChange.Margin = new System.Windows.Forms.Padding(2);
            this.chkOilChange.Name = "chkOilChange";
            this.chkOilChange.Size = new System.Drawing.Size(120, 17);
            this.chkOilChange.TabIndex = 15;
            this.chkOilChange.Text = "Oil Change ($26.00)";
            this.chkOilChange.UseVisualStyleBackColor = true;
            // 
            // grbOilLube
            // 
            this.grbOilLube.Controls.Add(this.chkLubeJob);
            this.grbOilLube.Controls.Add(this.chkOilChange);
            this.grbOilLube.Location = new System.Drawing.Point(14, 18);
            this.grbOilLube.Margin = new System.Windows.Forms.Padding(2);
            this.grbOilLube.Name = "grbOilLube";
            this.grbOilLube.Padding = new System.Windows.Forms.Padding(2);
            this.grbOilLube.Size = new System.Drawing.Size(142, 74);
            this.grbOilLube.TabIndex = 17;
            this.grbOilLube.TabStop = false;
            this.grbOilLube.Text = "Oil and Lube";
            // 
            // chkLubeJob
            // 
            this.chkLubeJob.AutoSize = true;
            this.chkLubeJob.Location = new System.Drawing.Point(10, 50);
            this.chkLubeJob.Margin = new System.Windows.Forms.Padding(2);
            this.chkLubeJob.Name = "chkLubeJob";
            this.chkLubeJob.Size = new System.Drawing.Size(112, 17);
            this.chkLubeJob.TabIndex = 16;
            this.chkLubeJob.Text = "Lube Job ($18.00)";
            this.chkLubeJob.UseVisualStyleBackColor = true;
            // 
            // grbPartsLabor
            // 
            this.grbPartsLabor.Controls.Add(this.lblParts1);
            this.grbPartsLabor.Controls.Add(this.txtParts);
            this.grbPartsLabor.Controls.Add(this.txtLabor);
            this.grbPartsLabor.Controls.Add(this.lblLabor);
            this.grbPartsLabor.Location = new System.Drawing.Point(210, 115);
            this.grbPartsLabor.Margin = new System.Windows.Forms.Padding(2);
            this.grbPartsLabor.Name = "grbPartsLabor";
            this.grbPartsLabor.Padding = new System.Windows.Forms.Padding(2);
            this.grbPartsLabor.Size = new System.Drawing.Size(177, 98);
            this.grbPartsLabor.TabIndex = 20;
            this.grbPartsLabor.TabStop = false;
            this.grbPartsLabor.Text = "Parts and Labor";
            // 
            // grbFlushes
            // 
            this.grbFlushes.Controls.Add(this.chkTransmission);
            this.grbFlushes.Controls.Add(this.chkRadiator);
            this.grbFlushes.Location = new System.Drawing.Point(207, 11);
            this.grbFlushes.Margin = new System.Windows.Forms.Padding(2);
            this.grbFlushes.Name = "grbFlushes";
            this.grbFlushes.Padding = new System.Windows.Forms.Padding(2);
            this.grbFlushes.Size = new System.Drawing.Size(194, 82);
            this.grbFlushes.TabIndex = 18;
            this.grbFlushes.TabStop = false;
            this.grbFlushes.Text = "Flushes";
            // 
            // chkTransmission
            // 
            this.chkTransmission.AutoSize = true;
            this.chkTransmission.Location = new System.Drawing.Point(18, 57);
            this.chkTransmission.Margin = new System.Windows.Forms.Padding(2);
            this.chkTransmission.Name = "chkTransmission";
            this.chkTransmission.Size = new System.Drawing.Size(159, 17);
            this.chkTransmission.TabIndex = 21;
            this.chkTransmission.Text = "Transmission Fllush ($80.00)";
            this.chkTransmission.UseVisualStyleBackColor = true;
            // 
            // chkRadiator
            // 
            this.chkRadiator.AutoSize = true;
            this.chkRadiator.Location = new System.Drawing.Point(18, 27);
            this.chkRadiator.Margin = new System.Windows.Forms.Padding(2);
            this.chkRadiator.Name = "chkRadiator";
            this.chkRadiator.Size = new System.Drawing.Size(136, 17);
            this.chkRadiator.TabIndex = 20;
            this.chkRadiator.Text = "Radiator Flush ($30.00)";
            this.chkRadiator.UseVisualStyleBackColor = true;
            // 
            // grbMisc
            // 
            this.grbMisc.Controls.Add(this.chkTireRotation);
            this.grbMisc.Controls.Add(this.chkReplaceMuffler);
            this.grbMisc.Controls.Add(this.chkInspection);
            this.grbMisc.Location = new System.Drawing.Point(14, 110);
            this.grbMisc.Margin = new System.Windows.Forms.Padding(2);
            this.grbMisc.Name = "grbMisc";
            this.grbMisc.Padding = new System.Windows.Forms.Padding(2);
            this.grbMisc.Size = new System.Drawing.Size(178, 124);
            this.grbMisc.TabIndex = 19;
            this.grbMisc.TabStop = false;
            this.grbMisc.Text = "Misc";
            // 
            // chkTireRotation
            // 
            this.chkTireRotation.AutoSize = true;
            this.chkTireRotation.Location = new System.Drawing.Point(10, 82);
            this.chkTireRotation.Margin = new System.Windows.Forms.Padding(2);
            this.chkTireRotation.Name = "chkTireRotation";
            this.chkTireRotation.Size = new System.Drawing.Size(129, 17);
            this.chkTireRotation.TabIndex = 2;
            this.chkTireRotation.Text = "Tire Rotation ($20.00)";
            this.chkTireRotation.UseVisualStyleBackColor = true;
            // 
            // chkReplaceMuffler
            // 
            this.chkReplaceMuffler.AutoSize = true;
            this.chkReplaceMuffler.Location = new System.Drawing.Point(10, 49);
            this.chkReplaceMuffler.Margin = new System.Windows.Forms.Padding(2);
            this.chkReplaceMuffler.Name = "chkReplaceMuffler";
            this.chkReplaceMuffler.Size = new System.Drawing.Size(149, 17);
            this.chkReplaceMuffler.TabIndex = 1;
            this.chkReplaceMuffler.Text = "Replace Muffler ($100.00)";
            this.chkReplaceMuffler.UseVisualStyleBackColor = true;
            // 
            // chkInspection
            // 
            this.chkInspection.AutoSize = true;
            this.chkInspection.Location = new System.Drawing.Point(10, 17);
            this.chkInspection.Margin = new System.Windows.Forms.Padding(2);
            this.chkInspection.Name = "chkInspection";
            this.chkInspection.Size = new System.Drawing.Size(117, 17);
            this.chkInspection.TabIndex = 0;
            this.chkInspection.Text = "Inspection ($15.00)";
            this.chkInspection.UseVisualStyleBackColor = true;
            // 
            // grRental
            // 
            this.grRental.Controls.Add(this.chkRentalCars);
            this.grRental.Controls.Add(this.lblDailyPrice);
            this.grRental.Controls.Add(this.txtDailyPrice);
            this.grRental.Controls.Add(this.lblNumDays);
            this.grRental.Controls.Add(this.txtNumDays);
            this.grRental.Location = new System.Drawing.Point(8, 250);
            this.grRental.Name = "grRental";
            this.grRental.Size = new System.Drawing.Size(233, 150);
            this.grRental.TabIndex = 22;
            this.grRental.TabStop = false;
            this.grRental.Text = "Rental Cars";
            // 
            // chkRentalCars
            // 
            this.chkRentalCars.AutoSize = true;
            this.chkRentalCars.Location = new System.Drawing.Point(16, 19);
            this.chkRentalCars.Name = "chkRentalCars";
            this.chkRentalCars.Size = new System.Drawing.Size(145, 17);
            this.chkRentalCars.TabIndex = 27;
            this.chkRentalCars.Text = "Will Need Rental Service";
            this.chkRentalCars.UseVisualStyleBackColor = true;
            this.chkRentalCars.CheckedChanged += new System.EventHandler(this.chkRentalCars_CheckedChanged);
            // 
            // lblDailyPrice
            // 
            this.lblDailyPrice.AutoSize = true;
            this.lblDailyPrice.Location = new System.Drawing.Point(10, 93);
            this.lblDailyPrice.Name = "lblDailyPrice";
            this.lblDailyPrice.Size = new System.Drawing.Size(143, 13);
            this.lblDailyPrice.TabIndex = 26;
            this.lblDailyPrice.Text = "Daily Price for Rental Car ($):";
            // 
            // txtDailyPrice
            // 
            this.txtDailyPrice.Enabled = false;
            this.txtDailyPrice.Location = new System.Drawing.Point(159, 90);
            this.txtDailyPrice.Name = "txtDailyPrice";
            this.txtDailyPrice.Size = new System.Drawing.Size(63, 20);
            this.txtDailyPrice.TabIndex = 25;
            this.txtDailyPrice.Text = "50.00";
            // 
            // lblNumDays
            // 
            this.lblNumDays.AutoSize = true;
            this.lblNumDays.Location = new System.Drawing.Point(7, 58);
            this.lblNumDays.Name = "lblNumDays";
            this.lblNumDays.Size = new System.Drawing.Size(149, 13);
            this.lblNumDays.TabIndex = 24;
            this.lblNumDays.Text = "Please Enter Number of Days:";
            // 
            // txtNumDays
            // 
            this.txtNumDays.Enabled = false;
            this.txtNumDays.Location = new System.Drawing.Point(159, 55);
            this.txtNumDays.Name = "txtNumDays";
            this.txtNumDays.Size = new System.Drawing.Size(63, 20);
            this.txtNumDays.TabIndex = 23;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblServiceLabor);
            this.grpSummary.Controls.Add(this.lblActualServiceLabor);
            this.grpSummary.Controls.Add(this.lblParts2);
            this.grpSummary.Controls.Add(this.lblActualParts);
            this.grpSummary.Controls.Add(this.lblTax);
            this.grpSummary.Controls.Add(this.lblActualTotalFees);
            this.grpSummary.Controls.Add(this.lblTotalFees);
            this.grpSummary.Controls.Add(this.lblActualPartsTax);
            this.grpSummary.Location = new System.Drawing.Point(258, 244);
            this.grpSummary.Margin = new System.Windows.Forms.Padding(2);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Padding = new System.Windows.Forms.Padding(2);
            this.grpSummary.Size = new System.Drawing.Size(223, 150);
            this.grpSummary.TabIndex = 23;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // frmJoesAutomotive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 412);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grRental);
            this.Controls.Add(this.grbMisc);
            this.Controls.Add(this.grbFlushes);
            this.Controls.Add(this.grbPartsLabor);
            this.Controls.Add(this.grbOilLube);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmJoesAutomotive";
            this.Text = "Joe\'s Automotive";
            this.grbOilLube.ResumeLayout(false);
            this.grbOilLube.PerformLayout();
            this.grbPartsLabor.ResumeLayout(false);
            this.grbPartsLabor.PerformLayout();
            this.grbFlushes.ResumeLayout(false);
            this.grbFlushes.PerformLayout();
            this.grbMisc.ResumeLayout(false);
            this.grbMisc.PerformLayout();
            this.grRental.ResumeLayout(false);
            this.grRental.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblServiceLabor;
        private System.Windows.Forms.Label lblParts2;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblActualServiceLabor;
        private System.Windows.Forms.Label lblActualParts;
        private System.Windows.Forms.Label lblActualPartsTax;
        private System.Windows.Forms.Label lblActualTotalFees;
        private System.Windows.Forms.Label lblParts1;
        private System.Windows.Forms.Label lblLabor;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.TextBox txtLabor;
        private System.Windows.Forms.CheckBox chkOilChange;
        private System.Windows.Forms.GroupBox grbOilLube;
        private System.Windows.Forms.CheckBox chkLubeJob;
        private System.Windows.Forms.GroupBox grbPartsLabor;
        private System.Windows.Forms.GroupBox grbFlushes;
        private System.Windows.Forms.CheckBox chkTransmission;
        private System.Windows.Forms.CheckBox chkRadiator;
        private System.Windows.Forms.GroupBox grbMisc;
        private System.Windows.Forms.CheckBox chkTireRotation;
        private System.Windows.Forms.CheckBox chkReplaceMuffler;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.GroupBox grRental;
        private System.Windows.Forms.Label lblDailyPrice;
        private System.Windows.Forms.TextBox txtDailyPrice;
        private System.Windows.Forms.Label lblNumDays;
        private System.Windows.Forms.TextBox txtNumDays;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.CheckBox chkRentalCars;
    }
}

