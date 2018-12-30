using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace TestManager
{
    partial class MainWindowForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.runButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.testRunExecutionTimer = new System.Windows.Forms.Timer(this.components);
            this.fpsCounterDynamicLabel = new System.Windows.Forms.Label();
            this.fpsOverTimeGraphChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fpsCounterStaticLabel = new System.Windows.Forms.Label();
            this.executionTimeTextBox = new System.Windows.Forms.TextBox();
            this.totalCrashesDynamicLabel = new System.Windows.Forms.Label();
            this.totalCrashesStaticLabel = new System.Windows.Forms.Label();
            this.lengthErrorDynamicLabel = new System.Windows.Forms.Label();
            this.lengthErrorStaticLabel = new System.Windows.Forms.Label();
            this.outOfRangeDynamicLabel = new System.Windows.Forms.Label();
            this.outOfRangeStaticLabel = new System.Windows.Forms.Label();
            this.overflowErrorDynamicLabel = new System.Windows.Forms.Label();
            this.overflowErrorStaticLabel = new System.Windows.Forms.Label();
            this.unknownErrorDynamicLabel = new System.Windows.Forms.Label();
            this.unknownErrorStaticLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rotationsCounterDynamicLabel = new System.Windows.Forms.Label();
            this.rotationsCounterStaticLabel = new System.Windows.Forms.Label();
            this.testRunCounterDynamicLabel = new System.Windows.Forms.Label();
            this.testRunCounterStaticLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.deltaTimeCounterDynamicLabel = new System.Windows.Forms.Label();
            this.deltaTimeCounterStaticLabel = new System.Windows.Forms.Label();
            this.repetitionsNumberTextBox = new System.Windows.Forms.TextBox();
            this.rotationsPerTestRunGraphChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerDynamicLabel = new System.Windows.Forms.Label();
            this.TimerStaticLabel = new System.Windows.Forms.Label();
            this.angularVelocityDynamicLabel = new System.Windows.Forms.Label();
            this.angularVelocityStaticLabel = new System.Windows.Forms.Label();
            this.timeForFullRotationDynamicLabel = new System.Windows.Forms.Label();
            this.timeForFullRotationStaticLabel = new System.Windows.Forms.Label();
            this.testRunDurationGraphChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.angularVelocityOverTimeGraphChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.fpsOverTimeGraphChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationsPerTestRunGraphChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testRunDurationGraphChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angularVelocityOverTimeGraphChart)).BeginInit();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(172, 12);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(72, 50);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(250, 12);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(72, 50);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // testRunExecutionTimer
            // 
            this.testRunExecutionTimer.Tick += new System.EventHandler(this.TestRunExecutionTimer_Tick);
            // 
            // fpsCounterDynamicLabel
            // 
            this.fpsCounterDynamicLabel.BackColor = System.Drawing.Color.Black;
            this.fpsCounterDynamicLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpsCounterDynamicLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fpsCounterDynamicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.fpsCounterDynamicLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.fpsCounterDynamicLabel.Location = new System.Drawing.Point(405, 39);
            this.fpsCounterDynamicLabel.Name = "fpsCounterDynamicLabel";
            this.fpsCounterDynamicLabel.Size = new System.Drawing.Size(75, 22);
            this.fpsCounterDynamicLabel.TabIndex = 3;
            this.fpsCounterDynamicLabel.Text = "0";
            this.fpsCounterDynamicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fpsOverTimeGraphChart
            // 
            chartArea1.Name = "ChartArea1";
            this.fpsOverTimeGraphChart.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.MaximumAutoSize = 20F;
            legend1.Name = "Legend1";
            legend1.TextWrapThreshold = 10;
            this.fpsOverTimeGraphChart.Legends.Add(legend1);
            this.fpsOverTimeGraphChart.Location = new System.Drawing.Point(173, 75);
            this.fpsOverTimeGraphChart.Name = "fpsOverTimeGraphChart";
            this.fpsOverTimeGraphChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.fpsOverTimeGraphChart.Series.Add(series1);
            this.fpsOverTimeGraphChart.Size = new System.Drawing.Size(550, 122);
            this.fpsOverTimeGraphChart.TabIndex = 5;
            this.fpsOverTimeGraphChart.Text = "fpsOverTimeGraphChart";
            // 
            // fpsCounterStaticLabel
            // 
            this.fpsCounterStaticLabel.BackColor = System.Drawing.Color.Green;
            this.fpsCounterStaticLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpsCounterStaticLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fpsCounterStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fpsCounterStaticLabel.ForeColor = System.Drawing.Color.Azure;
            this.fpsCounterStaticLabel.Location = new System.Drawing.Point(405, 11);
            this.fpsCounterStaticLabel.Name = "fpsCounterStaticLabel";
            this.fpsCounterStaticLabel.Size = new System.Drawing.Size(75, 22);
            this.fpsCounterStaticLabel.TabIndex = 6;
            this.fpsCounterStaticLabel.Text = "FPS";
            this.fpsCounterStaticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // executionTimeTextBox
            // 
            this.executionTimeTextBox.Location = new System.Drawing.Point(12, 12);
            this.executionTimeTextBox.Name = "executionTimeTextBox";
            this.executionTimeTextBox.Size = new System.Drawing.Size(154, 20);
            this.executionTimeTextBox.TabIndex = 7;
            this.executionTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.executionTimeTextBox.Click += new System.EventHandler(this.executionTimeTextBox_Click);
            // 
            // totalCrashesDynamicLabel
            // 
            this.totalCrashesDynamicLabel.BackColor = System.Drawing.Color.Black;
            this.totalCrashesDynamicLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCrashesDynamicLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalCrashesDynamicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.totalCrashesDynamicLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.totalCrashesDynamicLabel.Location = new System.Drawing.Point(117, 204);
            this.totalCrashesDynamicLabel.Name = "totalCrashesDynamicLabel";
            this.totalCrashesDynamicLabel.Size = new System.Drawing.Size(50, 35);
            this.totalCrashesDynamicLabel.TabIndex = 3;
            this.totalCrashesDynamicLabel.Text = "0";
            this.totalCrashesDynamicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCrashesStaticLabel
            // 
            this.totalCrashesStaticLabel.BackColor = System.Drawing.Color.Maroon;
            this.totalCrashesStaticLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCrashesStaticLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalCrashesStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.totalCrashesStaticLabel.ForeColor = System.Drawing.Color.Azure;
            this.totalCrashesStaticLabel.Location = new System.Drawing.Point(12, 204);
            this.totalCrashesStaticLabel.Name = "totalCrashesStaticLabel";
            this.totalCrashesStaticLabel.Size = new System.Drawing.Size(99, 35);
            this.totalCrashesStaticLabel.TabIndex = 6;
            this.totalCrashesStaticLabel.Text = "Total Crashes";
            this.totalCrashesStaticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lengthErrorDynamicLabel
            // 
            this.lengthErrorDynamicLabel.BackColor = System.Drawing.Color.Black;
            this.lengthErrorDynamicLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lengthErrorDynamicLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lengthErrorDynamicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lengthErrorDynamicLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.lengthErrorDynamicLabel.Location = new System.Drawing.Point(117, 248);
            this.lengthErrorDynamicLabel.Name = "lengthErrorDynamicLabel";
            this.lengthErrorDynamicLabel.Size = new System.Drawing.Size(50, 35);
            this.lengthErrorDynamicLabel.TabIndex = 3;
            this.lengthErrorDynamicLabel.Text = "0";
            this.lengthErrorDynamicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;            
            // 
            // lengthErrorStaticLabel
            // 
            this.lengthErrorStaticLabel.BackColor = System.Drawing.Color.Maroon;
            this.lengthErrorStaticLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lengthErrorStaticLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lengthErrorStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lengthErrorStaticLabel.ForeColor = System.Drawing.Color.Azure;
            this.lengthErrorStaticLabel.Location = new System.Drawing.Point(12, 248);
            this.lengthErrorStaticLabel.Name = "lengthErrorStaticLabel";
            this.lengthErrorStaticLabel.Size = new System.Drawing.Size(99, 35);
            this.lengthErrorStaticLabel.TabIndex = 6;
            this.lengthErrorStaticLabel.Text = "length error";
            this.lengthErrorStaticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;            
            // 
            // outOfRangeDynamicLabel
            // 
            this.outOfRangeDynamicLabel.BackColor = System.Drawing.Color.Black;
            this.outOfRangeDynamicLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outOfRangeDynamicLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outOfRangeDynamicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.outOfRangeDynamicLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.outOfRangeDynamicLabel.Location = new System.Drawing.Point(117, 292);
            this.outOfRangeDynamicLabel.Name = "outOfRangeDynamicLabel";
            this.outOfRangeDynamicLabel.Size = new System.Drawing.Size(50, 35);
            this.outOfRangeDynamicLabel.TabIndex = 3;
            this.outOfRangeDynamicLabel.Text = "0";
            this.outOfRangeDynamicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;            
            // 
            // outOfRangeStaticLabel
            // 
            this.outOfRangeStaticLabel.BackColor = System.Drawing.Color.Maroon;
            this.outOfRangeStaticLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outOfRangeStaticLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outOfRangeStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.outOfRangeStaticLabel.ForeColor = System.Drawing.Color.Azure;
            this.outOfRangeStaticLabel.Location = new System.Drawing.Point(12, 292);
            this.outOfRangeStaticLabel.Name = "outOfRangeStaticLabel";
            this.outOfRangeStaticLabel.Size = new System.Drawing.Size(99, 35);
            this.outOfRangeStaticLabel.TabIndex = 6;
            this.outOfRangeStaticLabel.Text = "out of range";
            this.outOfRangeStaticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;            
            // 
            // overflowErrorDynamicLabel
            // 
            this.overflowErrorDynamicLabel.BackColor = System.Drawing.Color.Black;
            this.overflowErrorDynamicLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.overflowErrorDynamicLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overflowErrorDynamicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.overflowErrorDynamicLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.overflowErrorDynamicLabel.Location = new System.Drawing.Point(117, 333);
            this.overflowErrorDynamicLabel.Name = "overflowErrorDynamicLabel";
            this.overflowErrorDynamicLabel.Size = new System.Drawing.Size(50, 35);
            this.overflowErrorDynamicLabel.TabIndex = 3;
            this.overflowErrorDynamicLabel.Text = "0";
            this.overflowErrorDynamicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // overflowErrorStaticLabel
            // 
            this.overflowErrorStaticLabel.BackColor = System.Drawing.Color.Maroon;
            this.overflowErrorStaticLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.overflowErrorStaticLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overflowErrorStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.overflowErrorStaticLabel.ForeColor = System.Drawing.Color.Azure;
            this.overflowErrorStaticLabel.Location = new System.Drawing.Point(12, 333);
            this.overflowErrorStaticLabel.Name = "overflowErrorStaticLabel";
            this.overflowErrorStaticLabel.Size = new System.Drawing.Size(99, 35);
            this.overflowErrorStaticLabel.TabIndex = 6;
            this.overflowErrorStaticLabel.Text = "overflow error";
            this.overflowErrorStaticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;            
            // 
            // unknownErrorDynamicLabel
            // 
            this.unknownErrorDynamicLabel.BackColor = System.Drawing.Color.Black;
            this.unknownErrorDynamicLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unknownErrorDynamicLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unknownErrorDynamicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.unknownErrorDynamicLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.unknownErrorDynamicLabel.Location = new System.Drawing.Point(117, 380);
            this.unknownErrorDynamicLabel.Name = "unknownErrorDynamicLabel";
            this.unknownErrorDynamicLabel.Size = new System.Drawing.Size(50, 35);
            this.unknownErrorDynamicLabel.TabIndex = 3;
            this.unknownErrorDynamicLabel.Text = "0";
            this.unknownErrorDynamicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unknownErrorStaticLabel
            // 
            this.unknownErrorStaticLabel.BackColor = System.Drawing.Color.Maroon;
            this.unknownErrorStaticLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unknownErrorStaticLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unknownErrorStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.unknownErrorStaticLabel.ForeColor = System.Drawing.Color.Azure;
            this.unknownErrorStaticLabel.Location = new System.Drawing.Point(12, 380);
            this.unknownErrorStaticLabel.Name = "unknownErrorStaticLabel";
            this.unknownErrorStaticLabel.Size = new System.Drawing.Size(99, 35);
            this.unknownErrorStaticLabel.TabIndex = 6;
            this.unknownErrorStaticLabel.Text = "unknown error";
            this.unknownErrorStaticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rotationsCounterDynamicLabel
            // 
            this.rotationsCounterDynamicLabel.BackColor = System.Drawing.Color.Black;
            this.rotationsCounterDynamicLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rotationsCounterDynamicLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rotationsCounterDynamicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rotationsCounterDynamicLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.rotationsCounterDynamicLabel.Location = new System.Drawing.Point(648, 39);
            this.rotationsCounterDynamicLabel.Name = "rotationsCounterDynamicLabel";
            this.rotationsCounterDynamicLabel.Size = new System.Drawing.Size(75, 22);
            this.rotationsCounterDynamicLabel.TabIndex = 3;
            this.rotationsCounterDynamicLabel.Text = "0";
            this.rotationsCounterDynamicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rotationsCounterStaticLabel
            // 
            this.rotationsCounterStaticLabel.BackColor = System.Drawing.Color.Green;
            this.rotationsCounterStaticLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rotationsCounterStaticLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rotationsCounterStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.rotationsCounterStaticLabel.ForeColor = System.Drawing.Color.Azure;
            this.rotationsCounterStaticLabel.Location = new System.Drawing.Point(648, 11);
            this.rotationsCounterStaticLabel.Name = "rotationsCounterStaticLabel";
            this.rotationsCounterStaticLabel.Size = new System.Drawing.Size(75, 22);
            this.rotationsCounterStaticLabel.TabIndex = 6;
            this.rotationsCounterStaticLabel.Text = "Rotations";
            this.rotationsCounterStaticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testRunCounterDynamicLabel
            // 
            this.testRunCounterDynamicLabel.BackColor = System.Drawing.Color.Black;
            this.testRunCounterDynamicLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testRunCounterDynamicLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testRunCounterDynamicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.testRunCounterDynamicLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.testRunCounterDynamicLabel.Location = new System.Drawing.Point(567, 39);
            this.testRunCounterDynamicLabel.Name = "testRunCounterDynamicLabel";
            this.testRunCounterDynamicLabel.Size = new System.Drawing.Size(75, 22);
            this.testRunCounterDynamicLabel.TabIndex = 3;
            this.testRunCounterDynamicLabel.Text = "0";
            this.testRunCounterDynamicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testRunCounterStaticLabel
            // 
            this.testRunCounterStaticLabel.BackColor = System.Drawing.Color.Green;
            this.testRunCounterStaticLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testRunCounterStaticLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testRunCounterStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.testRunCounterStaticLabel.ForeColor = System.Drawing.Color.Azure;
            this.testRunCounterStaticLabel.Location = new System.Drawing.Point(567, 11);
            this.testRunCounterStaticLabel.Name = "testRunCounterStaticLabel";
            this.testRunCounterStaticLabel.Size = new System.Drawing.Size(75, 22);
            this.testRunCounterStaticLabel.TabIndex = 6;
            this.testRunCounterStaticLabel.Text = "Test Run #";
            this.testRunCounterStaticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(327, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(72, 50);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // deltaTimeCounterDynamicLabel
            // 
            this.deltaTimeCounterDynamicLabel.BackColor = System.Drawing.Color.Black;
            this.deltaTimeCounterDynamicLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deltaTimeCounterDynamicLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deltaTimeCounterDynamicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.deltaTimeCounterDynamicLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.deltaTimeCounterDynamicLabel.Location = new System.Drawing.Point(486, 39);
            this.deltaTimeCounterDynamicLabel.Name = "deltaTimeCounterDynamicLabel";
            this.deltaTimeCounterDynamicLabel.Size = new System.Drawing.Size(75, 22);
            this.deltaTimeCounterDynamicLabel.TabIndex = 3;
            this.deltaTimeCounterDynamicLabel.Text = "0";
            this.deltaTimeCounterDynamicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deltaTimeCounterStaticLabel
            // 
            this.deltaTimeCounterStaticLabel.BackColor = System.Drawing.Color.Green;
            this.deltaTimeCounterStaticLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deltaTimeCounterStaticLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deltaTimeCounterStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.deltaTimeCounterStaticLabel.ForeColor = System.Drawing.Color.Azure;
            this.deltaTimeCounterStaticLabel.Location = new System.Drawing.Point(486, 11);
            this.deltaTimeCounterStaticLabel.Name = "deltaTimeCounterStaticLabel";
            this.deltaTimeCounterStaticLabel.Size = new System.Drawing.Size(75, 22);
            this.deltaTimeCounterStaticLabel.TabIndex = 6;
            this.deltaTimeCounterStaticLabel.Text = "Delta Time";
            this.deltaTimeCounterStaticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // repetitionsNumberTextBox
            // 
            this.repetitionsNumberTextBox.Location = new System.Drawing.Point(12, 41);
            this.repetitionsNumberTextBox.Name = "repetitionsNumberTextBox";
            this.repetitionsNumberTextBox.Size = new System.Drawing.Size(154, 20);
            this.repetitionsNumberTextBox.TabIndex = 7;
            this.repetitionsNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.repetitionsNumberTextBox.Click += new System.EventHandler(this.repetitionsNumberTextBox_Click);
            // 
            // rotationsPerTestRunGraphChart
            // 
            chartArea2.Name = "ChartArea1";
            this.rotationsPerTestRunGraphChart.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.MaximumAutoSize = 20F;
            legend2.Name = "Legend1";
            legend2.TextWrapThreshold = 10;
            this.rotationsPerTestRunGraphChart.Legends.Add(legend2);
            this.rotationsPerTestRunGraphChart.Location = new System.Drawing.Point(173, 333);
            this.rotationsPerTestRunGraphChart.Name = "rotationsPerTestRunGraphChart";
            this.rotationsPerTestRunGraphChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.rotationsPerTestRunGraphChart.Series.Add(series2);
            this.rotationsPerTestRunGraphChart.Size = new System.Drawing.Size(550, 122);
            this.rotationsPerTestRunGraphChart.TabIndex = 5;
            this.rotationsPerTestRunGraphChart.Text = "rotationsPerTestRunGraphChart";
            // 
            // timerDynamicLabel
            // 
            this.timerDynamicLabel.BackColor = System.Drawing.Color.Gray;
            this.timerDynamicLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timerDynamicLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timerDynamicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.timerDynamicLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.timerDynamicLabel.Location = new System.Drawing.Point(117, 75);
            this.timerDynamicLabel.Name = "timerDynamicLabel";
            this.timerDynamicLabel.Size = new System.Drawing.Size(50, 35);
            this.timerDynamicLabel.TabIndex = 3;
            this.timerDynamicLabel.Text = "0";
            this.timerDynamicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerStaticLabel
            // 
            this.TimerStaticLabel.BackColor = System.Drawing.Color.Gray;
            this.TimerStaticLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimerStaticLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimerStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TimerStaticLabel.ForeColor = System.Drawing.Color.Azure;
            this.TimerStaticLabel.Location = new System.Drawing.Point(12, 75);
            this.TimerStaticLabel.Name = "TimerStaticLabel";
            this.TimerStaticLabel.Size = new System.Drawing.Size(99, 35);
            this.TimerStaticLabel.TabIndex = 6;
            this.TimerStaticLabel.Text = "Test Execution Time (s)";
            this.TimerStaticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // angularVelocityDynamicLabel
            // 
            this.angularVelocityDynamicLabel.BackColor = System.Drawing.Color.Gray;
            this.angularVelocityDynamicLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.angularVelocityDynamicLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.angularVelocityDynamicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.angularVelocityDynamicLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.angularVelocityDynamicLabel.Location = new System.Drawing.Point(117, 119);
            this.angularVelocityDynamicLabel.Name = "angularVelocityDynamicLabel";
            this.angularVelocityDynamicLabel.Size = new System.Drawing.Size(50, 35);
            this.angularVelocityDynamicLabel.TabIndex = 3;
            this.angularVelocityDynamicLabel.Text = "0";
            this.angularVelocityDynamicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // angularVelocityStaticLabel
            // 
            this.angularVelocityStaticLabel.BackColor = System.Drawing.Color.Gray;
            this.angularVelocityStaticLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.angularVelocityStaticLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.angularVelocityStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.angularVelocityStaticLabel.ForeColor = System.Drawing.Color.Azure;
            this.angularVelocityStaticLabel.Location = new System.Drawing.Point(12, 119);
            this.angularVelocityStaticLabel.Name = "angularVelocityStaticLabel";
            this.angularVelocityStaticLabel.Size = new System.Drawing.Size(99, 35);
            this.angularVelocityStaticLabel.TabIndex = 6;
            this.angularVelocityStaticLabel.Text = "Angular Velocity (degrees per sec)";
            this.angularVelocityStaticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeForFullRotationDynamicLabel
            // 
            this.timeForFullRotationDynamicLabel.BackColor = System.Drawing.Color.Gray;
            this.timeForFullRotationDynamicLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeForFullRotationDynamicLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeForFullRotationDynamicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.timeForFullRotationDynamicLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.timeForFullRotationDynamicLabel.Location = new System.Drawing.Point(117, 163);
            this.timeForFullRotationDynamicLabel.Name = "timeForFullRotationDynamicLabel";
            this.timeForFullRotationDynamicLabel.Size = new System.Drawing.Size(50, 35);
            this.timeForFullRotationDynamicLabel.TabIndex = 3;
            this.timeForFullRotationDynamicLabel.Text = "0";
            this.timeForFullRotationDynamicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeForFullRotationStaticLabel
            // 
            this.timeForFullRotationStaticLabel.BackColor = System.Drawing.Color.Gray;
            this.timeForFullRotationStaticLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeForFullRotationStaticLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeForFullRotationStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.timeForFullRotationStaticLabel.ForeColor = System.Drawing.Color.Azure;
            this.timeForFullRotationStaticLabel.Location = new System.Drawing.Point(12, 163);
            this.timeForFullRotationStaticLabel.Name = "timeForFullRotationStaticLabel";
            this.timeForFullRotationStaticLabel.Size = new System.Drawing.Size(99, 35);
            this.timeForFullRotationStaticLabel.TabIndex = 6;
            this.timeForFullRotationStaticLabel.Text = "Time For Full Rotation (s)";
            this.timeForFullRotationStaticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testRunDurationGraphChart
            // 
            chartArea3.Name = "ChartArea1";
            this.testRunDurationGraphChart.ChartAreas.Add(chartArea3);
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.MaximumAutoSize = 20F;
            legend3.Name = "Legend1";
            legend3.TextWrapThreshold = 10;
            this.testRunDurationGraphChart.Legends.Add(legend3);
            this.testRunDurationGraphChart.Location = new System.Drawing.Point(172, 462);
            this.testRunDurationGraphChart.Name = "testRunDurationGraphChart";
            this.testRunDurationGraphChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.testRunDurationGraphChart.Series.Add(series3);
            this.testRunDurationGraphChart.Size = new System.Drawing.Size(550, 122);
            this.testRunDurationGraphChart.TabIndex = 5;
            this.testRunDurationGraphChart.Text = "Test Run Duration (s)";
            // 
            // angularVelocityOverTimeGraphChart
            // 
            chartArea4.Name = "ChartArea1";
            this.angularVelocityOverTimeGraphChart.ChartAreas.Add(chartArea4);
            legend4.Alignment = System.Drawing.StringAlignment.Center;
            legend4.MaximumAutoSize = 20F;
            legend4.Name = "Legend1";
            legend4.TextWrapThreshold = 10;
            this.angularVelocityOverTimeGraphChart.Legends.Add(legend4);
            this.angularVelocityOverTimeGraphChart.Location = new System.Drawing.Point(173, 204);
            this.angularVelocityOverTimeGraphChart.Name = "angularVelocityOverTimeGraphChart";
            this.angularVelocityOverTimeGraphChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.angularVelocityOverTimeGraphChart.Series.Add(series4);
            this.angularVelocityOverTimeGraphChart.Size = new System.Drawing.Size(550, 122);
            this.angularVelocityOverTimeGraphChart.TabIndex = 5;
            this.angularVelocityOverTimeGraphChart.Text = "angularVelocity";
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(729, 589);
            this.Controls.Add(this.repetitionsNumberTextBox);
            this.Controls.Add(this.executionTimeTextBox);
            this.Controls.Add(this.testRunCounterStaticLabel);
            this.Controls.Add(this.rotationsCounterStaticLabel);
            this.Controls.Add(this.unknownErrorStaticLabel);
            this.Controls.Add(this.testRunCounterDynamicLabel);
            this.Controls.Add(this.overflowErrorStaticLabel);
            this.Controls.Add(this.rotationsCounterDynamicLabel);
            this.Controls.Add(this.unknownErrorDynamicLabel);
            this.Controls.Add(this.outOfRangeStaticLabel);
            this.Controls.Add(this.overflowErrorDynamicLabel);
            this.Controls.Add(this.lengthErrorStaticLabel);
            this.Controls.Add(this.outOfRangeDynamicLabel);
            this.Controls.Add(this.timeForFullRotationStaticLabel);
            this.Controls.Add(this.angularVelocityStaticLabel);
            this.Controls.Add(this.TimerStaticLabel);
            this.Controls.Add(this.totalCrashesStaticLabel);
            this.Controls.Add(this.timeForFullRotationDynamicLabel);
            this.Controls.Add(this.lengthErrorDynamicLabel);
            this.Controls.Add(this.angularVelocityDynamicLabel);
            this.Controls.Add(this.deltaTimeCounterStaticLabel);
            this.Controls.Add(this.timerDynamicLabel);
            this.Controls.Add(this.fpsCounterStaticLabel);
            this.Controls.Add(this.totalCrashesDynamicLabel);
            this.Controls.Add(this.deltaTimeCounterDynamicLabel);
            this.Controls.Add(this.testRunDurationGraphChart);
            this.Controls.Add(this.angularVelocityOverTimeGraphChart);
            this.Controls.Add(this.rotationsPerTestRunGraphChart);
            this.Controls.Add(this.fpsOverTimeGraphChart);
            this.Controls.Add(this.fpsCounterDynamicLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.runButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainWindowForm";
            this.Text = "TestManager";
            this.Load += new System.EventHandler(this.mainWindowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fpsOverTimeGraphChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationsPerTestRunGraphChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testRunDurationGraphChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angularVelocityOverTimeGraphChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer testRunExecutionTimer;
        private System.Windows.Forms.Label fpsCounterDynamicLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart fpsOverTimeGraphChart;
        private System.Windows.Forms.Label fpsCounterStaticLabel;
        private System.Windows.Forms.TextBox executionTimeTextBox;
        private System.Windows.Forms.Label totalCrashesDynamicLabel;
        private System.Windows.Forms.Label totalCrashesStaticLabel;
        private System.Windows.Forms.Label lengthErrorDynamicLabel;
        private System.Windows.Forms.Label lengthErrorStaticLabel;
        private System.Windows.Forms.Label outOfRangeDynamicLabel;
        private System.Windows.Forms.Label outOfRangeStaticLabel;
        private System.Windows.Forms.Label overflowErrorDynamicLabel;
        private System.Windows.Forms.Label overflowErrorStaticLabel;
        private System.Windows.Forms.Label unknownErrorDynamicLabel;
        private System.Windows.Forms.Label unknownErrorStaticLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label rotationsCounterDynamicLabel;
        private System.Windows.Forms.Label rotationsCounterStaticLabel;
        private System.Windows.Forms.Label testRunCounterDynamicLabel;
        private System.Windows.Forms.Label testRunCounterStaticLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label deltaTimeCounterDynamicLabel;
        private System.Windows.Forms.Label deltaTimeCounterStaticLabel;
        private System.Windows.Forms.TextBox repetitionsNumberTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart rotationsPerTestRunGraphChart;
        private System.Windows.Forms.Label timerDynamicLabel;
        private System.Windows.Forms.Label TimerStaticLabel;
        private System.Windows.Forms.Label angularVelocityDynamicLabel;
        private System.Windows.Forms.Label angularVelocityStaticLabel;
        private System.Windows.Forms.Label timeForFullRotationDynamicLabel;
        private System.Windows.Forms.Label timeForFullRotationStaticLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart testRunDurationGraphChart;
        private Chart angularVelocityOverTimeGraphChart;
    }
}

