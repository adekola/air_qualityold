namespace AirQualityApp
{
    partial class Home
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
            this.btnMeasure = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblCurrentDateTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUpTime = new System.Windows.Forms.Label();
            this.lblComputerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMeasure
            // 
            this.btnMeasure.Location = new System.Drawing.Point(97, 180);
            this.btnMeasure.Margin = new System.Windows.Forms.Padding(4);
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(132, 60);
            this.btnMeasure.TabIndex = 0;
            this.btnMeasure.Text = "Get Data";
            this.btnMeasure.UseVisualStyleBackColor = true;
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperature";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(183, 144);
            this.lblHumidity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(46, 17);
            this.lblHumidity.TabIndex = 2;
            this.lblHumidity.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Humidity ";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(183, 62);
            this.lblTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(46, 17);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.Text = "label4";
            // 
            // lblCurrentDateTime
            // 
            this.lblCurrentDateTime.AutoSize = true;
            this.lblCurrentDateTime.Location = new System.Drawing.Point(384, 62);
            this.lblCurrentDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentDateTime.Name = "lblCurrentDateTime";
            this.lblCurrentDateTime.Size = new System.Drawing.Size(17, 17);
            this.lblCurrentDateTime.TabIndex = 8;
            this.lblCurrentDateTime.Text = "{}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Humidity ";
            // 
            // lblUpTime
            // 
            this.lblUpTime.AutoSize = true;
            this.lblUpTime.Location = new System.Drawing.Point(384, 117);
            this.lblUpTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpTime.Name = "lblUpTime";
            this.lblUpTime.Size = new System.Drawing.Size(17, 17);
            this.lblUpTime.TabIndex = 6;
            this.lblUpTime.Text = "{}";
            // 
            // lblComputerName
            // 
            this.lblComputerName.Location = new System.Drawing.Point(384, 23);
            this.lblComputerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.Size = new System.Drawing.Size(87, 17);
            this.lblComputerName.TabIndex = 5;
            this.lblComputerName.Text = "{}";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 260);
            this.Controls.Add(this.lblCurrentDateTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUpTime);
            this.Controls.Add(this.lblComputerName);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMeasure);
            this.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Air Quality Monitoring";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMeasure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblCurrentDateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUpTime;
        private System.Windows.Forms.Label lblComputerName;
    }
}

