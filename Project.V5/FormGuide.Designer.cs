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
            SuspendLayout();
            // 
            // textBoxGuide_BTO
            // 
            textBoxGuide_BTO.Dock = DockStyle.Fill;
            textBoxGuide_BTO.Font = new Font("Consolas", 12F);
            textBoxGuide_BTO.Location = new Point(0, 0);
            textBoxGuide_BTO.Margin = new Padding(4, 5, 4, 5);
            textBoxGuide_BTO.Multiline = true;
            textBoxGuide_BTO.Name = "textBoxGuide_BTO";
            textBoxGuide_BTO.ReadOnly = true;
            textBoxGuide_BTO.ScrollBars = ScrollBars.Both;
            textBoxGuide_BTO.Size = new Size(794, 301);
            textBoxGuide_BTO.TabIndex = 0;
            textBoxGuide_BTO.Text = resources.GetString("textBoxGuide_BTO.Text");
            textBoxGuide_BTO.WordWrap = false;
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 301);
            Controls.Add(textBoxGuide_BTO);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormGuide";
            Text = "Руководство пользователя — Авторемонтные мастерские";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxGuide_BTO;
    }
}