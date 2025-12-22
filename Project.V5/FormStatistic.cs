using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.BabenkovTO.Sprint7.Project.V5.Lib;

namespace Project.V5
{
    public partial class FormStatistic : Form
    {
        private readonly DataService _service;

        public FormStatistic(DataService service)
        {
            InitializeComponent();
            _service = service;
            LoadData_BTO();
            
        }

        private void LoadData_BTO()
        {
            var total = _service.GetTotalRecords();
            var workshops = _service.GetUniqueWorkshops();
            var mechanics = _service.GetUniqueMechanics();

            dataGridViewStats_BTO.DataSource = new[]
            {
            new { Показатель = "Всего записей", Значение = total },
            new { Показатель = "Мастерских", Значение = workshops },
            new { Показатель = "Механиков", Значение = mechanics }
        };

            chartStats_BTO.Series.Clear();
            var series = chartStats_BTO.Series.Add("Статистика");
            series.ChartType = SeriesChartType.Pie;
            series["PieLabelStyle"] = "Disabled";

            int totalSum = total + workshops + mechanics;

            var point1 = series.Points.AddXY("Записи", total);
            var point2 = series.Points.AddXY("Мастерские", workshops);
            var point3 = series.Points.AddXY("Механики", mechanics);
            
        }
    }
}
