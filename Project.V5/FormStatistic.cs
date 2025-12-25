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
            int totalRecords = _service.GetTotalRecords();
            int uniqueMechanics = _service.GetUniqueMechanics();
            int uniqueWorkshops = _service.GetUniqueWorkshops();
            string popularBrand = _service.GetMostPopularCarBrand();
            string popularWorkshop = _service.GetMostPopularWorkshop();
            int seniorMechanics = _service.GetSeniorMechanicsCount();

            // Заполнил таблицу
            var stats = new[]
            {
                new { Показатель = "Всего записей", Значение = totalRecords.ToString() },
                new { Показатель = "Уникальных механиков", Значение = uniqueMechanics.ToString() },
                new { Показатель = "Уникальных мастерских", Значение = uniqueWorkshops.ToString() },
                new { Показатель = "Популярная марка", Значение = popularBrand },
                new { Показатель = "Популярная мастерская", Значение = popularWorkshop },
                new { Показатель = "Механиков (Высший)", Значение = seniorMechanics.ToString() }
            };
            dataGridViewStats_BTO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStats_BTO.DataSource = stats;
            dataGridViewStats_BTO.Font = new Font("Segoe UI", 14f);

            // заполнил диаграмму
            chartStats_BTO.Series.Clear();
            var series = chartStats_BTO.Series.Add("Статистика");
            series.ChartType = SeriesChartType.Pie;
            series["PieLabelStyle"] = "Outside";
            series["PieLineColor"] = "Black";

            AddPieSlice(series, "Всего записей", totalRecords);
            AddPieSlice(series, "Механики", uniqueMechanics);
            AddPieSlice(series, "Мастерские", uniqueWorkshops);
            AddPieSlice(series, "Высший", seniorMechanics);
        }

        private void AddPieSlice(Series series, string label, int value)
        {
            var index = series.Points.AddXY(label, value);
            series.Points[index].Label = $"{label}\n{value}";
            series.Font = new Font("Segoe UI", 14f, FontStyle.Bold);
        }
    }
}
