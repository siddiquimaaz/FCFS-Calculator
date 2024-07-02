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
            NoOfProcesses = new TextBox();
            ProcessIDs = new TextBox();
            ArrivalTime = new TextBox();
            BurstTime = new TextBox();
            TestSampleData = new Button();
            AvgTAT = new Label();
            AvgWT = new Label();
            Calculate = new Button();
            Close = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(592, 23);
            label1.Name = "label1";
            label1.Size = new Size(285, 50);
            label1.TabIndex = 0;
            label1.Text = "FCFS-Calcuator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 278);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 309);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 338);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(143, 370);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // ganttChartPanel
            // 
            ganttChartPanel.Location = new Point(26, 110);
            ganttChartPanel.Name = "ganttChartPanel";
            ganttChartPanel.Size = new Size(1501, 67);
            ganttChartPanel.TabIndex = 5;
            ganttChartPanel.WrapContents = false;
            ganttChartPanel.Paint += ganttChartPanel_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(633, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(894, 440);
            dataGridView1.TabIndex = 6;
            // 
            // NoOfProcesses
            // 
            NoOfProcesses.Location = new Point(227, 265);
            NoOfProcesses.Name = "NoOfProcesses";
            NoOfProcesses.Size = new Size(125, 27);
            NoOfProcesses.TabIndex = 7;
            // 
            // ProcessIDs
            // 
            ProcessIDs.Location = new Point(227, 298);
            ProcessIDs.Name = "ProcessIDs";
            ProcessIDs.Size = new Size(125, 27);
            ProcessIDs.TabIndex = 8;
            // 
            // ArrivalTime
            // 
            ArrivalTime.Location = new Point(227, 331);
            ArrivalTime.Name = "ArrivalTime";
            ArrivalTime.Size = new Size(125, 27);
            ArrivalTime.TabIndex = 9;
            // 
            // BurstTime
            // 
            BurstTime.Location = new Point(227, 367);
            BurstTime.Name = "BurstTime";
            BurstTime.Size = new Size(125, 27);
            BurstTime.TabIndex = 10;
            // 
            // TestSampleData
            // 
            TestSampleData.Location = new Point(330, 414);
            TestSampleData.Name = "TestSampleData";
            TestSampleData.Size = new Size(94, 29);
            TestSampleData.TabIndex = 12;
            TestSampleData.Text = "button2";
            TestSampleData.UseVisualStyleBackColor = true;
            TestSampleData.Click += TestSampleData_Click_1;
            // 
            // AvgTAT
            // 
            AvgTAT.AutoSize = true;
            AvgTAT.Location = new Point(143, 496);
            AvgTAT.Name = "AvgTAT";
            AvgTAT.Size = new Size(50, 20);
            AvgTAT.TabIndex = 13;
            AvgTAT.Text = "label6";
            // 
            // AvgWT
            // 
            AvgWT.AutoSize = true;
            AvgWT.Location = new Point(143, 533);
            AvgWT.Name = "AvgWT";
            AvgWT.Size = new Size(50, 20);
            AvgWT.TabIndex = 14;
            AvgWT.Text = "label7";
            // 
            // Calculate
            // 
            Calculate.Location = new Point(227, 414);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(94, 29);
            Calculate.TabIndex = 15;
            Calculate.Text = "button1";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // Close
            // 
            Close.Location = new Point(12, 12);
            Close.Name = "Close";
            Close.Size = new Size(94, 29);
            Close.TabIndex = 16;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1565, 729);
            Controls.Add(Close);
            Controls.Add(Calculate);
            Controls.Add(AvgWT);
            Controls.Add(AvgTAT);
            Controls.Add(TestSampleData);
            Controls.Add(BurstTime);
            Controls.Add(ArrivalTime);
            Controls.Add(ProcessIDs);
            Controls.Add(NoOfProcesses);
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
        private TextBox NoOfProcesses;
        private TextBox ProcessIDs;
        private TextBox ArrivalTime;
        private TextBox BurstTime;
        private Button TestSampleData;
        private Label AvgTAT;
        private Label AvgWT;
        private Button Calculate;
        private Button Close;
    }
}
