namespace Завдання_1
{
    partial class frmGraphics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtZnach = new System.Windows.Forms.TextBox();
            this.cbGraphics = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btCount = new System.Windows.Forms.Button();
            this.chkFunc2 = new System.Windows.Forms.CheckBox();
            this.chkFunc1 = new System.Windows.Forms.CheckBox();
            this.chkCos2 = new System.Windows.Forms.CheckBox();
            this.chkCos = new System.Windows.Forms.CheckBox();
            this.chkSin = new System.Windows.Forms.CheckBox();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStep);
            this.groupBox1.Controls.Add(this.txtMax);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(598, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Початкові дані";
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(182, 111);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(100, 26);
            this.txtStep.TabIndex = 5;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(182, 70);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 26);
            this.txtMax.TabIndex = 4;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(182, 32);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 26);
            this.txtMin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введіть крок:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введіть Xmax:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть Xmin:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtZnach);
            this.groupBox2.Controls.Add(this.cbGraphics);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(924, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 617);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Значення графіку";
            // 
            // txtZnach
            // 
            this.txtZnach.Location = new System.Drawing.Point(6, 182);
            this.txtZnach.Multiline = true;
            this.txtZnach.Name = "txtZnach";
            this.txtZnach.Size = new System.Drawing.Size(332, 435);
            this.txtZnach.TabIndex = 2;
            // 
            // cbGraphics
            // 
            this.cbGraphics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGraphics.FormattingEnabled = true;
            this.cbGraphics.Location = new System.Drawing.Point(0, 115);
            this.cbGraphics.Name = "cbGraphics";
            this.cbGraphics.Size = new System.Drawing.Size(332, 28);
            this.cbGraphics.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(-5, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 100);
            this.label4.TabIndex = 0;
            this.label4.Text = "Виберіть функцію, значення якої потрібно показати:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btExit);
            this.groupBox3.Controls.Add(this.btClear);
            this.groupBox3.Controls.Add(this.btCount);
            this.groupBox3.Controls.Add(this.chkFunc2);
            this.groupBox3.Controls.Add(this.chkFunc1);
            this.groupBox3.Controls.Add(this.chkCos2);
            this.groupBox3.Controls.Add(this.chkCos);
            this.groupBox3.Controls.Add(this.chkSin);
            this.groupBox3.Location = new System.Drawing.Point(598, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 435);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Побудовані графіки:";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(41, 384);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(257, 47);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Вихід";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(41, 331);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(257, 47);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "Очистити графіки";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btCount
            // 
            this.btCount.Location = new System.Drawing.Point(41, 278);
            this.btCount.Name = "btCount";
            this.btCount.Size = new System.Drawing.Size(257, 47);
            this.btCount.TabIndex = 5;
            this.btCount.Text = "Розрахунок";
            this.btCount.UseVisualStyleBackColor = true;
            this.btCount.Click += new System.EventHandler(this.btCount_Click);
            // 
            // chkFunc2
            // 
            this.chkFunc2.Location = new System.Drawing.Point(11, 206);
            this.chkFunc2.Name = "chkFunc2";
            this.chkFunc2.Size = new System.Drawing.Size(277, 57);
            this.chkFunc2.TabIndex = 4;
            this.chkFunc2.Text = "Побудувати графік 4+x+x*2";
            this.chkFunc2.UseVisualStyleBackColor = true;
            // 
            // chkFunc1
            // 
            this.chkFunc1.Location = new System.Drawing.Point(11, 153);
            this.chkFunc1.Name = "chkFunc1";
            this.chkFunc1.Size = new System.Drawing.Size(299, 57);
            this.chkFunc1.TabIndex = 3;
            this.chkFunc1.Text = "Побудувати графік кв.корень(x)";
            this.chkFunc1.UseVisualStyleBackColor = true;
            // 
            // chkCos2
            // 
            this.chkCos2.AutoSize = true;
            this.chkCos2.Location = new System.Drawing.Point(11, 123);
            this.chkCos2.Name = "chkCos2";
            this.chkCos2.Size = new System.Drawing.Size(262, 24);
            this.chkCos2.TabIndex = 2;
            this.chkCos2.Text = "Побудувати графік Cos(x) + x*2";
            this.chkCos2.UseVisualStyleBackColor = true;
            // 
            // chkCos
            // 
            this.chkCos.AutoSize = true;
            this.chkCos.Location = new System.Drawing.Point(12, 74);
            this.chkCos.Name = "chkCos";
            this.chkCos.Size = new System.Drawing.Size(220, 24);
            this.chkCos.TabIndex = 1;
            this.chkCos.Text = "Побудувати графік cos(x)";
            this.chkCos.UseVisualStyleBackColor = true;
            // 
            // chkSin
            // 
            this.chkSin.AutoSize = true;
            this.chkSin.Location = new System.Drawing.Point(12, 35);
            this.chkSin.Name = "chkSin";
            this.chkSin.Size = new System.Drawing.Size(215, 24);
            this.chkSin.TabIndex = 0;
            this.chkSin.Text = "Побудувати графік sin(x)";
            this.chkSin.UseVisualStyleBackColor = true;
            // 
            // chartGraph
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGraph.Legends.Add(legend2);
            this.chartGraph.Location = new System.Drawing.Point(12, 12);
            this.chartGraph.Name = "chartGraph";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Sin (x)";
            series6.YValuesPerPoint = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Cos (x)";
            series7.YValuesPerPoint = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "Cos (x) + 2*x";
            series8.YValuesPerPoint = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "кв.корінь (x)";
            series9.YValuesPerPoint = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "(x + 4)/( x ^ 2)";
            series10.YValuesPerPoint = 2;
            this.chartGraph.Series.Add(series6);
            this.chartGraph.Series.Add(series7);
            this.chartGraph.Series.Add(series8);
            this.chartGraph.Series.Add(series9);
            this.chartGraph.Series.Add(series10);
            this.chartGraph.Size = new System.Drawing.Size(580, 606);
            this.chartGraph.TabIndex = 3;
            this.chartGraph.Text = "chart1";
            // 
            // frmGraphics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1276, 630);
            this.Controls.Add(this.chartGraph);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmGraphics";
            this.Text = "Графіки";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGraphics_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtZnach;
        private System.Windows.Forms.ComboBox cbGraphics;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCount;
        private System.Windows.Forms.CheckBox chkFunc2;
        private System.Windows.Forms.CheckBox chkFunc1;
        private System.Windows.Forms.CheckBox chkCos2;
        private System.Windows.Forms.CheckBox chkCos;
        private System.Windows.Forms.CheckBox chkSin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
    }
}

