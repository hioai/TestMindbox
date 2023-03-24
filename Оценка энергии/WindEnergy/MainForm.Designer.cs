namespace WindEnergy
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rTBTest = new System.Windows.Forms.RichTextBox();
            this.tBDiameter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBTime = new System.Windows.Forms.TextBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.rBDays = new System.Windows.Forms.RadioButton();
            this.rBHours = new System.Windows.Forms.RadioButton();
            this.tBLongitude = new System.Windows.Forms.TextBox();
            this.tBLatitude = new System.Windows.Forms.TextBox();
            this.tBInverter = new System.Windows.Forms.TextBox();
            this.tBEfficiency = new System.Windows.Forms.TextBox();
            this.tBWPUF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTBTest
            // 
            this.rTBTest.Location = new System.Drawing.Point(575, 137);
            this.rTBTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rTBTest.Name = "rTBTest";
            this.rTBTest.Size = new System.Drawing.Size(213, 302);
            this.rTBTest.TabIndex = 12;
            this.rTBTest.Text = "";
            // 
            // tBDiameter
            // 
            this.tBDiameter.Location = new System.Drawing.Point(163, 29);
            this.tBDiameter.Name = "tBDiameter";
            this.tBDiameter.Size = new System.Drawing.Size(100, 26);
            this.tBDiameter.TabIndex = 13;
            this.tBDiameter.Text = "6,4";
            this.tBDiameter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBDiameter_KeyDown);
            this.tBDiameter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBDiameter_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBTime);
            this.groupBox1.Controls.Add(this.monthCalendar);
            this.groupBox1.Controls.Add(this.rBDays);
            this.groupBox1.Controls.Add(this.rBHours);
            this.groupBox1.Controls.Add(this.tBLongitude);
            this.groupBox1.Controls.Add(this.tBLatitude);
            this.groupBox1.Controls.Add(this.tBInverter);
            this.groupBox1.Controls.Add(this.tBEfficiency);
            this.groupBox1.Controls.Add(this.tBWPUF);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tBDiameter);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 427);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // tBTime
            // 
            this.tBTime.Location = new System.Drawing.Point(290, 92);
            this.tBTime.Name = "tBTime";
            this.tBTime.Size = new System.Drawing.Size(100, 26);
            this.tBTime.TabIndex = 35;
            this.tBTime.Text = "24";
            this.tBTime.Visible = false;
            this.tBTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBTime_KeyDown);
            this.tBTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBTime_KeyPress);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(290, 88);
            this.monthCalendar.MaxSelectionCount = 6;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 34;
            // 
            // rBDays
            // 
            this.rBDays.AutoSize = true;
            this.rBDays.Checked = true;
            this.rBDays.Location = new System.Drawing.Point(290, 22);
            this.rBDays.Name = "rBDays";
            this.rBDays.Size = new System.Drawing.Size(64, 24);
            this.rBDays.TabIndex = 33;
            this.rBDays.TabStop = true;
            this.rBDays.Text = "Дни";
            this.rBDays.UseVisualStyleBackColor = true;
            this.rBDays.CheckedChanged += new System.EventHandler(this.rBDays_CheckedChanged);
            // 
            // rBHours
            // 
            this.rBHours.AutoSize = true;
            this.rBHours.Location = new System.Drawing.Point(290, 52);
            this.rBHours.Name = "rBHours";
            this.rBHours.Size = new System.Drawing.Size(74, 24);
            this.rBHours.TabIndex = 32;
            this.rBHours.Text = "Часы";
            this.rBHours.UseVisualStyleBackColor = true;
            this.rBHours.CheckedChanged += new System.EventHandler(this.rBHours_CheckedChanged);
            // 
            // tBLongitude
            // 
            this.tBLongitude.Location = new System.Drawing.Point(163, 192);
            this.tBLongitude.Name = "tBLongitude";
            this.tBLongitude.Size = new System.Drawing.Size(100, 26);
            this.tBLongitude.TabIndex = 30;
            this.tBLongitude.Text = "37.0488601";
            // 
            // tBLatitude
            // 
            this.tBLatitude.Location = new System.Drawing.Point(163, 160);
            this.tBLatitude.Name = "tBLatitude";
            this.tBLatitude.Size = new System.Drawing.Size(100, 26);
            this.tBLatitude.TabIndex = 29;
            this.tBLatitude.Text = "55.6971328";
            // 
            // tBInverter
            // 
            this.tBInverter.Location = new System.Drawing.Point(163, 125);
            this.tBInverter.Name = "tBInverter";
            this.tBInverter.Size = new System.Drawing.Size(100, 26);
            this.tBInverter.TabIndex = 28;
            this.tBInverter.Text = "0,9";
            this.tBInverter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBInvertor_KeyDown);
            this.tBInverter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBInvertor_KeyPress);
            // 
            // tBEfficiency
            // 
            this.tBEfficiency.Location = new System.Drawing.Point(163, 93);
            this.tBEfficiency.Name = "tBEfficiency";
            this.tBEfficiency.Size = new System.Drawing.Size(100, 26);
            this.tBEfficiency.TabIndex = 27;
            this.tBEfficiency.Text = "0,8";
            this.tBEfficiency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBEfficiency_KeyDown);
            this.tBEfficiency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBEfficiency_KeyPress);
            // 
            // tBWPUF
            // 
            this.tBWPUF.Location = new System.Drawing.Point(163, 61);
            this.tBWPUF.Name = "tBWPUF";
            this.tBWPUF.Size = new System.Drawing.Size(100, 26);
            this.tBWPUF.TabIndex = 26;
            this.tBWPUF.Text = "0,4";
            this.tBWPUF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBWPUF_KeyDown);
            this.tBWPUF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBWPUF_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "КПД инвертора";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Долгота";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "КИЭВ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "КПД ВЭУ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Диаметр винта";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(575, 35);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(118, 33);
            this.buttonCalculate.TabIndex = 15;
            this.buttonCalculate.Text = "Рассчитать";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rTBTest);
            this.Name = "MainForm";
            this.Text = "Определение энергии ВЭУ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBTest;
        private System.Windows.Forms.TextBox tBDiameter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBTime;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.RadioButton rBDays;
        private System.Windows.Forms.RadioButton rBHours;
        private System.Windows.Forms.TextBox tBLongitude;
        private System.Windows.Forms.TextBox tBLatitude;
        private System.Windows.Forms.TextBox tBInverter;
        private System.Windows.Forms.TextBox tBEfficiency;
        private System.Windows.Forms.TextBox tBWPUF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

