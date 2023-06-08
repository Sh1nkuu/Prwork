namespace Завдання_2
{
    partial class frmDiagrams
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCreateMasGist = new System.Windows.Forms.Button();
            this.dgvMasGist = new System.Windows.Forms.DataGridView();
            this.txtMinYear = new System.Windows.Forms.TextBox();
            this.txtMasGist = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btCreateMasRound = new System.Windows.Forms.Button();
            this.dgvMasRound = new System.Windows.Forms.DataGridView();
            this.txtMasRound = new System.Windows.Forms.TextBox();
            this.txtMinAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartDiagrams = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btCreateGist = new System.Windows.Forms.Button();
            this.btCreateRound = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasGist)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagrams)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCreateMasGist);
            this.groupBox1.Controls.Add(this.dgvMasGist);
            this.groupBox1.Controls.Add(this.txtMinYear);
            this.groupBox1.Controls.Add(this.txtMasGist);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(624, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные для гистограммы";
            // 
            // btCreateMasGist
            // 
            this.btCreateMasGist.Location = new System.Drawing.Point(334, 58);
            this.btCreateMasGist.Name = "btCreateMasGist";
            this.btCreateMasGist.Size = new System.Drawing.Size(304, 53);
            this.btCreateMasGist.TabIndex = 5;
            this.btCreateMasGist.Text = "Сгенерировать пустой массив";
            this.btCreateMasGist.UseVisualStyleBackColor = true;
            this.btCreateMasGist.Click += new System.EventHandler(this.btCreateMasGist_Click);
            // 
            // dgvMasGist
            // 
            this.dgvMasGist.AllowUserToOrderColumns = true;
            this.dgvMasGist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasGist.Location = new System.Drawing.Point(6, 147);
            this.dgvMasGist.Name = "dgvMasGist";
            this.dgvMasGist.RowHeadersWidth = 62;
            this.dgvMasGist.RowTemplate.Height = 28;
            this.dgvMasGist.Size = new System.Drawing.Size(632, 125);
            this.dgvMasGist.TabIndex = 4;
            // 
            // txtMinYear
            // 
            this.txtMinYear.Location = new System.Drawing.Point(218, 42);
            this.txtMinYear.Name = "txtMinYear";
            this.txtMinYear.Size = new System.Drawing.Size(112, 30);
            this.txtMinYear.TabIndex = 3;
            // 
            // txtMasGist
            // 
            this.txtMasGist.Location = new System.Drawing.Point(218, 91);
            this.txtMasGist.Name = "txtMasGist";
            this.txtMasGist.Size = new System.Drawing.Size(112, 30);
            this.txtMasGist.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите количество лет:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите начальный год:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btCreateMasRound);
            this.groupBox2.Controls.Add(this.dgvMasRound);
            this.groupBox2.Controls.Add(this.txtMasRound);
            this.groupBox2.Controls.Add(this.txtMinAge);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(624, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 278);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные для круговой диаграммы";
            // 
            // btCreateMasRound
            // 
            this.btCreateMasRound.Location = new System.Drawing.Point(334, 57);
            this.btCreateMasRound.Name = "btCreateMasRound";
            this.btCreateMasRound.Size = new System.Drawing.Size(304, 53);
            this.btCreateMasRound.TabIndex = 5;
            this.btCreateMasRound.Text = "Сгенерировать пустой массив";
            this.btCreateMasRound.UseVisualStyleBackColor = true;
            this.btCreateMasRound.Click += new System.EventHandler(this.btCreateMasRound_Click);
            // 
            // dgvMasRound
            // 
            this.dgvMasRound.AllowUserToOrderColumns = true;
            this.dgvMasRound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasRound.Location = new System.Drawing.Point(6, 147);
            this.dgvMasRound.Name = "dgvMasRound";
            this.dgvMasRound.RowHeadersWidth = 62;
            this.dgvMasRound.RowTemplate.Height = 28;
            this.dgvMasRound.Size = new System.Drawing.Size(632, 125);
            this.dgvMasRound.TabIndex = 4;
            // 
            // txtMasRound
            // 
            this.txtMasRound.Location = new System.Drawing.Point(218, 49);
            this.txtMasRound.Name = "txtMasRound";
            this.txtMasRound.Size = new System.Drawing.Size(112, 30);
            this.txtMasRound.TabIndex = 3;
            // 
            // txtMinAge
            // 
            this.txtMinAge.Location = new System.Drawing.Point(218, 98);
            this.txtMinAge.Name = "txtMinAge";
            this.txtMinAge.Size = new System.Drawing.Size(112, 30);
            this.txtMinAge.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 58);
            this.label3.TabIndex = 1;
            this.label3.Text = "Введите минимальный возраст:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 67);
            this.label4.TabIndex = 0;
            this.label4.Text = "Введите количество возрастных категорий:";
            // 
            // chartDiagrams
            // 
            this.chartDiagrams.BackColor = System.Drawing.Color.PeachPuff;
            this.chartDiagrams.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.chartDiagrams.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            chartArea7.Name = "ChartArea1";
            chartArea8.Name = "ChartArea2";
            this.chartDiagrams.ChartAreas.Add(chartArea7);
            this.chartDiagrams.ChartAreas.Add(chartArea8);
            legend7.Name = "Legend1";
            legend8.Name = "Legend2";
            legend8.Position.Auto = false;
            legend8.Position.Height = 19.26229F;
            legend8.Position.Width = 29F;
            legend8.Position.X = 70F;
            legend8.Position.Y = 52F;
            legend8.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            legend8.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.chartDiagrams.Legends.Add(legend7);
            this.chartDiagrams.Legends.Add(legend8);
            this.chartDiagrams.Location = new System.Drawing.Point(3, 10);
            this.chartDiagrams.Name = "chartDiagrams";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Количество участников";
            series8.ChartArea = "ChartArea2";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.Legend = "Legend2";
            series8.Name = "Sector";
            this.chartDiagrams.Series.Add(series7);
            this.chartDiagrams.Series.Add(series8);
            this.chartDiagrams.Size = new System.Drawing.Size(615, 562);
            this.chartDiagrams.TabIndex = 7;
            this.chartDiagrams.Text = "chart1";
            // 
            // btCreateGist
            // 
            this.btCreateGist.Location = new System.Drawing.Point(3, 591);
            this.btCreateGist.Name = "btCreateGist";
            this.btCreateGist.Size = new System.Drawing.Size(291, 38);
            this.btCreateGist.TabIndex = 8;
            this.btCreateGist.Text = "Построить гистограмму";
            this.btCreateGist.UseVisualStyleBackColor = true;
            this.btCreateGist.Click += new System.EventHandler(this.btCreateGist_Click);
            // 
            // btCreateRound
            // 
            this.btCreateRound.Location = new System.Drawing.Point(299, 591);
            this.btCreateRound.Name = "btCreateRound";
            this.btCreateRound.Size = new System.Drawing.Size(356, 38);
            this.btCreateRound.TabIndex = 9;
            this.btCreateRound.Text = "Построить секторную диаграмму";
            this.btCreateRound.UseVisualStyleBackColor = true;
            this.btCreateRound.Click += new System.EventHandler(this.btCreateRound_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(940, 591);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(237, 38);
            this.btExit.TabIndex = 10;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmDiagrams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 650);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCreateRound);
            this.Controls.Add(this.btCreateGist);
            this.Controls.Add(this.chartDiagrams);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmDiagrams";
            this.Text = "Диаграммы";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasGist)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagrams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCreateMasGist;
        private System.Windows.Forms.DataGridView dgvMasGist;
        private System.Windows.Forms.TextBox txtMinYear;
        private System.Windows.Forms.TextBox txtMasGist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btCreateMasRound;
        private System.Windows.Forms.DataGridView dgvMasRound;
        private System.Windows.Forms.TextBox txtMasRound;
        private System.Windows.Forms.TextBox txtMinAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagrams;
        private System.Windows.Forms.Button btCreateGist;
        private System.Windows.Forms.Button btCreateRound;
        private System.Windows.Forms.Button btExit;
    }
}

