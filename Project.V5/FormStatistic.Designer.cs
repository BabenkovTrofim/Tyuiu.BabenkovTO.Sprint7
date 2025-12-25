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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistic));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            splitContainer1 = new SplitContainer();
            textBox1 = new TextBox();
            dataGridViewStats_BTO = new DataGridView();
            chartStats_BTO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStats_BTO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartStats_BTO).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 5, 4, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(dataGridViewStats_BTO);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(chartStats_BTO);
            splitContainer1.Size = new Size(1346, 609);
            splitContainer1.SplitterDistance = 585;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(3, 323);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(580, 283);
            textBox1.TabIndex = 1;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // dataGridViewStats_BTO
            // 
            dataGridViewStats_BTO.AllowUserToAddRows = false;
            dataGridViewStats_BTO.AllowUserToDeleteRows = false;
            dataGridViewStats_BTO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStats_BTO.Location = new Point(0, 0);
            dataGridViewStats_BTO.Margin = new Padding(4, 5, 4, 5);
            dataGridViewStats_BTO.Name = "dataGridViewStats_BTO";
            dataGridViewStats_BTO.ReadOnly = true;
            dataGridViewStats_BTO.RowHeadersWidth = 51;
            dataGridViewStats_BTO.Size = new Size(581, 321);
            dataGridViewStats_BTO.TabIndex = 0;
            // 
            // chartStats_BTO
            // 
            chartArea1.Name = "ChartArea1";
            chartStats_BTO.ChartAreas.Add(chartArea1);
            chartStats_BTO.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartStats_BTO.Legends.Add(legend1);
            chartStats_BTO.Location = new Point(0, 0);
            chartStats_BTO.Margin = new Padding(4, 5, 4, 5);
            chartStats_BTO.Name = "chartStats_BTO";
            chartStats_BTO.Size = new Size(756, 609);
            chartStats_BTO.TabIndex = 0;
            chartStats_BTO.Text = "Статистика по маркам";
            // 
            // FormStatistic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 609);
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormStatistic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика — Авторемонтные мастерские";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStats_BTO).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartStats_BTO).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewStats_BTO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats_BTO;
        private TextBox textBox1;
    }
}