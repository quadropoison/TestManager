using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ThreadState = System.Threading.ThreadState;

namespace TestManager
{
    public partial class MainWindowForm : Form
    {
        public static string ExceptionText;
        public static int length_error_counter;
        public static int out_of_range_counter;
        public static int overflow_error_counter;
        public static int unknown_error_counter;
        public static int test_run_counter = 0;        

        private Thread AppThread { get; set; }
        private Stopwatch ActualRunningTimeOfTestRun { get; set; }
        private Stopwatch OneFullRotationTimer { get; set; }
        private int ExecutionTime { get; set; }
        private int Repetitions { get; set; }
        private bool IsAppStopping { get; set; }
        private int RotationsPerCycle { get; set; }
        private bool IsChildAppRunning { get; set; }        
        private float TimeSpentToFullRotationInSeconds { get; set; }
        private float AngularVelocity { get; set; }

        public MainWindowForm()
        {            
            InitializeComponent();            
            ////AllocConsole();           
        }

        private void mainWindowForm_Load(object sender, EventArgs e)
        {
            length_error_counter = 0;
            out_of_range_counter = 0;
            overflow_error_counter = 0;
            unknown_error_counter = 0;

            this.executionTimeTextBox.Text = "Execution time for a run (ms)";
            this.repetitionsNumberTextBox.Text = "Number of repetitions";

            this.fpsOverTimeGraphChart.Palette = ChartColorPalette.Chocolate;
            this.rotationsPerTestRunGraphChart.Palette = ChartColorPalette.Chocolate;
            this.testRunDurationGraphChart.Palette = ChartColorPalette.Chocolate;
            this.angularVelocityOverTimeGraphChart.Palette = ChartColorPalette.Chocolate;            

            this.fpsOverTimeGraphChart.Series.Clear();
            this.fpsOverTimeGraphChart.Series.Add("FPS over Time");
            this.fpsOverTimeGraphChart.Series["FPS over Time"].ChartType = SeriesChartType.FastLine;

            this.rotationsPerTestRunGraphChart.Series.Clear();            
            this.rotationsPerTestRunGraphChart.Series.Add("Full Rotations per Test Run");                                  
            this.rotationsPerTestRunGraphChart.Series[$"Full Rotations per Test Run"].ChartType = SeriesChartType.Column;            

            this.testRunDurationGraphChart.Series.Clear();
            this.testRunDurationGraphChart.Series.Add("Test Run Duration (s)");
            this.testRunDurationGraphChart.Series["Test Run Duration (s)"].ChartType = SeriesChartType.Column;

            this.angularVelocityOverTimeGraphChart.Series.Clear();
            this.angularVelocityOverTimeGraphChart.Series.Add("Angular Velocity over Time (degrees)");
            this.angularVelocityOverTimeGraphChart.Series["Angular Velocity over Time (degrees)"].ChartType = SeriesChartType.FastLine;
            this.angularVelocityOverTimeGraphChart.ChartAreas[0].AxisY.IsReversed = true;
            this.angularVelocityOverTimeGraphChart.ChartAreas[0].AxisY.Minimum = 0;
            this.angularVelocityOverTimeGraphChart.ChartAreas[0].AxisY.Maximum = 620;

            ActualRunningTimeOfTestRun = new Stopwatch();
            OneFullRotationTimer = new Stopwatch();

            AppThread = new Thread(() => { });
            AppThread.Start();
            AppThread.IsBackground = true;
        }                

        public void Run(int executionTime)
        {                        
            if (IsChildAppRunning == true)
                return;

            int repetitions = Repetitions;
            if (repetitions < 0 || repetitions == 0)
            {
                return;
            }

            while (repetitions > 0)
            {
                if(IsAppStopping == true)
                    break;

                try
                {
                    testRunExecutionTimer.Enabled = true;
                    RotationsPerCycle = 0;
                    IsChildAppRunning = true;
                    test_run_counter++;
                    testRunCounterDynamicLabel.Text = $"{test_run_counter}";
                    rotationsCounterDynamicLabel.Text = $"{ExternalFunctionsImporter.exposeFullRotationsPerCycle()}";
                    StartExecution(executionTime);
                }
                catch
                {
                    var innerAppExceptionText = ExternalFunctionsImporter.exposeException();
                    Debug.WriteLine(Marshal.PtrToStringAnsi(innerAppExceptionText));
                    string errorText = Marshal.PtrToStringAnsi(innerAppExceptionText);
                    if (errorText == "error - length_error")
                        length_error_counter++;
                    else if (errorText == "error - out_of_range")
                        out_of_range_counter++;
                    else if (errorText == "error - overflow_error")
                        overflow_error_counter++;
                    else
                    {
                        unknown_error_counter++;
                        throw;
                    }

                    ExternalFunctionsImporter.destroyApp();
                }

                StopExecution();
                rotationsPerTestRunGraphChart.Series["Full Rotations per Test Run"].Points.Add(ExternalFunctionsImporter.exposeFullRotationsPerCycle());
                testRunDurationGraphChart.Series["Test Run Duration (s)"].Points.Add((float)ActualRunningTimeOfTestRun.ElapsedMilliseconds / 1000);
                testRunExecutionTimer.Enabled = false;
                IsChildAppRunning = false;
                repetitions--;
            }

            IsAppStopping = false;
        }

        private void StartExecution(int executionTime)
        {
            ActualRunningTimeOfTestRun.Reset();
            ActualRunningTimeOfTestRun.Start();
            OneFullRotationTimer.Reset();
            OneFullRotationTimer.Start();
            AppThread.Join(ExternalFunctionsImporter.main(executionTime));
        }

        private void TestRunExecutionTimer_Tick(object sender, EventArgs e)
        {
            UpdateCounters();

            float elapsedTime = (float) OneFullRotationTimer.ElapsedMilliseconds;
            if (elapsedTime > 0)
            {
                TimeSpentToFullRotationInSeconds = elapsedTime / 1000;
                AngularVelocity = 360 / TimeSpentToFullRotationInSeconds;
                angularVelocityOverTimeGraphChart.Series["Angular Velocity over Time (degrees)"].Points.Add(Math.Round(AngularVelocity, 2));
            }
            
            fpsOverTimeGraphChart.Series["FPS over Time"].Points.Add(ShowFps());
        }

        private void UpdateCounters()
        {
            timerDynamicLabel.Text = $"{ActualRunningTimeOfTestRun.ElapsedMilliseconds / 1000}"; 
            fpsCounterDynamicLabel.Text = $"{Math.Round(ShowFps(), 2)}";
            deltaTimeCounterDynamicLabel.Text = $"{Math.Round(ShowDeltaTime(), 2)}";
            lengthErrorDynamicLabel.Text = $"{length_error_counter}";
            outOfRangeDynamicLabel.Text = $"{out_of_range_counter}";
            overflowErrorDynamicLabel.Text = $"{overflow_error_counter}";
            unknownErrorDynamicLabel.Text = $"{unknown_error_counter}";
            
            if (RotationsPerCycle < ExternalFunctionsImporter.exposeFullRotationsPerCycle())
            {
                try
                {
                    RotationsPerCycle++;
                    TimeSpentToFullRotationInSeconds = (float)OneFullRotationTimer.ElapsedMilliseconds / 1000;
                    AngularVelocity = 360 / TimeSpentToFullRotationInSeconds;
                    angularVelocityDynamicLabel.Text = $"{Math.Round(AngularVelocity, 2)}";
                    timeForFullRotationDynamicLabel.Text = $"{0}";
                    timeForFullRotationDynamicLabel.Text = $"{Math.Round(TimeSpentToFullRotationInSeconds, 2)}";

                    OneFullRotationTimer.Restart();
                }
                catch
                {                    
                    throw;
                }                
            }

            rotationsCounterDynamicLabel.Text = $"{ExternalFunctionsImporter.exposeFullRotationsPerCycle()}";

            totalCrashesDynamicLabel.Text =
                $"{length_error_counter + out_of_range_counter + overflow_error_counter + unknown_error_counter}";            
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            try
            {
                ExecutionTime = int.Parse(executionTimeTextBox.Text);

                try
                {
                    Repetitions = int.Parse(repetitionsNumberTextBox.Text);
                }
                catch
                {
                    ShowReminderMessage("Please set repetitions before the run", MessageBoxButtons.OK);
                    return;
                }                
            }
            catch
            {

                ShowReminderMessage("Please set execution time before the run", MessageBoxButtons.OK);
                return;                
            }

            Run(ExecutionTime);
        }

        private static DialogResult ShowReminderMessage(string message, MessageBoxButtons buttons)
        {
            string mes = message;                
            const string caption = "Reminder";
            var result = MessageBox.Show(message, caption,
                buttons,
                MessageBoxIcon.Exclamation);
            return result;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {            
            testRunExecutionTimer.Enabled = false;
            if (AppThread.ThreadState == ThreadState.Stopped || AppThread.ThreadState == ThreadState.Running)
            {
                IsAppStopping = true;
                StopExecution();
            }                    
        }

        private void StopExecution()
        {
            UpdateCounters();
            ActualRunningTimeOfTestRun.Stop();
            ExternalFunctionsImporter.setAppRunningStatusToFalse();
            AppThread.Interrupt();
        }

        private void executionTimeTextBox_Click(object sender, EventArgs e)
        {
            this.executionTimeTextBox.SelectAll();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var result = ShowReminderMessage("Are you sure you want to quit? All progress will be lost", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ExternalFunctionsImporter.forceExit();
            }            
        }

        private void repetitionsNumberTextBox_Click(object sender, EventArgs e)
        {
            this.repetitionsNumberTextBox.SelectAll();
        }

        public static float ShowFps()
        {
            return ExternalFunctionsImporter.exposeFps();
        }

        public static float ShowDeltaTime()
        {
            return ExternalFunctionsImporter.exposeDeltaTime();
        }

    }
}
