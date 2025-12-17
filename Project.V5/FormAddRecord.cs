using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BabenkovTO.Sprint7.Project.V5.Lib;

namespace Project.V5
{
    public partial class FormAddRecord : Form
    {
        public RepairRecord CreatedRecord_BTO { get; private set; }

        public FormAddRecord()
        {
            InitializeComponent();
        }

        private void buttonOK_BTO_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxOwnerName_BTO.Text) ||
                string.IsNullOrWhiteSpace(textBoxCarBrand_BTO.Text))
            {
                MessageBox.Show("Заполните обязательные поля: ФИО владельца и марку авто.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CreatedRecord_BTO = new RepairRecord
            {
                DriversLicenseNumber = textBoxLicense_BTO.Text,
                OwnerFullName = textBoxOwnerName_BTO.Text,
                OwnerPhone = textBoxOwnerPhone_BTO.Text,
                MechanicFullName = textBoxMechanicName_BTO.Text,
                MechanicQualification = textBoxMechanicQual_BTO.Text,
                CarNumber = textBoxCarNumber_BTO.Text,
                CarBrand = textBoxCarBrand_BTO.Text,
                CarColor = textBoxCarColor_BTO.Text,
                WorkshopName = textBoxWorkshopName_BTO.Text,
                WorkshopPhone = textBoxWorkshopPhone_BTO.Text
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_BTO_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void labelCarColor_BTO_Click(object sender, EventArgs e)
        {

        }
    }
}
