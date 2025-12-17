namespace Tyuiu.BabenkovTO.Sprint7.Project.V5.Lib
{
    public class DataService
    {
        private readonly string _filePath;

        public DataService(string filePath)
        {
            _filePath = filePath;
            EnsureFileExists();
        }

        private void EnsureFileExists()
        {
            if (!File.Exists(_filePath))
                File.WriteAllText(_filePath, "Номер водительских прав,ФИО владельца,Телефон владельца," +
                                             "ФИО механика,Квалификация," +
                                             "Номер авто,Марка,Цвет," +
                                             "Название мастерской,Телефон мастерской\n");
        }

        public List<RepairRecord> LoadRecords()
        {
            var records = new List<RepairRecord>();
            var lines = File.ReadAllLines(_filePath);
            for (int i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                if (parts.Length != 10) continue;

                records.Add(new RepairRecord
                {
                    DriversLicenseNumber = parts[0],
                    OwnerFullName = parts[1],
                    OwnerPhone = parts[2],
                    MechanicFullName = parts[3],
                    MechanicQualification = parts[4],
                    CarNumber = parts[5],
                    CarBrand = parts[6],
                    CarColor = parts[7],
                    WorkshopName = parts[8],
                    WorkshopPhone = parts[9]
                });
            }
            return records;
        }

        public void SaveRecords(List<RepairRecord> records)
        {
            var header = "Номер водительских прав,ФИО владельца,Телефон владельца," +
                         "ФИО механика,Квалификация," +
                         "Номер авто,Марка,Цвет," +
                         "Название мастерской,Телефон мастерской";

            var lines = new List<string> { header };
            lines.AddRange(records.Select(r => r.ToString()));
            File.WriteAllLines(_filePath, lines);
        }

        public void AddRecord(RepairRecord record)
        {
            var records = LoadRecords();
            records.Add(record);
            SaveRecords(records);
        }

        public void DeleteRecord(int index)
        {
            var records = LoadRecords();
            if (index >= 0 && index < records.Count)
            {
                records.RemoveAt(index);
                SaveRecords(records);
            }
        }

        public List<RepairRecord> SearchByOwnerName(string query)
        {
            return LoadRecords().Where(r => r.OwnerFullName.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<RepairRecord> SearchByCarBrand(string query)
        {
            return LoadRecords().Where(r => r.CarBrand.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public int GetTotalRecords() => LoadRecords().Count;
        public int GetUniqueWorkshops() => LoadRecords().Select(r => r.WorkshopName).Distinct().Count();
        public int GetUniqueMechanics() => LoadRecords().Select(r => r.MechanicFullName).Distinct().Count();
    }
}
