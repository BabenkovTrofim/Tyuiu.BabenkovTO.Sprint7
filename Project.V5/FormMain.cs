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

        
        private void LoadDataGrid_BTO()
        {
            dataGridViewMain_BTO.DataSource = _dataService.LoadRecords();
            dataGridViewMain_BTO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonAdd_BTO_Click(object sender, EventArgs e)
        {
            var form = new FormAddRecord();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _dataService.AddRecord(form.CreatedRecord_BTO);
                LoadDataGrid_BTO();
            }
        }

        private void buttonDelete_BTO_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain_BTO.SelectedRows.Count == 0)
            {
                MessageBox.Show("Âûáåðèòå ñòðîêó äëÿ óäàëåíèÿ.", "Èíôîðìàöèÿ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rowIndex = dataGridViewMain_BTO.SelectedRows[0].Index;
            _dataService.DeleteRecord(rowIndex);
            LoadDataGrid_BTO();
        }

        private void buttonSearchOwner_BTO_Click(object sender, EventArgs e)
        {
            var query = textBoxSearchOwner_BTO.Text.Trim();
            if (!string.IsNullOrEmpty(query))
            {
                dataGridViewMain_BTO.DataSource = _dataService.SearchByOwnerName(query);
            }
            else
            {
                LoadDataGrid_BTO();
            }
        }

        private void buttonSearchBrand_BTO_Click(object sender, EventArgs e)
        {
            var query = textBoxSearchBrand_BTO.Text.Trim();
            if (!string.IsNullOrEmpty(query))
            {
                dataGridViewMain_BTO.DataSource = _dataService.SearchByCarBrand(query);
            }
            else
            {
                LoadDataGrid_BTO();
            }
        }

        private void buttonRefresh_BTO_Click(object sender, EventArgs e)
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
            using (var sfd = new SaveFileDialog { Filter = "CSV Files|*.csv", FileName = "repairs_export_BTO.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(_currentFilePath, sfd.FileName, true);
                    MessageBox.Show("Ôàéë óñïåøíî ñîõðàí¸í!", "Óñïåõ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // MenuStrip
        private void âûõîäToolStripMenuItem_BTO_Click(object sender, EventArgs e) => Application.Exit();
        private void îÏðîãðàììåToolStripMenuItem_BTO_Click(object sender, EventArgs e) => new FormAbout().ShowDialog();
        private void ðóêîâîäñòâîÏîëüçîâàòåëÿToolStripMenuItem_BTO_Click(object sender, EventArgs e) => new FormGuide().ShowDialog();
        private void ñòàòèñòèêàToolStripMenuItem_BTO_Click(object sender, EventArgs e) => new FormStatistic(_dataService).ShowDialog();
    }
}
