using System.Windows.Forms;

namespace Project.V5
{
    partial class FormAddRecord
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
            tableLayoutPanelAdd_BTO = new TableLayoutPanel();
            textBoxLicense_BTO = new TextBox();
            textBoxOwnerName_BTO = new TextBox();
            labelOwnerPhone_BTO = new Label();
            labelMechanicName_BTO = new Label();
            textBoxMechanicName_BTO = new TextBox();
            labelMechanicQual_BTO = new Label();
            textBoxMechanicQual_BTO = new TextBox();
            textBoxCarNumber_BTO = new TextBox();
            textBoxCarBrand_BTO = new TextBox();
            textBoxCarColor_BTO = new TextBox();
            labelWorkshopName_BTO = new Label();
            textBoxWorkshopName_BTO = new TextBox();
            labelWorkshopPhone_BTO = new Label();
            textBoxWorkshopPhone_BTO = new TextBox();
            flowLayoutPanelButtons_BTO = new FlowLayoutPanel();
            buttonOK_BTO = new Button();
            buttonCancel_BTO = new Button();
            menuStrip1 = new MenuStrip();
            labelLicense_BTO = new Label();
            labelOwnerName_BTO = new Label();
            textBoxOwnerPhone_BTO = new TextBox();
            labelCarBrand_BTO = new Label();
            labelCarNumber_BTO = new Label();
            labelCarColor_BTO = new Label();
            tableLayoutPanelAdd_BTO.SuspendLayout();
            flowLayoutPanelButtons_BTO.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelAdd_BTO
            // 
            tableLayoutPanelAdd_BTO.ColumnCount = 2;
            tableLayoutPanelAdd_BTO.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.1844082F));
            tableLayoutPanelAdd_BTO.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.81559F));
            tableLayoutPanelAdd_BTO.Controls.Add(textBoxLicense_BTO, 1, 0);
            tableLayoutPanelAdd_BTO.Controls.Add(textBoxOwnerName_BTO, 1, 1);
            tableLayoutPanelAdd_BTO.Controls.Add(labelOwnerPhone_BTO, 0, 2);
            tableLayoutPanelAdd_BTO.Controls.Add(labelMechanicName_BTO, 0, 3);
            tableLayoutPanelAdd_BTO.Controls.Add(textBoxMechanicName_BTO, 1, 3);
            tableLayoutPanelAdd_BTO.Controls.Add(labelMechanicQual_BTO, 0, 4);
            tableLayoutPanelAdd_BTO.Controls.Add(textBoxMechanicQual_BTO, 1, 4);
            tableLayoutPanelAdd_BTO.Controls.Add(textBoxCarNumber_BTO, 1, 5);
            tableLayoutPanelAdd_BTO.Controls.Add(textBoxCarBrand_BTO, 1, 6);
            tableLayoutPanelAdd_BTO.Controls.Add(textBoxCarColor_BTO, 1, 7);
            tableLayoutPanelAdd_BTO.Controls.Add(labelWorkshopName_BTO, 0, 8);
            tableLayoutPanelAdd_BTO.Controls.Add(textBoxWorkshopName_BTO, 1, 8);
            tableLayoutPanelAdd_BTO.Controls.Add(labelWorkshopPhone_BTO, 0, 9);
            tableLayoutPanelAdd_BTO.Controls.Add(textBoxWorkshopPhone_BTO, 1, 9);
            tableLayoutPanelAdd_BTO.Controls.Add(flowLayoutPanelButtons_BTO, 0, 10);
            tableLayoutPanelAdd_BTO.Controls.Add(labelLicense_BTO, 0, 0);
            tableLayoutPanelAdd_BTO.Controls.Add(labelOwnerName_BTO, 0, 1);
            tableLayoutPanelAdd_BTO.Controls.Add(textBoxOwnerPhone_BTO, 1, 2);
            tableLayoutPanelAdd_BTO.Controls.Add(labelCarBrand_BTO, 0, 6);
            tableLayoutPanelAdd_BTO.Controls.Add(labelCarNumber_BTO, 0, 5);
            tableLayoutPanelAdd_BTO.Controls.Add(labelCarColor_BTO, 0, 7);
            tableLayoutPanelAdd_BTO.Dock = DockStyle.Fill;
            tableLayoutPanelAdd_BTO.Location = new Point(0, 0);
            tableLayoutPanelAdd_BTO.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanelAdd_BTO.Name = "tableLayoutPanelAdd_BTO";
            tableLayoutPanelAdd_BTO.RowCount = 11;
            tableLayoutPanelAdd_BTO.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanelAdd_BTO.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanelAdd_BTO.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelAdd_BTO.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanelAdd_BTO.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelAdd_BTO.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanelAdd_BTO.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanelAdd_BTO.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanelAdd_BTO.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanelAdd_BTO.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanelAdd_BTO.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanelAdd_BTO.Size = new Size(667, 408);
            tableLayoutPanelAdd_BTO.TabIndex = 0;
            // 
            // textBoxLicense_BTO
            // 
            textBoxLicense_BTO.Location = new Point(212, 5);
            textBoxLicense_BTO.Margin = new Padding(4, 5, 4, 5);
            textBoxLicense_BTO.Name = "textBoxLicense_BTO";
            textBoxLicense_BTO.Size = new Size(230, 27);
            textBoxLicense_BTO.TabIndex = 1;
            // 
            // textBoxOwnerName_BTO
            // 
            textBoxOwnerName_BTO.Location = new Point(212, 39);
            textBoxOwnerName_BTO.Margin = new Padding(4, 5, 4, 5);
            textBoxOwnerName_BTO.Name = "textBoxOwnerName_BTO";
            textBoxOwnerName_BTO.Size = new Size(230, 27);
            textBoxOwnerName_BTO.TabIndex = 3;
            // 
            // labelOwnerPhone_BTO
            // 
            labelOwnerPhone_BTO.Location = new Point(4, 66);
            labelOwnerPhone_BTO.Margin = new Padding(4, 0, 4, 0);
            labelOwnerPhone_BTO.Name = "labelOwnerPhone_BTO";
            labelOwnerPhone_BTO.Size = new Size(184, 40);
            labelOwnerPhone_BTO.TabIndex = 4;
            labelOwnerPhone_BTO.Text = "Телефон владельца:";
            // 
            // labelMechanicName_BTO
            // 
            labelMechanicName_BTO.Location = new Point(4, 106);
            labelMechanicName_BTO.Margin = new Padding(4, 0, 4, 0);
            labelMechanicName_BTO.Name = "labelMechanicName_BTO";
            labelMechanicName_BTO.Size = new Size(145, 20);
            labelMechanicName_BTO.TabIndex = 6;
            labelMechanicName_BTO.Text = "ФИО механика:";
            // 
            // textBoxMechanicName_BTO
            // 
            textBoxMechanicName_BTO.Location = new Point(212, 111);
            textBoxMechanicName_BTO.Margin = new Padding(4, 5, 4, 5);
            textBoxMechanicName_BTO.Name = "textBoxMechanicName_BTO";
            textBoxMechanicName_BTO.Size = new Size(230, 27);
            textBoxMechanicName_BTO.TabIndex = 7;
            // 
            // labelMechanicQual_BTO
            // 
            labelMechanicQual_BTO.Location = new Point(4, 140);
            labelMechanicQual_BTO.Margin = new Padding(4, 0, 4, 0);
            labelMechanicQual_BTO.Name = "labelMechanicQual_BTO";
            labelMechanicQual_BTO.Size = new Size(133, 20);
            labelMechanicQual_BTO.TabIndex = 8;
            labelMechanicQual_BTO.Text = "Квалификация:";
            // 
            // textBoxMechanicQual_BTO
            // 
            textBoxMechanicQual_BTO.Location = new Point(212, 145);
            textBoxMechanicQual_BTO.Margin = new Padding(4, 5, 4, 5);
            textBoxMechanicQual_BTO.Name = "textBoxMechanicQual_BTO";
            textBoxMechanicQual_BTO.Size = new Size(148, 27);
            textBoxMechanicQual_BTO.TabIndex = 9;
            // 
            // textBoxCarNumber_BTO
            // 
            textBoxCarNumber_BTO.Location = new Point(212, 180);
            textBoxCarNumber_BTO.Margin = new Padding(4, 5, 4, 5);
            textBoxCarNumber_BTO.Name = "textBoxCarNumber_BTO";
            textBoxCarNumber_BTO.Size = new Size(148, 27);
            textBoxCarNumber_BTO.TabIndex = 11;
            // 
            // textBoxCarBrand_BTO
            // 
            textBoxCarBrand_BTO.Location = new Point(212, 219);
            textBoxCarBrand_BTO.Margin = new Padding(4, 5, 4, 5);
            textBoxCarBrand_BTO.Name = "textBoxCarBrand_BTO";
            textBoxCarBrand_BTO.Size = new Size(148, 27);
            textBoxCarBrand_BTO.TabIndex = 13;
            // 
            // textBoxCarColor_BTO
            // 
            textBoxCarColor_BTO.Location = new Point(212, 255);
            textBoxCarColor_BTO.Margin = new Padding(4, 5, 4, 5);
            textBoxCarColor_BTO.Name = "textBoxCarColor_BTO";
            textBoxCarColor_BTO.Size = new Size(148, 27);
            textBoxCarColor_BTO.TabIndex = 15;
            // 
            // labelWorkshopName_BTO
            // 
            labelWorkshopName_BTO.Location = new Point(4, 283);
            labelWorkshopName_BTO.Margin = new Padding(4, 0, 4, 0);
            labelWorkshopName_BTO.Name = "labelWorkshopName_BTO";
            labelWorkshopName_BTO.Size = new Size(200, 32);
            labelWorkshopName_BTO.TabIndex = 16;
            labelWorkshopName_BTO.Text = "Название автомастерской:";
            // 
            // textBoxWorkshopName_BTO
            // 
            textBoxWorkshopName_BTO.Location = new Point(212, 288);
            textBoxWorkshopName_BTO.Margin = new Padding(4, 5, 4, 5);
            textBoxWorkshopName_BTO.Name = "textBoxWorkshopName_BTO";
            textBoxWorkshopName_BTO.Size = new Size(230, 27);
            textBoxWorkshopName_BTO.TabIndex = 17;
            // 
            // labelWorkshopPhone_BTO
            // 
            labelWorkshopPhone_BTO.Location = new Point(4, 319);
            labelWorkshopPhone_BTO.Margin = new Padding(4, 0, 4, 0);
            labelWorkshopPhone_BTO.Name = "labelWorkshopPhone_BTO";
            labelWorkshopPhone_BTO.Size = new Size(200, 32);
            labelWorkshopPhone_BTO.TabIndex = 18;
            labelWorkshopPhone_BTO.Text = "Телефон автомастерской:";
            // 
            // textBoxWorkshopPhone_BTO
            // 
            textBoxWorkshopPhone_BTO.Location = new Point(212, 324);
            textBoxWorkshopPhone_BTO.Margin = new Padding(4, 5, 4, 5);
            textBoxWorkshopPhone_BTO.Name = "textBoxWorkshopPhone_BTO";
            textBoxWorkshopPhone_BTO.Size = new Size(230, 27);
            textBoxWorkshopPhone_BTO.TabIndex = 19;
            // 
            // flowLayoutPanelButtons_BTO
            // 
            tableLayoutPanelAdd_BTO.SetColumnSpan(flowLayoutPanelButtons_BTO, 2);
            flowLayoutPanelButtons_BTO.Controls.Add(buttonOK_BTO);
            flowLayoutPanelButtons_BTO.Controls.Add(buttonCancel_BTO);
            flowLayoutPanelButtons_BTO.Controls.Add(menuStrip1);
            flowLayoutPanelButtons_BTO.Dock = DockStyle.Right;
            flowLayoutPanelButtons_BTO.Location = new Point(438, 361);
            flowLayoutPanelButtons_BTO.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanelButtons_BTO.Name = "flowLayoutPanelButtons_BTO";
            flowLayoutPanelButtons_BTO.Size = new Size(225, 42);
            flowLayoutPanelButtons_BTO.TabIndex = 20;
            // 
            // buttonOK_BTO
            // 
            buttonOK_BTO.Location = new Point(4, 5);
            buttonOK_BTO.Margin = new Padding(4, 5, 4, 5);
            buttonOK_BTO.Name = "buttonOK_BTO";
            buttonOK_BTO.Size = new Size(100, 35);
            buttonOK_BTO.TabIndex = 0;
            buttonOK_BTO.Text = "OK";
            buttonOK_BTO.UseVisualStyleBackColor = true;
            buttonOK_BTO.Click += buttonOK_BTO_Click;
            // 
            // buttonCancel_BTO
            // 
            buttonCancel_BTO.Location = new Point(112, 5);
            buttonCancel_BTO.Margin = new Padding(4, 5, 4, 5);
            buttonCancel_BTO.Name = "buttonCancel_BTO";
            buttonCancel_BTO.Size = new Size(100, 35);
            buttonCancel_BTO.TabIndex = 1;
            buttonCancel_BTO.Text = "Отмена";
            buttonCancel_BTO.UseVisualStyleBackColor = true;
            buttonCancel_BTO.Click += buttonCancel_BTO_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 45);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(202, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // labelLicense_BTO
            // 
            labelLicense_BTO.AutoSize = true;
            labelLicense_BTO.Dock = DockStyle.Left;
            labelLicense_BTO.Location = new Point(4, 0);
            labelLicense_BTO.Margin = new Padding(4, 0, 4, 0);
            labelLicense_BTO.Name = "labelLicense_BTO";
            labelLicense_BTO.Size = new Size(98, 34);
            labelLicense_BTO.TabIndex = 0;
            labelLicense_BTO.Text = "Номер прав:";
            // 
            // labelOwnerName_BTO
            // 
            labelOwnerName_BTO.Location = new Point(4, 34);
            labelOwnerName_BTO.Margin = new Padding(4, 0, 4, 0);
            labelOwnerName_BTO.Name = "labelOwnerName_BTO";
            labelOwnerName_BTO.Size = new Size(133, 32);
            labelOwnerName_BTO.TabIndex = 2;
            labelOwnerName_BTO.Text = "ФИО владельца:";
            // 
            // textBoxOwnerPhone_BTO
            // 
            textBoxOwnerPhone_BTO.Location = new Point(212, 71);
            textBoxOwnerPhone_BTO.Margin = new Padding(4, 5, 4, 5);
            textBoxOwnerPhone_BTO.Name = "textBoxOwnerPhone_BTO";
            textBoxOwnerPhone_BTO.Size = new Size(230, 27);
            textBoxOwnerPhone_BTO.TabIndex = 5;
            // 
            // labelCarBrand_BTO
            // 
            labelCarBrand_BTO.Location = new Point(4, 214);
            labelCarBrand_BTO.Margin = new Padding(4, 0, 4, 0);
            labelCarBrand_BTO.Name = "labelCarBrand_BTO";
            labelCarBrand_BTO.Size = new Size(133, 20);
            labelCarBrand_BTO.TabIndex = 12;
            labelCarBrand_BTO.Text = "Марка:";
            // 
            // labelCarNumber_BTO
            // 
            labelCarNumber_BTO.Location = new Point(4, 175);
            labelCarNumber_BTO.Margin = new Padding(4, 0, 4, 0);
            labelCarNumber_BTO.Name = "labelCarNumber_BTO";
            labelCarNumber_BTO.Size = new Size(155, 39);
            labelCarNumber_BTO.TabIndex = 10;
            labelCarNumber_BTO.Text = "Номер автомобиля:";
            // 
            // labelCarColor_BTO
            // 
            labelCarColor_BTO.Location = new Point(4, 250);
            labelCarColor_BTO.Margin = new Padding(4, 0, 4, 0);
            labelCarColor_BTO.Name = "labelCarColor_BTO";
            labelCarColor_BTO.Size = new Size(133, 27);
            labelCarColor_BTO.TabIndex = 14;
            labelCarColor_BTO.Text = "Цвет:";
            labelCarColor_BTO.Click += labelCarColor_BTO_Click;
            // 
            // FormAddRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 408);
            Controls.Add(tableLayoutPanelAdd_BTO);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormAddRecord";
            Text = "Добавить запись — Авторемонт";
            tableLayoutPanelAdd_BTO.ResumeLayout(false);
            tableLayoutPanelAdd_BTO.PerformLayout();
            flowLayoutPanelButtons_BTO.ResumeLayout(false);
            flowLayoutPanelButtons_BTO.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAdd_BTO;
        private System.Windows.Forms.Label labelLicense_BTO;
        private System.Windows.Forms.TextBox textBoxLicense_BTO;
        private System.Windows.Forms.Label labelOwnerName_BTO;
        private System.Windows.Forms.TextBox textBoxOwnerName_BTO;
        private System.Windows.Forms.Label labelOwnerPhone_BTO;
        private System.Windows.Forms.TextBox textBoxOwnerPhone_BTO;
        private System.Windows.Forms.Label labelMechanicName_BTO;
        private System.Windows.Forms.TextBox textBoxMechanicName_BTO;
        private System.Windows.Forms.Label labelMechanicQual_BTO;
        private System.Windows.Forms.TextBox textBoxMechanicQual_BTO;
        private System.Windows.Forms.Label labelCarNumber_BTO;
        private System.Windows.Forms.TextBox textBoxCarNumber_BTO;
        private System.Windows.Forms.Label labelCarBrand_BTO;
        private System.Windows.Forms.TextBox textBoxCarBrand_BTO;
        private System.Windows.Forms.Label labelCarColor_BTO;
        private System.Windows.Forms.TextBox textBoxCarColor_BTO;
        private System.Windows.Forms.Label labelWorkshopName_BTO;
        private System.Windows.Forms.TextBox textBoxWorkshopName_BTO;
        private System.Windows.Forms.Label labelWorkshopPhone_BTO;
        private System.Windows.Forms.TextBox textBoxWorkshopPhone_BTO;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons_BTO;
        private System.Windows.Forms.Button buttonOK_BTO;
        private System.Windows.Forms.Button buttonCancel_BTO;
        private MenuStrip menuStrip1;
    }
}