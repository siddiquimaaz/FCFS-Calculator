### Process Scheduling Application

## Overview

Welcome to the Process Scheduling Application! This project is a Windows Forms application designed to simulate and visualize process scheduling algorithms, focusing on the First-Come, First-Served (FCFS) algorithm. The application allows users to input process details, calculates scheduling metrics, and displays a Gantt chart for visual representation.

## Features

- **Process Input:** Add process details including Process ID, Arrival Time, and Burst Time.
- **FCFS Scheduling:** Calculate and visualize the FCFS scheduling algorithm.
- **Gantt Chart:** Display a Gantt chart for the scheduled processes.
- **Average Metrics:** Calculate and display average Turnaround Time and Waiting Time.
- **Sample Data Generation:** Generate sample process data for testing purposes.

## Installation

1. Clone the repository:
   ```sh
   git clone https://github.com/siddiquimaaz/ProcessSchedulingApp.git
2. Clone the repository:
   ```sh
     ProcessSchedulingApp.sln
3. Build the solution to restore dependencies and compile the application.
## Usage
1. Input Process Details:
 - Enter the number of processes in the NoOfProcesses text box.
 - Enter the Process IDs, Arrival Times, and Burst Times in the respective text boxes, separated by commas.
   
2. Generate Sample Data:
- Click the Generate Sample Data button to auto-fill the text boxes with sample process data.

3. Calculate FCFS:
- Click the Calculate button to compute the FCFS scheduling and display the results.

4. View Results:
- The DataGridView will display the scheduled processes with their respective metrics.
- The Gantt chart panel will visualize the process execution order.

5. Clear Form:
- Click the Clear button to reset the input fields and clear the displayed results.
- Example
- Here's an example of input and output:

# Input:
- NoOfProcesses: 3
- ProcessIDs: 1,2,3
- ArrivalTime: 0,2,4
- BurstTime: 5,3,1

# Output:

- Scheduled Processes: P1, P2, P3
- Average Turnaround Time: 5.67
- Average Waiting Time: 2.33
- Gantt Chart: Visual representation of the process scheduling
- Contributing
- Contributions are welcome! Please fork the repository and submit a pull request for any enhancements or bug fixes.

License
- None

 Contact
- For any questions or suggestions, please contact siddiquimaaz88@gmail.com.
