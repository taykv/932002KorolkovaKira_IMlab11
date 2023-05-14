
namespace Lab11
{
    partial class Form1
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.prob1 = new System.Windows.Forms.NumericUpDown();
			this.prob2 = new System.Windows.Forms.NumericUpDown();
			this.prob3 = new System.Windows.Forms.NumericUpDown();
			this.prob4 = new System.Windows.Forms.NumericUpDown();
			this.prob5 = new System.Windows.Forms.TextBox();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label6 = new System.Windows.Forms.Label();
			this.number = new System.Windows.Forms.NumericUpDown();
			this.lable7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.chi = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.state = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.prob1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prob2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prob3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prob4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Prob 1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Prob 2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Prob 3";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(37, 190);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Prob 4";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(37, 230);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Prob 5";
			// 
			// prob1
			// 
			this.prob1.DecimalPlaces = 2;
			this.prob1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.prob1.Location = new System.Drawing.Point(113, 70);
			this.prob1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.prob1.Name = "prob1";
			this.prob1.Size = new System.Drawing.Size(120, 23);
			this.prob1.TabIndex = 5;
			this.prob1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			// 
			// prob2
			// 
			this.prob2.DecimalPlaces = 2;
			this.prob2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.prob2.Location = new System.Drawing.Point(113, 110);
			this.prob2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.prob2.Name = "prob2";
			this.prob2.Size = new System.Drawing.Size(120, 23);
			this.prob2.TabIndex = 6;
			this.prob2.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
			// 
			// prob3
			// 
			this.prob3.DecimalPlaces = 2;
			this.prob3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.prob3.Location = new System.Drawing.Point(113, 150);
			this.prob3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.prob3.Name = "prob3";
			this.prob3.Size = new System.Drawing.Size(120, 23);
			this.prob3.TabIndex = 7;
			this.prob3.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
			// 
			// prob4
			// 
			this.prob4.DecimalPlaces = 2;
			this.prob4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.prob4.Location = new System.Drawing.Point(113, 190);
			this.prob4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.prob4.Name = "prob4";
			this.prob4.Size = new System.Drawing.Size(120, 23);
			this.prob4.TabIndex = 8;
			this.prob4.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			// 
			// prob5
			// 
			this.prob5.Location = new System.Drawing.Point(113, 230);
			this.prob5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.prob5.Name = "prob5";
			this.prob5.Size = new System.Drawing.Size(120, 23);
			this.prob5.TabIndex = 9;
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(300, 14);
			this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(718, 428);
			this.chart1.TabIndex = 10;
			this.chart1.Text = "chart1";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(22, 345);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "Sample size";
			// 
			// number
			// 
			this.number.Location = new System.Drawing.Point(113, 343);
			this.number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.number.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.number.Name = "number";
			this.number.Size = new System.Drawing.Size(120, 23);
			this.number.TabIndex = 12;
			this.number.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// lable7
			// 
			this.lable7.AutoSize = true;
			this.lable7.Location = new System.Drawing.Point(307, 481);
			this.lable7.Name = "lable7";
			this.lable7.Size = new System.Drawing.Size(61, 17);
			this.lable7.TabIndex = 13;
			this.lable7.Text = "Average";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(307, 518);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 17);
			this.label8.TabIndex = 14;
			this.label8.Text = "Variance";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(307, 553);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(85, 17);
			this.label9.TabIndex = 15;
			this.label9.Text = "Chi-squared";
			// 
			// chi
			// 
			this.chi.Location = new System.Drawing.Point(399, 551);
			this.chi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chi.Name = "chi";
			this.chi.Size = new System.Drawing.Size(100, 23);
			this.chi.TabIndex = 18;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(65, 402);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(131, 40);
			this.button1.TabIndex = 19;
			this.button1.Text = "Start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// state
			// 
			this.state.AutoSize = true;
			this.state.Location = new System.Drawing.Point(521, 553);
			this.state.Name = "state";
			this.state.Size = new System.Drawing.Size(41, 17);
			this.state.TabIndex = 20;
			this.state.Text = "State";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(443, 481);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 17);
			this.label7.TabIndex = 23;
			this.label7.Text = "Error,%";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(443, 518);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 17);
			this.label10.TabIndex = 24;
			this.label10.Text = "Error,%";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1045, 599);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.state);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.chi);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lable7);
			this.Controls.Add(this.number);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.prob5);
			this.Controls.Add(this.prob4);
			this.Controls.Add(this.prob3);
			this.Controls.Add(this.prob2);
			this.Controls.Add(this.prob1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.prob1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prob2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prob3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prob4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown prob1;
        private System.Windows.Forms.NumericUpDown prob2;
        private System.Windows.Forms.NumericUpDown prob3;
        private System.Windows.Forms.NumericUpDown prob4;
        private System.Windows.Forms.TextBox prob5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.Label lable7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox chi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
    }
}

