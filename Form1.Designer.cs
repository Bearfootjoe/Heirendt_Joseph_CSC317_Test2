
namespace Heirendt_Joseph_CSC317_Test2
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
            this.lbl_StartingTemp = new System.Windows.Forms.Label();
            this.numberBoxTempValue = new System.Windows.Forms.NumericUpDown();
            this.comboUnits = new System.Windows.Forms.ComboBox();
            this.lbl_ConversionValue1 = new System.Windows.Forms.Label();
            this.lbl_ConversionValue2 = new System.Windows.Forms.Label();
            this.imageTempGauge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxTempValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTempGauge)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_StartingTemp
            // 
            this.lbl_StartingTemp.AutoSize = true;
            this.lbl_StartingTemp.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartingTemp.Location = new System.Drawing.Point(3, 25);
            this.lbl_StartingTemp.Name = "lbl_StartingTemp";
            this.lbl_StartingTemp.Size = new System.Drawing.Size(218, 18);
            this.lbl_StartingTemp.TabIndex = 0;
            this.lbl_StartingTemp.Text = "Starting Temperature:";
            // 
            // numberBoxTempValue
            // 
            this.numberBoxTempValue.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxTempValue.Location = new System.Drawing.Point(227, 23);
            this.numberBoxTempValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numberBoxTempValue.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numberBoxTempValue.Name = "numberBoxTempValue";
            this.numberBoxTempValue.Size = new System.Drawing.Size(120, 26);
            this.numberBoxTempValue.TabIndex = 1;
            this.numberBoxTempValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboUnits
            // 
            this.comboUnits.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUnits.FormattingEnabled = true;
            this.comboUnits.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celsius",
            "Kelvin"});
            this.comboUnits.Location = new System.Drawing.Point(352, 22);
            this.comboUnits.Name = "comboUnits";
            this.comboUnits.Size = new System.Drawing.Size(120, 26);
            this.comboUnits.TabIndex = 2;
            this.comboUnits.SelectedIndexChanged += new System.EventHandler(this.comboUnits_SelectedIndexChanged);
            // 
            // lbl_ConversionValue1
            // 
            this.lbl_ConversionValue1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ConversionValue1.BackColor = System.Drawing.Color.White;
            this.lbl_ConversionValue1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConversionValue1.Location = new System.Drawing.Point(224, 80);
            this.lbl_ConversionValue1.Name = "lbl_ConversionValue1";
            this.lbl_ConversionValue1.Size = new System.Drawing.Size(248, 18);
            this.lbl_ConversionValue1.TabIndex = 3;
            this.lbl_ConversionValue1.Text = "Value1";
            this.lbl_ConversionValue1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ConversionValue2
            // 
            this.lbl_ConversionValue2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ConversionValue2.BackColor = System.Drawing.Color.White;
            this.lbl_ConversionValue2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConversionValue2.Location = new System.Drawing.Point(224, 122);
            this.lbl_ConversionValue2.Name = "lbl_ConversionValue2";
            this.lbl_ConversionValue2.Size = new System.Drawing.Size(248, 18);
            this.lbl_ConversionValue2.TabIndex = 4;
            this.lbl_ConversionValue2.Text = "Value2";
            this.lbl_ConversionValue2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageTempGauge
            // 
            this.imageTempGauge.Location = new System.Drawing.Point(42, 60);
            this.imageTempGauge.Name = "imageTempGauge";
            this.imageTempGauge.Size = new System.Drawing.Size(121, 102);
            this.imageTempGauge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageTempGauge.TabIndex = 5;
            this.imageTempGauge.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 175);
            this.Controls.Add(this.imageTempGauge);
            this.Controls.Add(this.lbl_ConversionValue2);
            this.Controls.Add(this.lbl_ConversionValue1);
            this.Controls.Add(this.comboUnits);
            this.Controls.Add(this.numberBoxTempValue);
            this.Controls.Add(this.lbl_StartingTemp);
            this.Name = "Form1";
            this.Text = "Temperature Converter";
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxTempValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTempGauge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_StartingTemp;
        public System.Windows.Forms.NumericUpDown numberBoxTempValue;
        private System.Windows.Forms.ComboBox comboUnits;
        public System.Windows.Forms.Label lbl_ConversionValue1;
        public System.Windows.Forms.Label lbl_ConversionValue2;
        public System.Windows.Forms.PictureBox imageTempGauge;
    }
}

