namespace OS_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ganttChartPanel = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            ProcessIDs = new TextBox();
            ArrivalTime = new TextBox();
            BurstTime = new TextBox();
            TestSampleData = new Button();
            AvgTAT = new Label();
            AvgWT = new Label();
            Calculate = new Button();
            NoOFProccess = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NoOFProccess).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(592, 23);
            label1.Name = "label1";
            label1.Size = new Size(285, 50);
            label1.TabIndex = 0;
            label1.Text = "FCFS-Calcuator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
            label2.Location = new Point(128, 299);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "No. Of Processes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.White;
            label3.Location = new Point(128, 338);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Process IDs";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.White;
            label4.Location = new Point(128, 375);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 3;
            label4.Text = "Time Of Arrival";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.ForeColor = Color.White;
            label5.Location = new Point(128, 411);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 4;
            label5.Text = "Burst Time";
            // 
            // ganttChartPanel
            // 
            ganttChartPanel.BackColor = Color.Transparent;
            ganttChartPanel.Location = new Point(633, 110);
            ganttChartPanel.Name = "ganttChartPanel";
            ganttChartPanel.Size = new Size(894, 67);
            ganttChartPanel.TabIndex = 5;
            ganttChartPanel.WrapContents = false;
            ganttChartPanel.Paint += ganttChartPanel_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(633, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(894, 440);
            dataGridView1.TabIndex = 6;
            // 
            // ProcessIDs
            // 
            ProcessIDs.BackColor = Color.Black;
            ProcessIDs.ForeColor = Color.White;
            ProcessIDs.Location = new Point(296, 335);
            ProcessIDs.Name = "ProcessIDs";
            ProcessIDs.Size = new Size(125, 27);
            ProcessIDs.TabIndex = 8;
            // 
            // ArrivalTime
            // 
            ArrivalTime.BackColor = Color.Black;
            ArrivalTime.ForeColor = Color.White;
            ArrivalTime.Location = new Point(296, 368);
            ArrivalTime.Name = "ArrivalTime";
            ArrivalTime.Size = new Size(125, 27);
            ArrivalTime.TabIndex = 9;
            // 
            // BurstTime
            // 
            BurstTime.BackColor = Color.Black;
            BurstTime.ForeColor = Color.White;
            BurstTime.Location = new Point(296, 404);
            BurstTime.Name = "BurstTime";
            BurstTime.Size = new Size(125, 27);
            BurstTime.TabIndex = 10;
            // 
            // TestSampleData
            // 
            TestSampleData.BackColor = Color.Black;
            TestSampleData.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            TestSampleData.ForeColor = Color.White;
            TestSampleData.Location = new Point(403, 472);
            TestSampleData.Name = "TestSampleData";
            TestSampleData.Size = new Size(94, 29);
            TestSampleData.TabIndex = 12;
            TestSampleData.Text = "Test";
            TestSampleData.UseVisualStyleBackColor = false;
            TestSampleData.Click += TestSampleData_Click_1;
            // 
            // AvgTAT
            // 
            AvgTAT.AutoSize = true;
            AvgTAT.BackColor = Color.Black;
            AvgTAT.ForeColor = Color.White;
            AvgTAT.Location = new Point(286, 556);
            AvgTAT.Name = "AvgTAT";
            AvgTAT.Size = new Size(0, 20);
            AvgTAT.TabIndex = 13;
            // 
            // AvgWT
            // 
            AvgWT.AutoSize = true;
            AvgWT.BackColor = Color.Black;
            AvgWT.ForeColor = Color.White;
            AvgWT.Location = new Point(286, 593);
            AvgWT.Name = "AvgWT";
            AvgWT.Size = new Size(0, 20);
            AvgWT.TabIndex = 14;
            // 
            // Calculate
            // 
            Calculate.BackColor = Color.Black;
            Calculate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Calculate.ForeColor = Color.White;
            Calculate.Location = new Point(286, 472);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(94, 29);
            Calculate.TabIndex = 15;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = false;
            Calculate.Click += Calculate_Click;
            // 
            // NoOFProccess
            // 
            NoOFProccess.BackColor = Color.Black;
            NoOFProccess.ForeColor = Color.White;
            NoOFProccess.Location = new Point(296, 292);
            NoOFProccess.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NoOFProccess.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NoOFProccess.Name = "NoOFProccess";
            NoOFProccess.Size = new Size(125, 27);
            NoOFProccess.TabIndex = 17;
            NoOFProccess.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.ForeColor = Color.White;
            label6.Location = new Point(128, 556);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 18;
            label6.Text = "Average TAT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.ForeColor = Color.White;
            label7.Location = new Point(128, 593);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 19;
            label7.Text = "Average WT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(1524, 9);
            label8.Name = "label8";
            label8.Size = new Size(29, 31);
            label8.TabIndex = 20;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1565, 729);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(NoOFProccess);
            Controls.Add(Calculate);
            Controls.Add(AvgWT);
            Controls.Add(AvgTAT);
            Controls.Add(TestSampleData);
            Controls.Add(BurstTime);
            Controls.Add(ArrivalTime);
            Controls.Add(ProcessIDs);
            Controls.Add(dataGridView1);
            Controls.Add(ganttChartPanel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NoOFProccess).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private FlowLayoutPanel ganttChartPanel;
        private DataGridView dataGridView1;
        private TextBox ProcessIDs;
        private TextBox ArrivalTime;
        private TextBox BurstTime;
        private Button TestSampleData;
        private Label AvgTAT;
        private Label AvgWT;
        private Button Calculate;
        private NumericUpDown NoOFProccess;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
