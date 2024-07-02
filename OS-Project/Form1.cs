using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Text;

namespace OS_Project
{
    public partial class Form1 : Form
    {
        private List<Process> processes = new List<Process>();
        private List<Process> scheduledProcesses = new List<Process>();
        private double avgTurnAroundTime = 0;
        private double avgWaitingTime = 0;
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private bool ValidateInputs(int n, string[] processIds, string[] arrivalTimes, string[] burstTimes)
        {
            return processIds.Length == n && arrivalTimes.Length == n && burstTimes.Length == n;
        }

        private void ClearForm()
        {
            dataGridView1.DataSource = null;
            AvgTAT.Text = "0";
            AvgWT.Text = "0";
            ganttChartPanel.Controls.Clear(); // Clear gantt chart panel controls
        }
        private void DrawGanttChart()
        {
            if (processes.Count == 0)
            {
                MessageBox.Show("No processes to display in Gantt chart.", "No Processes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ganttChartPanel.FlowDirection = FlowDirection.LeftToRight;
            ganttChartPanel.WrapContents = false;

            // Calculate total burst time of all processes
            int totalBurstTime = processes.Sum(p => p.BurstTime);

            // Create a bitmap large enough to contain the entire Gantt chart
            int chartWidth = (int)Math.Max(totalBurstTime * (ganttChartPanel.Width / (double)totalBurstTime), ganttChartPanel.Width);
            Bitmap bmp = new Bitmap(chartWidth, ganttChartPanel.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                int currentX = 0;
                int processHeight = ganttChartPanel.Height / 2;

                foreach (var process in processes.OrderBy(p => p.CompletionTime - p.BurstTime)) // Order by start time
                {
                    int processWidth = (process.BurstTime * ganttChartPanel.Width) / totalBurstTime;

                    // Ensure minimum width for visibility
                    if (processWidth < 50) processWidth = 50;

                    g.FillRectangle(new SolidBrush(Color.FromArgb(63, 81, 181)), currentX, 0, processWidth, processHeight);
                    g.DrawRectangle(Pens.Black, currentX, 0, processWidth, processHeight);
                    g.DrawString("P" + process.ProcessID, this.Font, Brushes.White, currentX + (processWidth / 2) - 10, 10);

                    g.DrawString(process.CompletionTime.ToString(), this.Font, Brushes.Black, currentX + processWidth - 10, processHeight + 10);
                    currentX += processWidth;
                }
            }

            // Assign the bitmap to the panel's background
            ganttChartPanel.BackgroundImage = bmp;

            // Set the minimum size of the panel to enable scrolling
            ganttChartPanel.AutoScrollMinSize = new Size(chartWidth, ganttChartPanel.Height);

            // Enable horizontal scrolling explicitly
            ganttChartPanel.HorizontalScroll.Enabled = true;

            // Ensure auto-scroll is enabled
            ganttChartPanel.AutoScroll = true;
        }





        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            int radius = 20;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Height - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);
        }


        private void CalculateFCFS()
        {
            processes = processes.OrderBy(p => p.ArrivalTime).ToList();
            int currentTime = 0;
            scheduledProcesses.Clear();

            foreach (var process in processes)
            {
                // Process arrives and waits if necessary
                if (currentTime < process.ArrivalTime)
                {
                    currentTime = process.ArrivalTime;
                }

                // Execute the process
                process.CompletionTime = currentTime + process.BurstTime;
                process.TurnAroundTime = process.CompletionTime - process.ArrivalTime;
                process.WaitingTime = process.TurnAroundTime - process.BurstTime;

                // Update current time
                currentTime = process.CompletionTime;

                // Add the completed process to scheduled list
                scheduledProcesses.Add(process);
            }
        }


        private void TestSampleData_Click_1(object sender, EventArgs e)
        {
            GenerateSampleData();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {

            ClearForm();
            int n;
            if (!int.TryParse(NoOfProcesses.Text, out n) || n <= 0)
            {
                MessageBox.Show("Please enter a valid positive number of processes.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] processIds = ProcessIDs.Text.Split(',');
            string[] arrivalTimes = ArrivalTime.Text.Split(',');
            string[] burstTimes = BurstTime.Text.Split(',');

            if (!ValidateInputs(n, processIds, arrivalTimes, burstTimes))
            {
                MessageBox.Show("The number of input values does not match the specified number of processes.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            processes.Clear();

            try
            {
                for (int i = 0; i < n; i++)
                {
                    processes.Add(new Process
                    {
                        ProcessID = int.Parse(processIds[i]),
                        ArrivalTime = int.Parse(arrivalTimes[i]),
                        BurstTime = int.Parse(burstTimes[i]),
                        RemainingTime = int.Parse(burstTimes[i]) // Initialize remaining time
                    });
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure all input values are integers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CalculateFCFS();
            avgTurnAroundTime = scheduledProcesses.Average(p => p.TurnAroundTime);
            avgWaitingTime = scheduledProcesses.Average(p => p.WaitingTime);

            scheduledProcesses = scheduledProcesses.OrderBy(p => p.ProcessID).ToList();

            // Update DataGridView
            dataGridView1.DataSource = scheduledProcesses;
            AvgTAT.Text = avgTurnAroundTime.ToString("F2");
            AvgWT.Text = avgWaitingTime.ToString("F2");

            // Debug messages
            if (scheduledProcesses.Count > 0)
            {
                MessageBox.Show($"Processes scheduled: {scheduledProcesses.Count}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DrawGanttChart();
            }
            else
            {
                MessageBox.Show("No processes to display in Gantt chart.", "No Processes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void GenerateSampleData()
        {
            Random random = new Random();
            int numProcesses = random.Next(3, 5);

            StringBuilder processIds = new StringBuilder();
            StringBuilder arrivalTimes = new StringBuilder();
            StringBuilder burstTimes = new StringBuilder();

            for (int i = 0; i < numProcesses; i++)
            {
                int processId = i + 1;
                int arrivalTime = random.Next(0, 10);
                int burstTime = random.Next(1, 10);

                processIds.Append(processId);
                arrivalTimes.Append(arrivalTime);
                burstTimes.Append(burstTime);

                if (i < numProcesses - 1)
                {
                    processIds.Append(",");
                    arrivalTimes.Append(",");
                    burstTimes.Append(",");
                }
            }

            NoOfProcesses.Text = numProcesses.ToString();
            ProcessIDs.Text = processIds.ToString();
            ArrivalTime.Text = arrivalTimes.ToString();
            BurstTime.Text = burstTimes.ToString();

            MessageBox.Show("Sample data generated successfully.");
        }

        private void ganttChartPanel_Paint(object sender, PaintEventArgs e)
        { }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class Process
    {
        public int ProcessID { get; set; }
        public int ArrivalTime { get; set; }
        public int BurstTime { get; set; }
        public int RemainingTime { get; set; }
        public int CompletionTime { get; set; }
        public int TurnAroundTime { get; set; }
        public int WaitingTime { get; set; }
    }
}

