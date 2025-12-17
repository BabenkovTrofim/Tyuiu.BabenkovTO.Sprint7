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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainerStats_BTO = new System.Windows.Forms.SplitContainer();
            this.dataGridViewStats_BTO = new System.Windows.Forms.DataGridView();
            this.chartStats_BTO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerStats_BTO)).BeginInit();
            this.splitContainerStats_BTO.Panel1.SuspendLayout();
            this.splitContainerStats_BTO.Panel2.SuspendLayout();
            this.splitContainerStats_BTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStats_BTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats_BTO)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerStats_BTO
            // 
            this.splitContainerStats_BTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerStats_BTO.Location = new System.Drawing.Point(0, 0);
            this.splitContainerStats_BTO.Name = "splitContainerStats_BTO";
            // 
            // splitContainerStats_BTO.Panel1
            // 
            this.splitContainerStats_BTO.Panel1.Controls.Add(this.dataGridViewStats_BTO);
            // 
            // splitContainerStats_BTO.Panel2
            // 
            this.splitContainerStats_BTO.Panel2.Controls.Add(this.chartStats_BTO);
            this.splitContainerStats_BTO.Size = new System.Drawing.Size(900, 500);
            this.splitContainerStats_BTO.SplitterDistance = 400;
            this.splitContainerStats_BTO.TabIndex = 0;
            // 
            // dataGridViewStats_BTO
            // 
            this.dataGridViewStats_BTO.AllowUserToAddRows = false;
            this.dataGridViewStats_BTO.AllowUserToDeleteRows = false;
            this.dataGridViewStats_BTO.AllowUserToOrderColumns = true;
            this.dataGridViewStats_BTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStats_BTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStats_BTO.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStats_BTO.Name = "dataGridViewStats_BTO";
            this.dataGridViewStats_BTO.ReadOnly = true;
            this.dataGridViewStats_BTO.Size = new System.Drawing.Size(400, 500);
            this.dataGridViewStats_BTO.TabIndex = 0;
            // 
            // chartStats_BTO
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStats_BTO.ChartAreas.Add(chartArea1);
            this.chartStats_BTO.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartStats_BTO.Legends.Add(legend1);
            this.chartStats_BTO.Location = new System.Drawing.Point(0, 0);
            this.chartStats_BTO.Name = "chartStats_BTO";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Статистика";
            this.chartStats_BTO.Series.Add(series1);
            this.chartStats_BTO.Size = new System.Drawing.Size(496, 500);
            this.chartStats_BTO.TabIndex = 0;
            this.chartStats_BTO.Text = "Статистика по мастерским";
            // 
            // FormStatistic_BTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.splitContainerStats_BTO);
            this.Name = "FormStatistic_BTO";
            this.Text = "Статистика — Авторемонтные мастерские";
            this.splitContainerStats_BTO.Panel1.ResumeLayout(false);
            this.splitContainerStats_BTO.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerStats_BTO)).EndInit();
            this.splitContainerStats_BTO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStats_BTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats_BTO)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainerStats_BTO;
        private System.Windows.Forms.DataGridView dataGridViewStats_BTO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats_BTO;
    }
}