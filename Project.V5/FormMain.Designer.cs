namespace Project.V5
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            menuStripMain_BTO = new MenuStrip();
            файлToolStripMenuItem_BTO = new ToolStripMenuItem();
            открытьToolStripMenuItem_BTO = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem_BTO = new ToolStripMenuItem();
            toolStripSeparator1_BTO = new ToolStripSeparator();
            выходToolStripMenuItem_BTO = new ToolStripMenuItem();
            отчётыToolStripMenuItem_BTO = new ToolStripMenuItem();
            статистикаToolStripMenuItem_BTO = new ToolStripMenuItem();
            справкаToolStripMenuItem_BTO = new ToolStripMenuItem();
            руководствоПользователяToolStripMenuItem_BTO = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem_BTO = new ToolStripMenuItem();
            toolStripMain_BTO = new ToolStrip();
            buttonAdd_BTO = new ToolStripButton();
            buttonDelete_BTO = new ToolStripButton();
            toolStripSeparator2_BTO = new ToolStripSeparator();
            buttonOpenFile_BTO = new ToolStripButton();
            buttonSaveFile_BTO = new ToolStripButton();
            toolStripSeparator3_BTO = new ToolStripSeparator();
            buttonRefresh_BTO = new ToolStripButton();
            dataGridViewMain_BTO = new DataGridView();
            tableLayoutPanelMain_BTO = new TableLayoutPanel();
            panelSearch_BTO = new Panel();
            labelSearchBrand_BTO = new Label();
            textBoxSearchBrand_BTO = new TextBox();
            buttonSearchBrand_BTO = new Button();
            labelSearchOwner_BTO = new Label();
            textBoxSearchOwner_BTO = new TextBox();
            buttonSearchOwner_BTO = new Button();
            toolTipMain_BTO = new ToolTip(components);
            menuStripMain_BTO.SuspendLayout();
            toolStripMain_BTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain_BTO).BeginInit();
            tableLayoutPanelMain_BTO.SuspendLayout();
            panelSearch_BTO.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain_BTO
            // 
            menuStripMain_BTO.BackColor = Color.FromArgb(192, 255, 192);
            menuStripMain_BTO.ImageScalingSize = new Size(20, 20);
            menuStripMain_BTO.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem_BTO, отчётыToolStripMenuItem_BTO, справкаToolStripMenuItem_BTO });
            menuStripMain_BTO.Location = new Point(0, 0);
            menuStripMain_BTO.Name = "menuStripMain_BTO";
            menuStripMain_BTO.Padding = new Padding(10, 3, 0, 3);
            menuStripMain_BTO.Size = new Size(1667, 35);
            menuStripMain_BTO.TabIndex = 0;
            // 
            // файлToolStripMenuItem_BTO
            // 
            файлToolStripMenuItem_BTO.BackColor = Color.CornflowerBlue;
            файлToolStripMenuItem_BTO.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem_BTO, сохранитьКакToolStripMenuItem_BTO, toolStripSeparator1_BTO, выходToolStripMenuItem_BTO });
            файлToolStripMenuItem_BTO.Font = new Font("Segoe UI", 11F);
            файлToolStripMenuItem_BTO.Name = "файлToolStripMenuItem_BTO";
            файлToolStripMenuItem_BTO.Size = new Size(71, 29);
            файлToolStripMenuItem_BTO.Text = "Файл";
            файлToolStripMenuItem_BTO.ToolTipText = "Нажмите, для управления файлом\r\n";
            // 
            // открытьToolStripMenuItem_BTO
            // 
            открытьToolStripMenuItem_BTO.Name = "открытьToolStripMenuItem_BTO";
            открытьToolStripMenuItem_BTO.Size = new Size(236, 30);
            открытьToolStripMenuItem_BTO.Text = "Открыть...";
            открытьToolStripMenuItem_BTO.Click += buttonOpenFile_BTO_Click;
            // 
            // сохранитьКакToolStripMenuItem_BTO
            // 
            сохранитьКакToolStripMenuItem_BTO.Name = "сохранитьКакToolStripMenuItem_BTO";
            сохранитьКакToolStripMenuItem_BTO.Size = new Size(236, 30);
            сохранитьКакToolStripMenuItem_BTO.Text = "Сохранить как...";
            сохранитьКакToolStripMenuItem_BTO.Click += buttonSaveFile_BTO_Click;
            // 
            // toolStripSeparator1_BTO
            // 
            toolStripSeparator1_BTO.Name = "toolStripSeparator1_BTO";
            toolStripSeparator1_BTO.Size = new Size(233, 6);
            // 
            // выходToolStripMenuItem_BTO
            // 
            выходToolStripMenuItem_BTO.Name = "выходToolStripMenuItem_BTO";
            выходToolStripMenuItem_BTO.Size = new Size(236, 30);
            выходToolStripMenuItem_BTO.Text = "Выход";
            выходToolStripMenuItem_BTO.ToolTipText = "Закрыть программу";
            выходToolStripMenuItem_BTO.Click += выходToolStripMenuItem_BTO_Click;
            // 
            // отчётыToolStripMenuItem_BTO
            // 
            отчётыToolStripMenuItem_BTO.BackColor = Color.CornflowerBlue;
            отчётыToolStripMenuItem_BTO.DropDownItems.AddRange(new ToolStripItem[] { статистикаToolStripMenuItem_BTO });
            отчётыToolStripMenuItem_BTO.Font = new Font("Segoe UI", 11F);
            отчётыToolStripMenuItem_BTO.Name = "отчётыToolStripMenuItem_BTO";
            отчётыToolStripMenuItem_BTO.Size = new Size(90, 29);
            отчётыToolStripMenuItem_BTO.Text = "Отчёты";
            // 
            // статистикаToolStripMenuItem_BTO
            // 
            статистикаToolStripMenuItem_BTO.Name = "статистикаToolStripMenuItem_BTO";
            статистикаToolStripMenuItem_BTO.Size = new Size(194, 30);
            статистикаToolStripMenuItem_BTO.Text = "Статистика";
            статистикаToolStripMenuItem_BTO.Click += статистикаToolStripMenuItem_BTO_Click;
            // 
            // справкаToolStripMenuItem_BTO
            // 
            справкаToolStripMenuItem_BTO.BackColor = Color.CornflowerBlue;
            справкаToolStripMenuItem_BTO.DropDownItems.AddRange(new ToolStripItem[] { руководствоПользователяToolStripMenuItem_BTO, оПрограммеToolStripMenuItem_BTO });
            справкаToolStripMenuItem_BTO.Font = new Font("Segoe UI", 11F);
            справкаToolStripMenuItem_BTO.Name = "справкаToolStripMenuItem_BTO";
            справкаToolStripMenuItem_BTO.Size = new Size(99, 29);
            справкаToolStripMenuItem_BTO.Text = "Справка";
            // 
            // руководствоПользователяToolStripMenuItem_BTO
            // 
            руководствоПользователяToolStripMenuItem_BTO.Name = "руководствоПользователяToolStripMenuItem_BTO";
            руководствоПользователяToolStripMenuItem_BTO.Size = new Size(331, 30);
            руководствоПользователяToolStripMenuItem_BTO.Text = "Руководство пользователя";
            руководствоПользователяToolStripMenuItem_BTO.Click += руководствоПользователяToolStripMenuItem_BTO_Click;
            // 
            // оПрограммеToolStripMenuItem_BTO
            // 
            оПрограммеToolStripMenuItem_BTO.Name = "оПрограммеToolStripMenuItem_BTO";
            оПрограммеToolStripMenuItem_BTO.Size = new Size(331, 30);
            оПрограммеToolStripMenuItem_BTO.Text = "О программе";
            оПрограммеToolStripMenuItem_BTO.Click += оПрограммеToolStripMenuItem_BTO_Click;
            // 
            // toolStripMain_BTO
            // 
            toolStripMain_BTO.BackColor = Color.FromArgb(192, 255, 192);
            toolStripMain_BTO.ImageScalingSize = new Size(20, 20);
            toolStripMain_BTO.Items.AddRange(new ToolStripItem[] { buttonAdd_BTO, buttonDelete_BTO, toolStripSeparator2_BTO, buttonOpenFile_BTO, buttonSaveFile_BTO, toolStripSeparator3_BTO, buttonRefresh_BTO });
            toolStripMain_BTO.Location = new Point(0, 35);
            toolStripMain_BTO.Name = "toolStripMain_BTO";
            toolStripMain_BTO.Size = new Size(1667, 32);
            toolStripMain_BTO.TabIndex = 1;
            // 
            // buttonAdd_BTO
            // 
            buttonAdd_BTO.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buttonAdd_BTO.Font = new Font("Segoe UI", 11F);
            buttonAdd_BTO.ImageTransparentColor = Color.Magenta;
            buttonAdd_BTO.Name = "buttonAdd_BTO";
            buttonAdd_BTO.Size = new Size(100, 29);
            buttonAdd_BTO.Text = "Добавить";
            buttonAdd_BTO.ToolTipText = "Нажмите, чтобы добавить запись в ваш файл";
            buttonAdd_BTO.Click += buttonAdd_BTO_Click;
            // 
            // buttonDelete_BTO
            // 
            buttonDelete_BTO.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buttonDelete_BTO.Font = new Font("Segoe UI", 11F);
            buttonDelete_BTO.ImageTransparentColor = Color.Magenta;
            buttonDelete_BTO.Name = "buttonDelete_BTO";
            buttonDelete_BTO.Size = new Size(86, 29);
            buttonDelete_BTO.Text = "Удалить";
            buttonDelete_BTO.ToolTipText = "Нажмите, чтобы удалить данные файла\r\n";
            buttonDelete_BTO.Click += buttonDelete_BTO_Click;
            // 
            // toolStripSeparator2_BTO
            // 
            toolStripSeparator2_BTO.Name = "toolStripSeparator2_BTO";
            toolStripSeparator2_BTO.Size = new Size(6, 32);
            // 
            // buttonOpenFile_BTO
            // 
            buttonOpenFile_BTO.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buttonOpenFile_BTO.Font = new Font("Segoe UI", 11F);
            buttonOpenFile_BTO.ImageTransparentColor = Color.Magenta;
            buttonOpenFile_BTO.Name = "buttonOpenFile_BTO";
            buttonOpenFile_BTO.Size = new Size(89, 29);
            buttonOpenFile_BTO.Text = "Открыть";
            buttonOpenFile_BTO.ToolTipText = "Нажмите, чтобы выбрать и открыть файл";
            buttonOpenFile_BTO.Click += buttonOpenFile_BTO_Click;
            // 
            // buttonSaveFile_BTO
            // 
            buttonSaveFile_BTO.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buttonSaveFile_BTO.Font = new Font("Segoe UI", 11F);
            buttonSaveFile_BTO.ImageTransparentColor = Color.Magenta;
            buttonSaveFile_BTO.Name = "buttonSaveFile_BTO";
            buttonSaveFile_BTO.Size = new Size(109, 29);
            buttonSaveFile_BTO.Text = "Сохранить";
            buttonSaveFile_BTO.ToolTipText = "Нажмите, чтобы сохранить ваш файл\r\n";
            buttonSaveFile_BTO.Click += buttonSaveFile_BTO_Click;
            // 
            // toolStripSeparator3_BTO
            // 
            toolStripSeparator3_BTO.BackColor = Color.Black;
            toolStripSeparator3_BTO.ForeColor = SystemColors.ActiveCaptionText;
            toolStripSeparator3_BTO.Name = "toolStripSeparator3_BTO";
            toolStripSeparator3_BTO.Size = new Size(6, 32);
            // 
            // buttonRefresh_BTO
            // 
            buttonRefresh_BTO.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buttonRefresh_BTO.Font = new Font("Segoe UI", 11F);
            buttonRefresh_BTO.ImageTransparentColor = Color.Magenta;
            buttonRefresh_BTO.Name = "buttonRefresh_BTO";
            buttonRefresh_BTO.Size = new Size(102, 29);
            buttonRefresh_BTO.Text = "Обновить";
            buttonRefresh_BTO.ToolTipText = "Нажмите, чтобы обновить таблицу";
            buttonRefresh_BTO.Click += buttonRefresh_BTO_Click;
            // 
            // dataGridViewMain_BTO
            // 
            dataGridViewMain_BTO.AllowUserToAddRows = false;
            dataGridViewMain_BTO.AllowUserToDeleteRows = false;
            dataGridViewMain_BTO.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewMain_BTO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain_BTO.Dock = DockStyle.Fill;
            dataGridViewMain_BTO.Location = new Point(4, 65);
            dataGridViewMain_BTO.Margin = new Padding(4, 7, 4, 7);
            dataGridViewMain_BTO.Name = "dataGridViewMain_BTO";
            dataGridViewMain_BTO.ReadOnly = true;
            dataGridViewMain_BTO.RowHeadersWidth = 51;
            dataGridViewMain_BTO.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMain_BTO.Size = new Size(1659, 734);
            dataGridViewMain_BTO.TabIndex = 2;
            // 
            // tableLayoutPanelMain_BTO
            // 
            tableLayoutPanelMain_BTO.ColumnCount = 1;
            tableLayoutPanelMain_BTO.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain_BTO.Controls.Add(dataGridViewMain_BTO, 0, 1);
            tableLayoutPanelMain_BTO.Controls.Add(panelSearch_BTO, 0, 0);
            tableLayoutPanelMain_BTO.Dock = DockStyle.Fill;
            tableLayoutPanelMain_BTO.Location = new Point(0, 67);
            tableLayoutPanelMain_BTO.Margin = new Padding(4, 7, 4, 7);
            tableLayoutPanelMain_BTO.Name = "tableLayoutPanelMain_BTO";
            tableLayoutPanelMain_BTO.RowCount = 2;
            tableLayoutPanelMain_BTO.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanelMain_BTO.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain_BTO.Size = new Size(1667, 806);
            tableLayoutPanelMain_BTO.TabIndex = 3;
            // 
            // panelSearch_BTO
            // 
            panelSearch_BTO.Controls.Add(labelSearchBrand_BTO);
            panelSearch_BTO.Controls.Add(textBoxSearchBrand_BTO);
            panelSearch_BTO.Controls.Add(buttonSearchBrand_BTO);
            panelSearch_BTO.Controls.Add(labelSearchOwner_BTO);
            panelSearch_BTO.Controls.Add(textBoxSearchOwner_BTO);
            panelSearch_BTO.Controls.Add(buttonSearchOwner_BTO);
            panelSearch_BTO.Dock = DockStyle.Fill;
            panelSearch_BTO.Location = new Point(4, 7);
            panelSearch_BTO.Margin = new Padding(4, 7, 4, 7);
            panelSearch_BTO.Name = "panelSearch_BTO";
            panelSearch_BTO.Size = new Size(1659, 44);
            panelSearch_BTO.TabIndex = 3;
            // 
            // labelSearchBrand_BTO
            // 
            labelSearchBrand_BTO.AutoSize = true;
            labelSearchBrand_BTO.Location = new Point(667, 8);
            labelSearchBrand_BTO.Margin = new Padding(4, 0, 4, 0);
            labelSearchBrand_BTO.Name = "labelSearchBrand_BTO";
            labelSearchBrand_BTO.Size = new Size(117, 25);
            labelSearchBrand_BTO.TabIndex = 5;
            labelSearchBrand_BTO.Text = "Марка авто:";
            // 
            // textBoxSearchBrand_BTO
            // 
            textBoxSearchBrand_BTO.BackColor = Color.LightBlue;
            textBoxSearchBrand_BTO.Location = new Point(820, 3);
            textBoxSearchBrand_BTO.Margin = new Padding(4, 7, 4, 7);
            textBoxSearchBrand_BTO.Name = "textBoxSearchBrand_BTO";
            textBoxSearchBrand_BTO.Size = new Size(197, 32);
            textBoxSearchBrand_BTO.TabIndex = 4;
            // 
            // buttonSearchBrand_BTO
            // 
            buttonSearchBrand_BTO.BackColor = Color.CornflowerBlue;
            buttonSearchBrand_BTO.Location = new Point(1030, 0);
            buttonSearchBrand_BTO.Margin = new Padding(4, 7, 4, 7);
            buttonSearchBrand_BTO.Name = "buttonSearchBrand_BTO";
            buttonSearchBrand_BTO.Size = new Size(124, 43);
            buttonSearchBrand_BTO.TabIndex = 3;
            buttonSearchBrand_BTO.Text = "Поиск";
            buttonSearchBrand_BTO.UseVisualStyleBackColor = false;
            buttonSearchBrand_BTO.Click += buttonSearchBrand_BTO_Click;
            // 
            // labelSearchOwner_BTO
            // 
            labelSearchOwner_BTO.AutoSize = true;
            labelSearchOwner_BTO.Location = new Point(4, 8);
            labelSearchOwner_BTO.Margin = new Padding(4, 0, 4, 0);
            labelSearchOwner_BTO.Name = "labelSearchOwner_BTO";
            labelSearchOwner_BTO.Size = new Size(154, 25);
            labelSearchOwner_BTO.TabIndex = 2;
            labelSearchOwner_BTO.Text = "ФИО владельца:";
            // 
            // textBoxSearchOwner_BTO
            // 
            textBoxSearchOwner_BTO.BackColor = Color.LightBlue;
            textBoxSearchOwner_BTO.Location = new Point(179, 3);
            textBoxSearchOwner_BTO.Margin = new Padding(4, 7, 4, 7);
            textBoxSearchOwner_BTO.Name = "textBoxSearchOwner_BTO";
            textBoxSearchOwner_BTO.Size = new Size(197, 32);
            textBoxSearchOwner_BTO.TabIndex = 1;
            // 
            // buttonSearchOwner_BTO
            // 
            buttonSearchOwner_BTO.BackColor = Color.CornflowerBlue;
            buttonSearchOwner_BTO.Location = new Point(389, 0);
            buttonSearchOwner_BTO.Margin = new Padding(4, 7, 4, 7);
            buttonSearchOwner_BTO.Name = "buttonSearchOwner_BTO";
            buttonSearchOwner_BTO.Size = new Size(124, 43);
            buttonSearchOwner_BTO.TabIndex = 0;
            buttonSearchOwner_BTO.Text = "Поиск";
            buttonSearchOwner_BTO.UseVisualStyleBackColor = false;
            buttonSearchOwner_BTO.Click += buttonSearchOwner_BTO_Click;
            // 
            // toolTipMain_BTO
            // 
            toolTipMain_BTO.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1667, 873);
            Controls.Add(tableLayoutPanelMain_BTO);
            Controls.Add(toolStripMain_BTO);
            Controls.Add(menuStripMain_BTO);
            Font = new Font("Segoe UI", 11F);
            MainMenuStrip = menuStripMain_BTO;
            Margin = new Padding(4, 7, 4, 7);
            Name = "FormMain";
            Text = "Авторемонтные мастерские — Главное окно";
            menuStripMain_BTO.ResumeLayout(false);
            menuStripMain_BTO.PerformLayout();
            toolStripMain_BTO.ResumeLayout(false);
            toolStripMain_BTO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain_BTO).EndInit();
            tableLayoutPanelMain_BTO.ResumeLayout(false);
            panelSearch_BTO.ResumeLayout(false);
            panelSearch_BTO.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMain_BTO;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem_BTO;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem_BTO;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem_BTO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1_BTO;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem_BTO;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem_BTO;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem_BTO;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem_BTO;
        private System.Windows.Forms.ToolStripMenuItem руководствоПользователяToolStripMenuItem_BTO;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem_BTO;
        private System.Windows.Forms.ToolStrip toolStripMain_BTO;
        private System.Windows.Forms.ToolStripButton buttonAdd_BTO;
        private System.Windows.Forms.ToolStripButton buttonDelete_BTO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2_BTO;
        private System.Windows.Forms.ToolStripButton buttonOpenFile_BTO;
        private System.Windows.Forms.ToolStripButton buttonSaveFile_BTO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3_BTO;
        private System.Windows.Forms.ToolStripButton buttonRefresh_BTO;
        private System.Windows.Forms.DataGridView dataGridViewMain_BTO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain_BTO;
        private System.Windows.Forms.Panel panelSearch_BTO;
        private System.Windows.Forms.Label labelSearchBrand_BTO;
        private System.Windows.Forms.TextBox textBoxSearchBrand_BTO;
        private System.Windows.Forms.Button buttonSearchBrand_BTO;
        private System.Windows.Forms.Label labelSearchOwner_BTO;
        private System.Windows.Forms.TextBox textBoxSearchOwner_BTO;
        private System.Windows.Forms.Button buttonSearchOwner_BTO;
        private System.Windows.Forms.ToolTip toolTipMain_BTO;
    }
}
