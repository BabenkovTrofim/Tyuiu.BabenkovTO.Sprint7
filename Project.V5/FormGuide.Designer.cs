namespace Project.V5
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            textBoxGuide_BTO = new TextBox();
            buttonOkGuide_BTO = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxGuide_BTO
            // 
            textBoxGuide_BTO.BackColor = Color.White;
            textBoxGuide_BTO.BorderStyle = BorderStyle.FixedSingle;
            textBoxGuide_BTO.Font = new Font("Consolas", 14F);
            textBoxGuide_BTO.Location = new Point(10, 14);
            textBoxGuide_BTO.Margin = new Padding(4, 5, 4, 5);
            textBoxGuide_BTO.Multiline = true;
            textBoxGuide_BTO.Name = "textBoxGuide_BTO";
            textBoxGuide_BTO.ReadOnly = true;
            textBoxGuide_BTO.Size = new Size(817, 287);
            textBoxGuide_BTO.TabIndex = 1;
            textBoxGuide_BTO.Text = resources.GetString("textBoxGuide_BTO.Text");
            textBoxGuide_BTO.WordWrap = false;
            // 
            // buttonOkGuide_BTO
            // 
            buttonOkGuide_BTO.BackColor = SystemColors.Window;
            buttonOkGuide_BTO.Location = new Point(729, 309);
            buttonOkGuide_BTO.Name = "buttonOkGuide_BTO";
            buttonOkGuide_BTO.Size = new Size(98, 35);
            buttonOkGuide_BTO.TabIndex = 1;
            buttonOkGuide_BTO.Text = "ОК";
            buttonOkGuide_BTO.UseVisualStyleBackColor = false;
            buttonOkGuide_BTO.Click += buttonOkGuide_BTO_Click;
            // 
            // button1
            // 
            button1.Location = new Point(841, 430);
            button1.Name = "button1";
            button1.Size = new Size(10, 10);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(840, 353);
            Controls.Add(textBoxGuide_BTO);
            Controls.Add(buttonOkGuide_BTO);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormGuide";
            Text = "Руководство пользователя — Авторемонтные мастерские";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxGuide_BTO;
        private Button buttonOkGuide_BTO;
        private Button button1;
    }
}