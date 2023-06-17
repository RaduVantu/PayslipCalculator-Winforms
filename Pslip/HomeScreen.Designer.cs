
namespace Pslip
{
    partial class HomeScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HoursTbox = new System.Windows.Forms.TextBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.SetRatesBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OverHoursTbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SickDaysTbox = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pensionLbl = new System.Windows.Forms.Label();
            this.netLbl = new System.Windows.Forms.Label();
            this.niLbl = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.grossLbl = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payslip Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "No. of hours worked";
            // 
            // HoursTbox
            // 
            this.HoursTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursTbox.Location = new System.Drawing.Point(152, 140);
            this.HoursTbox.Name = "HoursTbox";
            this.HoursTbox.Size = new System.Drawing.Size(100, 35);
            this.HoursTbox.TabIndex = 1;
            this.HoursTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.CalculateBtn.Location = new System.Drawing.Point(164, 427);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(200, 40);
            this.CalculateBtn.TabIndex = 4;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // SetRatesBtn
            // 
            this.SetRatesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetRatesBtn.ForeColor = System.Drawing.Color.MediumBlue;
            this.SetRatesBtn.Location = new System.Drawing.Point(48, 525);
            this.SetRatesBtn.Name = "SetRatesBtn";
            this.SetRatesBtn.Size = new System.Drawing.Size(150, 40);
            this.SetRatesBtn.TabIndex = 6;
            this.SetRatesBtn.Text = "Set Rates";
            this.SetRatesBtn.UseVisualStyleBackColor = true;
            this.SetRatesBtn.Click += new System.EventHandler(this.SetRatesBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "No. of overtime hours";
            // 
            // OverHoursTbox
            // 
            this.OverHoursTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverHoursTbox.Location = new System.Drawing.Point(152, 246);
            this.OverHoursTbox.Name = "OverHoursTbox";
            this.OverHoursTbox.Size = new System.Drawing.Size(100, 35);
            this.OverHoursTbox.TabIndex = 2;
            this.OverHoursTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sick leave days (if any)";
            // 
            // SickDaysTbox
            // 
            this.SickDaysTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SickDaysTbox.Location = new System.Drawing.Point(152, 352);
            this.SickDaysTbox.Name = "SickDaysTbox";
            this.SickDaysTbox.Size = new System.Drawing.Size(100, 35);
            this.SickDaysTbox.TabIndex = 3;
            this.SickDaysTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.ExitBtn.Location = new System.Drawing.Point(214, 525);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(150, 40);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(415, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Gross Salary:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tax:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(415, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "N.I.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(415, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Net Pay:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(415, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Pension:";
            // 
            // pensionLbl
            // 
            this.pensionLbl.AutoSize = true;
            this.pensionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pensionLbl.Location = new System.Drawing.Point(518, 284);
            this.pensionLbl.Name = "pensionLbl";
            this.pensionLbl.Size = new System.Drawing.Size(0, 25);
            this.pensionLbl.TabIndex = 24;
            // 
            // netLbl
            // 
            this.netLbl.AutoSize = true;
            this.netLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netLbl.Location = new System.Drawing.Point(532, 339);
            this.netLbl.Name = "netLbl";
            this.netLbl.Size = new System.Drawing.Size(0, 29);
            this.netLbl.TabIndex = 23;
            // 
            // niLbl
            // 
            this.niLbl.AutoSize = true;
            this.niLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niLbl.Location = new System.Drawing.Point(473, 229);
            this.niLbl.Name = "niLbl";
            this.niLbl.Size = new System.Drawing.Size(0, 25);
            this.niLbl.TabIndex = 22;
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLbl.Location = new System.Drawing.Point(477, 174);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(0, 25);
            this.taxLbl.TabIndex = 21;
            // 
            // grossLbl
            // 
            this.grossLbl.AutoSize = true;
            this.grossLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossLbl.Location = new System.Drawing.Point(565, 119);
            this.grossLbl.Name = "grossLbl";
            this.grossLbl.Size = new System.Drawing.Size(0, 25);
            this.grossLbl.TabIndex = 20;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearBtn.Location = new System.Drawing.Point(48, 427);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(81, 40);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(775, 623);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.pensionLbl);
            this.Controls.Add(this.netLbl);
            this.Controls.Add(this.niLbl);
            this.Controls.Add(this.taxLbl);
            this.Controls.Add(this.grossLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SickDaysTbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OverHoursTbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SetRatesBtn);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.HoursTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HomeScreen";
            this.Text = "Payslip Calculator";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HoursTbox;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Button SetRatesBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OverHoursTbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SickDaysTbox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label pensionLbl;
        private System.Windows.Forms.Label netLbl;
        private System.Windows.Forms.Label niLbl;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.Label grossLbl;
        private System.Windows.Forms.Button ClearBtn;
    }
}

