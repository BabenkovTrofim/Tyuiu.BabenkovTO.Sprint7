using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V5
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
            var timer = new System.Windows.Forms.Timer { Interval = 2500 };
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                this.Close();
            };
            timer.Start();
        }
    }
}
