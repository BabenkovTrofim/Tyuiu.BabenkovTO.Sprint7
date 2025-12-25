using Tyuiu.BabenkovTO.Sprint7.Project.V5.Lib;

namespace Project.V5
{
    public partial class FormMain : Form
    {
        private DataService _dataService;
        private string _currentFilePath = "repairs_BTO.csv";

        public FormMain()
        {
            InitializeComponent();
            _dataService = new DataService(_currentFilePath);
            LoadDataGrid_BTO();

        }


        // загружаю данные в таблицу
        private void LoadDataGrid_BTO()
        {
            dataGridViewMain_BTO.DataSource = _dataService.LoadRecords(); // поместил список(List<RepairRecord>) в таблицу
            dataGridViewMain_BTO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonAdd_BTO_Click(object sender, EventArgs e)
        {
            var form = new FormAddRecord(); // открыл форму для ввода данных
            if (form.ShowDialog() == DialogResult.OK) // если пользователь нвжал ОК, то ..
            {
                _dataService.AddRecord(form.CreatedRecord_BTO);
                LoadDataGrid_BTO(); // обновил таблицу в интерфейсе
            }
        }

        private void buttonDelete_BTO_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain_BTO.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rowIndex = dataGridViewMain_BTO.SelectedRows[0].Index;
            _dataService.DeleteRecord(rowIndex); // удалил выбранную строку по индексу
            LoadDataGrid_BTO();
        }

        private void buttonSearchOwner_BTO_Click(object sender, EventArgs e)
        {
            var query = textBoxSearchOwner_BTO.Text.Trim();
            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Введите ФИО владельца для поиска.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadDataGrid_BTO(); // Показываем все записи
                return;
            }
            var results = _dataService.SearchByOwnerName(query);
            dataGridViewMain_BTO.DataSource = results;

            if (results.Count == 0)
                MessageBox.Show("Записи не найдены.", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonSearchBrand_BTO_Click(object sender, EventArgs e)
        {
            var query = textBoxSearchBrand_BTO.Text.Trim();
            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Введите марку автомобиля для поиска.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadDataGrid_BTO();
                return;
            }
            var results = _dataService.SearchByCarBrand(query);
            dataGridViewMain_BTO.DataSource = results;

            if (results.Count == 0)
                MessageBox.Show("Записи не найдены.", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRefresh_BTO_Click(object sender, EventArgs e) // обновил таблицу
        {
            LoadDataGrid_BTO();
            textBoxSearchOwner_BTO.Clear();
            textBoxSearchBrand_BTO.Clear();
        }

        private void buttonOpenFile_BTO_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "CSV Files|*.csv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _currentFilePath = ofd.FileName;
                    _dataService = new DataService(_currentFilePath);
                    LoadDataGrid_BTO();
                }
            }
        }

        private void buttonSaveFile_BTO_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog { Filter = "CSV Files|*.csv", FileName = "exportFile_BTO.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(_currentFilePath, sfd.FileName, true);
                    MessageBox.Show("Файл успешно сохранён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // MenuStrip(файл, отчеты, справка)
        private void выходToolStripMenuItem_BTO_Click(object sender, EventArgs e) => Application.Exit();
        private void оПрограммеToolStripMenuItem_BTO_Click(object sender, EventArgs e) => new FormAbout().ShowDialog();
        private void руководствоПользователяToolStripMenuItem_BTO_Click(object sender, EventArgs e) => new FormGuide().ShowDialog();
        private void статистикаToolStripMenuItem_BTO_Click(object sender, EventArgs e) => new FormStatistic(_dataService).ShowDialog();

        private void файлToolStripMenuItem_BTO_Click(object sender, EventArgs e)
        {

        }

        private void отчётыToolStripMenuItem_BTO_Click(object sender, EventArgs e)
        {

        }
    }
}
