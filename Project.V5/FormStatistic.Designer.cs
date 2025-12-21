namespace Project.V5
{
    partial class FormStatistic
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            splitContainerStats_BTO = new SplitContainer();
            dataGridViewStats_BTO = new DataGridView();
            chartStats_BTO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)splitContainerStats_BTO).BeginInit();
            splitContainerStats_BTO.Panel1.SuspendLayout();
            splitContainerStats_BTO.Panel2.SuspendLayout();
            splitContainerStats_BTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStats_BTO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartStats_BTO).BeginInit();
            SuspendLayout();
            // 
            // splitContainerStats_BTO
            // 
            splitContainerStats_BTO.Dock = DockStyle.Fill;
            splitContainerStats_BTO.Location = new Point(0, 0);
            splitContainerStats_BTO.Margin = new Padding(4, 5, 4, 5);
            splitContainerStats_BTO.Name = "splitContainerStats_BTO";
            // 
            // splitContainerStats_BTO.Panel1
            // 
            splitContainerStats_BTO.Panel1.Controls.Add(dataGridViewStats_BTO);
            // 
            // splitContainerStats_BTO.Panel2
            // 
            splitContainerStats_BTO.Panel2.Controls.Add(chartStats_BTO);
            splitContainerStats_BTO.Size = new Size(1200, 769);
            splitContainerStats_BTO.SplitterDistance = 533;
            splitContainerStats_BTO.SplitterWidth = 5;
            splitContainerStats_BTO.TabIndex = 0;
            // 
            // dataGridViewStats_BTO
            // 
            dataGridViewStats_BTO.AllowUserToAddRows = false;
            dataGridViewStats_BTO.AllowUserToDeleteRows = false;
            dataGridViewStats_BTO.AllowUserToOrderColumns = true;
            dataGridViewStats_BTO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStats_BTO.Dock = DockStyle.Fill;
            dataGridViewStats_BTO.Location = new Point(0, 0);
            dataGridViewStats_BTO.Margin = new Padding(4, 5, 4, 5);
            dataGridViewStats_BTO.Name = "dataGridViewStats_BTO";
            dataGridViewStats_BTO.ReadOnly = true;
            dataGridViewStats_BTO.RowHeadersWidth = 51;
            dataGridViewStats_BTO.Size = new Size(533, 769);
            dataGridViewStats_BTO.TabIndex = 0;
            // 
            // chartStats_BTO
            // 
            chartArea2.Name = "ChartArea1";
            chartStats_BTO.ChartAreas.Add(chartArea2);
            chartStats_BTO.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartStats_BTO.Legends.Add(legend2);
            chartStats_BTO.Location = new Point(0, 0);
            chartStats_BTO.Margin = new Padding(4, 5, 4, 5);
            chartStats_BTO.Name = "chartStats_BTO";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Статистика";
            chartStats_BTO.Series.Add(series2);
            chartStats_BTO.Size = new Size(662, 769);
            chartStats_BTO.TabIndex = 0;
            chartStats_BTO.Text = "Статистика по мастерским";
            // 
            // FormStatistic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 769);
            Controls.Add(splitContainerStats_BTO);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormStatistic";
            Text = "Статистика — Авторемонтные мастерские";
            splitContainerStats_BTO.Panel1.ResumeLayout(false);
            splitContainerStats_BTO.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerStats_BTO).EndInit();
            splitContainerStats_BTO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStats_BTO).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartStats_BTO).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainerStats_BTO;
        private System.Windows.Forms.DataGridView dataGridViewStats_BTO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats_BTO;
    }
}