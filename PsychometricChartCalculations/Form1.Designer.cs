namespace PsychometricChartCalculations
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
            this.groupBoxVar1 = new System.Windows.Forms.GroupBox();
            this.textBoxFirstVar = new System.Windows.Forms.TextBox();
            this.radioButtonRelHumidity1 = new System.Windows.Forms.RadioButton();
            this.radioButtonSpecHumidity1 = new System.Windows.Forms.RadioButton();
            this.radioButtonWetBulbTemp1 = new System.Windows.Forms.RadioButton();
            this.radioButtonDryBulbTemp1 = new System.Windows.Forms.RadioButton();
            this.groupBoxVar2 = new System.Windows.Forms.GroupBox();
            this.textBoxSecondVar = new System.Windows.Forms.TextBox();
            this.radioButtonRelHumidity2 = new System.Windows.Forms.RadioButton();
            this.radioButtonSpecHumidity2 = new System.Windows.Forms.RadioButton();
            this.radioButtonWetBulbTemp2 = new System.Windows.Forms.RadioButton();
            this.radioButtonDryBulbTemp2 = new System.Windows.Forms.RadioButton();
            this.labelAmbientPressure = new System.Windows.Forms.Label();
            this.textBoxAmbPressure = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.labelSpecVolumeResult = new System.Windows.Forms.Label();
            this.labelSpecHumidityResult = new System.Windows.Forms.Label();
            this.labelRelHumidityResult = new System.Windows.Forms.Label();
            this.labelEnthalpyResult = new System.Windows.Forms.Label();
            this.labelAmbPressureResult = new System.Windows.Forms.Label();
            this.labelWetBulbTempResult = new System.Windows.Forms.Label();
            this.labelDryBulbTempResult = new System.Windows.Forms.Label();
            this.textBoxAmbPressureResult = new System.Windows.Forms.TextBox();
            this.textBoxWetBulbTempResult = new System.Windows.Forms.TextBox();
            this.textBoxSpecHumidityResult = new System.Windows.Forms.TextBox();
            this.textBoxRelHumidityResult = new System.Windows.Forms.TextBox();
            this.textBoxEnthalpyResult = new System.Windows.Forms.TextBox();
            this.textBoxSpecVolumeResult = new System.Windows.Forms.TextBox();
            this.textBoxDryBulbTempResult = new System.Windows.Forms.TextBox();
            this.groupBoxVar1.SuspendLayout();
            this.groupBoxVar2.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxVar1
            // 
            this.groupBoxVar1.Controls.Add(this.textBoxFirstVar);
            this.groupBoxVar1.Controls.Add(this.radioButtonRelHumidity1);
            this.groupBoxVar1.Controls.Add(this.radioButtonSpecHumidity1);
            this.groupBoxVar1.Controls.Add(this.radioButtonWetBulbTemp1);
            this.groupBoxVar1.Controls.Add(this.radioButtonDryBulbTemp1);
            this.groupBoxVar1.Location = new System.Drawing.Point(85, 47);
            this.groupBoxVar1.Name = "groupBoxVar1";
            this.groupBoxVar1.Size = new System.Drawing.Size(455, 192);
            this.groupBoxVar1.TabIndex = 0;
            this.groupBoxVar1.TabStop = false;
            this.groupBoxVar1.Text = "Variable #1";
            // 
            // textBoxFirstVar
            // 
            this.textBoxFirstVar.Location = new System.Drawing.Point(154, 138);
            this.textBoxFirstVar.Name = "textBoxFirstVar";
            this.textBoxFirstVar.Size = new System.Drawing.Size(121, 26);
            this.textBoxFirstVar.TabIndex = 4;
            // 
            // radioButtonRelHumidity1
            // 
            this.radioButtonRelHumidity1.AutoSize = true;
            this.radioButtonRelHumidity1.Location = new System.Drawing.Point(234, 85);
            this.radioButtonRelHumidity1.Name = "radioButtonRelHumidity1";
            this.radioButtonRelHumidity1.Size = new System.Drawing.Size(156, 24);
            this.radioButtonRelHumidity1.TabIndex = 3;
            this.radioButtonRelHumidity1.TabStop = true;
            this.radioButtonRelHumidity1.Text = "Relative Humidity";
            this.radioButtonRelHumidity1.UseVisualStyleBackColor = true;
            // 
            // radioButtonSpecHumidity1
            // 
            this.radioButtonSpecHumidity1.AutoSize = true;
            this.radioButtonSpecHumidity1.Location = new System.Drawing.Point(39, 85);
            this.radioButtonSpecHumidity1.Name = "radioButtonSpecHumidity1";
            this.radioButtonSpecHumidity1.Size = new System.Drawing.Size(155, 24);
            this.radioButtonSpecHumidity1.TabIndex = 2;
            this.radioButtonSpecHumidity1.TabStop = true;
            this.radioButtonSpecHumidity1.Text = "Specific Humidity";
            this.radioButtonSpecHumidity1.UseVisualStyleBackColor = true;
            // 
            // radioButtonWetBulbTemp1
            // 
            this.radioButtonWetBulbTemp1.AutoSize = true;
            this.radioButtonWetBulbTemp1.Location = new System.Drawing.Point(234, 36);
            this.radioButtonWetBulbTemp1.Name = "radioButtonWetBulbTemp1";
            this.radioButtonWetBulbTemp1.Size = new System.Drawing.Size(194, 24);
            this.radioButtonWetBulbTemp1.TabIndex = 1;
            this.radioButtonWetBulbTemp1.TabStop = true;
            this.radioButtonWetBulbTemp1.Text = "Wet Bulb Temperature";
            this.radioButtonWetBulbTemp1.UseVisualStyleBackColor = true;
            // 
            // radioButtonDryBulbTemp1
            // 
            this.radioButtonDryBulbTemp1.AutoSize = true;
            this.radioButtonDryBulbTemp1.Location = new System.Drawing.Point(39, 36);
            this.radioButtonDryBulbTemp1.Name = "radioButtonDryBulbTemp1";
            this.radioButtonDryBulbTemp1.Size = new System.Drawing.Size(189, 24);
            this.radioButtonDryBulbTemp1.TabIndex = 0;
            this.radioButtonDryBulbTemp1.TabStop = true;
            this.radioButtonDryBulbTemp1.Text = "Dry Bulb Temperature";
            this.radioButtonDryBulbTemp1.UseVisualStyleBackColor = true;
            // 
            // groupBoxVar2
            // 
            this.groupBoxVar2.Controls.Add(this.textBoxSecondVar);
            this.groupBoxVar2.Controls.Add(this.radioButtonRelHumidity2);
            this.groupBoxVar2.Controls.Add(this.radioButtonSpecHumidity2);
            this.groupBoxVar2.Controls.Add(this.radioButtonWetBulbTemp2);
            this.groupBoxVar2.Controls.Add(this.radioButtonDryBulbTemp2);
            this.groupBoxVar2.Location = new System.Drawing.Point(85, 258);
            this.groupBoxVar2.Name = "groupBoxVar2";
            this.groupBoxVar2.Size = new System.Drawing.Size(455, 183);
            this.groupBoxVar2.TabIndex = 5;
            this.groupBoxVar2.TabStop = false;
            this.groupBoxVar2.Text = "Variable #2";
            // 
            // textBoxSecondVar
            // 
            this.textBoxSecondVar.Location = new System.Drawing.Point(154, 134);
            this.textBoxSecondVar.Name = "textBoxSecondVar";
            this.textBoxSecondVar.Size = new System.Drawing.Size(121, 26);
            this.textBoxSecondVar.TabIndex = 4;
            // 
            // radioButtonRelHumidity2
            // 
            this.radioButtonRelHumidity2.AutoSize = true;
            this.radioButtonRelHumidity2.Location = new System.Drawing.Point(234, 80);
            this.radioButtonRelHumidity2.Name = "radioButtonRelHumidity2";
            this.radioButtonRelHumidity2.Size = new System.Drawing.Size(156, 24);
            this.radioButtonRelHumidity2.TabIndex = 3;
            this.radioButtonRelHumidity2.TabStop = true;
            this.radioButtonRelHumidity2.Text = "Relative Humidity";
            this.radioButtonRelHumidity2.UseVisualStyleBackColor = true;
            // 
            // radioButtonSpecHumidity2
            // 
            this.radioButtonSpecHumidity2.AutoSize = true;
            this.radioButtonSpecHumidity2.Location = new System.Drawing.Point(39, 80);
            this.radioButtonSpecHumidity2.Name = "radioButtonSpecHumidity2";
            this.radioButtonSpecHumidity2.Size = new System.Drawing.Size(155, 24);
            this.radioButtonSpecHumidity2.TabIndex = 2;
            this.radioButtonSpecHumidity2.TabStop = true;
            this.radioButtonSpecHumidity2.Text = "Specific Humidity";
            this.radioButtonSpecHumidity2.UseVisualStyleBackColor = true;
            // 
            // radioButtonWetBulbTemp2
            // 
            this.radioButtonWetBulbTemp2.AutoSize = true;
            this.radioButtonWetBulbTemp2.Location = new System.Drawing.Point(234, 40);
            this.radioButtonWetBulbTemp2.Name = "radioButtonWetBulbTemp2";
            this.radioButtonWetBulbTemp2.Size = new System.Drawing.Size(194, 24);
            this.radioButtonWetBulbTemp2.TabIndex = 1;
            this.radioButtonWetBulbTemp2.TabStop = true;
            this.radioButtonWetBulbTemp2.Text = "Wet Bulb Temperature";
            this.radioButtonWetBulbTemp2.UseVisualStyleBackColor = true;
            // 
            // radioButtonDryBulbTemp2
            // 
            this.radioButtonDryBulbTemp2.AutoSize = true;
            this.radioButtonDryBulbTemp2.Location = new System.Drawing.Point(39, 40);
            this.radioButtonDryBulbTemp2.Name = "radioButtonDryBulbTemp2";
            this.radioButtonDryBulbTemp2.Size = new System.Drawing.Size(189, 24);
            this.radioButtonDryBulbTemp2.TabIndex = 0;
            this.radioButtonDryBulbTemp2.TabStop = true;
            this.radioButtonDryBulbTemp2.Text = "Dry Bulb Temperature";
            this.radioButtonDryBulbTemp2.UseVisualStyleBackColor = true;
            // 
            // labelAmbientPressure
            // 
            this.labelAmbientPressure.AutoSize = true;
            this.labelAmbientPressure.Location = new System.Drawing.Point(235, 456);
            this.labelAmbientPressure.Name = "labelAmbientPressure";
            this.labelAmbientPressure.Size = new System.Drawing.Size(139, 20);
            this.labelAmbientPressure.TabIndex = 5;
            this.labelAmbientPressure.Text = "Ambient Pressure:";
            // 
            // textBoxAmbPressure
            // 
            this.textBoxAmbPressure.Location = new System.Drawing.Point(239, 479);
            this.textBoxAmbPressure.Name = "textBoxAmbPressure";
            this.textBoxAmbPressure.Size = new System.Drawing.Size(121, 26);
            this.textBoxAmbPressure.TabIndex = 6;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(239, 526);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(121, 55);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(85, 526);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(121, 55);
            this.buttonCalculate.TabIndex = 9;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(392, 526);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(121, 55);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.labelSpecVolumeResult);
            this.groupBoxResults.Controls.Add(this.labelSpecHumidityResult);
            this.groupBoxResults.Controls.Add(this.labelRelHumidityResult);
            this.groupBoxResults.Controls.Add(this.labelEnthalpyResult);
            this.groupBoxResults.Controls.Add(this.labelAmbPressureResult);
            this.groupBoxResults.Controls.Add(this.labelWetBulbTempResult);
            this.groupBoxResults.Controls.Add(this.labelDryBulbTempResult);
            this.groupBoxResults.Controls.Add(this.textBoxAmbPressureResult);
            this.groupBoxResults.Controls.Add(this.textBoxWetBulbTempResult);
            this.groupBoxResults.Controls.Add(this.textBoxSpecHumidityResult);
            this.groupBoxResults.Controls.Add(this.textBoxRelHumidityResult);
            this.groupBoxResults.Controls.Add(this.textBoxEnthalpyResult);
            this.groupBoxResults.Controls.Add(this.textBoxSpecVolumeResult);
            this.groupBoxResults.Controls.Add(this.textBoxDryBulbTempResult);
            this.groupBoxResults.Location = new System.Drawing.Point(597, 56);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(313, 464);
            this.groupBoxResults.TabIndex = 12;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results";
            // 
            // labelSpecVolumeResult
            // 
            this.labelSpecVolumeResult.AutoSize = true;
            this.labelSpecVolumeResult.Location = new System.Drawing.Point(6, 339);
            this.labelSpecVolumeResult.Name = "labelSpecVolumeResult";
            this.labelSpecVolumeResult.Size = new System.Drawing.Size(127, 20);
            this.labelSpecVolumeResult.TabIndex = 19;
            this.labelSpecVolumeResult.Text = "Specific Volume:";
            // 
            // labelSpecHumidityResult
            // 
            this.labelSpecHumidityResult.AutoSize = true;
            this.labelSpecHumidityResult.Location = new System.Drawing.Point(6, 160);
            this.labelSpecHumidityResult.Name = "labelSpecHumidityResult";
            this.labelSpecHumidityResult.Size = new System.Drawing.Size(134, 20);
            this.labelSpecHumidityResult.TabIndex = 18;
            this.labelSpecHumidityResult.Text = "Specific Humidity:";
            // 
            // labelRelHumidityResult
            // 
            this.labelRelHumidityResult.AutoSize = true;
            this.labelRelHumidityResult.Location = new System.Drawing.Point(6, 222);
            this.labelRelHumidityResult.Name = "labelRelHumidityResult";
            this.labelRelHumidityResult.Size = new System.Drawing.Size(135, 20);
            this.labelRelHumidityResult.TabIndex = 17;
            this.labelRelHumidityResult.Text = "Relative Humidity:";
            // 
            // labelEnthalpyResult
            // 
            this.labelEnthalpyResult.AutoSize = true;
            this.labelEnthalpyResult.Location = new System.Drawing.Point(6, 282);
            this.labelEnthalpyResult.Name = "labelEnthalpyResult";
            this.labelEnthalpyResult.Size = new System.Drawing.Size(75, 20);
            this.labelEnthalpyResult.TabIndex = 16;
            this.labelEnthalpyResult.Text = "Enthalpy:";
            // 
            // labelAmbPressureResult
            // 
            this.labelAmbPressureResult.AutoSize = true;
            this.labelAmbPressureResult.Location = new System.Drawing.Point(6, 403);
            this.labelAmbPressureResult.Name = "labelAmbPressureResult";
            this.labelAmbPressureResult.Size = new System.Drawing.Size(139, 20);
            this.labelAmbPressureResult.TabIndex = 15;
            this.labelAmbPressureResult.Text = "Ambient Pressure:";
            // 
            // labelWetBulbTempResult
            // 
            this.labelWetBulbTempResult.AutoSize = true;
            this.labelWetBulbTempResult.Location = new System.Drawing.Point(6, 100);
            this.labelWetBulbTempResult.Name = "labelWetBulbTempResult";
            this.labelWetBulbTempResult.Size = new System.Drawing.Size(173, 20);
            this.labelWetBulbTempResult.TabIndex = 13;
            this.labelWetBulbTempResult.Text = "Wet Bulb Temperature:";
            // 
            // labelDryBulbTempResult
            // 
            this.labelDryBulbTempResult.AutoSize = true;
            this.labelDryBulbTempResult.Location = new System.Drawing.Point(6, 44);
            this.labelDryBulbTempResult.Name = "labelDryBulbTempResult";
            this.labelDryBulbTempResult.Size = new System.Drawing.Size(168, 20);
            this.labelDryBulbTempResult.TabIndex = 12;
            this.labelDryBulbTempResult.Text = "Dry Bulb Temperature:";
            // 
            // textBoxAmbPressureResult
            // 
            this.textBoxAmbPressureResult.Location = new System.Drawing.Point(181, 400);
            this.textBoxAmbPressureResult.Name = "textBoxAmbPressureResult";
            this.textBoxAmbPressureResult.ReadOnly = true;
            this.textBoxAmbPressureResult.Size = new System.Drawing.Size(116, 26);
            this.textBoxAmbPressureResult.TabIndex = 11;
            // 
            // textBoxWetBulbTempResult
            // 
            this.textBoxWetBulbTempResult.Location = new System.Drawing.Point(181, 97);
            this.textBoxWetBulbTempResult.Name = "textBoxWetBulbTempResult";
            this.textBoxWetBulbTempResult.ReadOnly = true;
            this.textBoxWetBulbTempResult.Size = new System.Drawing.Size(116, 26);
            this.textBoxWetBulbTempResult.TabIndex = 10;
            // 
            // textBoxSpecHumidityResult
            // 
            this.textBoxSpecHumidityResult.Location = new System.Drawing.Point(181, 157);
            this.textBoxSpecHumidityResult.Name = "textBoxSpecHumidityResult";
            this.textBoxSpecHumidityResult.ReadOnly = true;
            this.textBoxSpecHumidityResult.Size = new System.Drawing.Size(116, 26);
            this.textBoxSpecHumidityResult.TabIndex = 9;
            // 
            // textBoxRelHumidityResult
            // 
            this.textBoxRelHumidityResult.Location = new System.Drawing.Point(181, 219);
            this.textBoxRelHumidityResult.Name = "textBoxRelHumidityResult";
            this.textBoxRelHumidityResult.ReadOnly = true;
            this.textBoxRelHumidityResult.Size = new System.Drawing.Size(116, 26);
            this.textBoxRelHumidityResult.TabIndex = 8;
            // 
            // textBoxEnthalpyResult
            // 
            this.textBoxEnthalpyResult.Location = new System.Drawing.Point(181, 280);
            this.textBoxEnthalpyResult.Name = "textBoxEnthalpyResult";
            this.textBoxEnthalpyResult.ReadOnly = true;
            this.textBoxEnthalpyResult.Size = new System.Drawing.Size(116, 26);
            this.textBoxEnthalpyResult.TabIndex = 7;
            // 
            // textBoxSpecVolumeResult
            // 
            this.textBoxSpecVolumeResult.Location = new System.Drawing.Point(181, 336);
            this.textBoxSpecVolumeResult.Name = "textBoxSpecVolumeResult";
            this.textBoxSpecVolumeResult.ReadOnly = true;
            this.textBoxSpecVolumeResult.Size = new System.Drawing.Size(116, 26);
            this.textBoxSpecVolumeResult.TabIndex = 6;
            // 
            // textBoxDryBulbTempResult
            // 
            this.textBoxDryBulbTempResult.Location = new System.Drawing.Point(181, 41);
            this.textBoxDryBulbTempResult.Name = "textBoxDryBulbTempResult";
            this.textBoxDryBulbTempResult.ReadOnly = true;
            this.textBoxDryBulbTempResult.Size = new System.Drawing.Size(116, 26);
            this.textBoxDryBulbTempResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 627);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxAmbPressure);
            this.Controls.Add(this.labelAmbientPressure);
            this.Controls.Add(this.groupBoxVar2);
            this.Controls.Add(this.groupBoxVar1);
            this.Name = "Form1";
            this.Text = "Psychometric Chart Calculations";
            this.groupBoxVar1.ResumeLayout(false);
            this.groupBoxVar1.PerformLayout();
            this.groupBoxVar2.ResumeLayout(false);
            this.groupBoxVar2.PerformLayout();
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVar1;
        private System.Windows.Forms.TextBox textBoxFirstVar;
        private System.Windows.Forms.RadioButton radioButtonRelHumidity1;
        private System.Windows.Forms.RadioButton radioButtonSpecHumidity1;
        private System.Windows.Forms.RadioButton radioButtonWetBulbTemp1;
        private System.Windows.Forms.RadioButton radioButtonDryBulbTemp1;
        private System.Windows.Forms.GroupBox groupBoxVar2;
        private System.Windows.Forms.TextBox textBoxSecondVar;
        private System.Windows.Forms.RadioButton radioButtonRelHumidity2;
        private System.Windows.Forms.RadioButton radioButtonSpecHumidity2;
        private System.Windows.Forms.RadioButton radioButtonWetBulbTemp2;
        private System.Windows.Forms.RadioButton radioButtonDryBulbTemp2;
        private System.Windows.Forms.Label labelAmbientPressure;
        private System.Windows.Forms.TextBox textBoxAmbPressure;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.Label labelSpecVolumeResult;
        private System.Windows.Forms.Label labelSpecHumidityResult;
        private System.Windows.Forms.Label labelRelHumidityResult;
        private System.Windows.Forms.Label labelEnthalpyResult;
        private System.Windows.Forms.Label labelAmbPressureResult;
        private System.Windows.Forms.Label labelWetBulbTempResult;
        private System.Windows.Forms.Label labelDryBulbTempResult;
        private System.Windows.Forms.TextBox textBoxAmbPressureResult;
        private System.Windows.Forms.TextBox textBoxWetBulbTempResult;
        private System.Windows.Forms.TextBox textBoxSpecHumidityResult;
        private System.Windows.Forms.TextBox textBoxRelHumidityResult;
        private System.Windows.Forms.TextBox textBoxEnthalpyResult;
        private System.Windows.Forms.TextBox textBoxSpecVolumeResult;
        private System.Windows.Forms.TextBox textBoxDryBulbTempResult;
    }
}

