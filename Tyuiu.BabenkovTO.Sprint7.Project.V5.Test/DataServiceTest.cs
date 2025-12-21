using Tyuiu.BabenkovTO.Sprint7.Project.V5.Lib;
namespace Tyuiu.BabenkovTO.Sprint7.Project.V5.Test
{
        [TestClass]
        public class DataServiceTest
        {
            private const string TestFile = "test_data_BTO.csv";

            [TestInitialize]
            public void Setup()
            {
                if (File.Exists(TestFile))
                    File.Delete(TestFile);
            }

            [TestMethod]
            public void AddAndLoadRecordTest()
            {
                var service = new DataService(TestFile);// временный файл

                var record = new RepairRecord  //создал тестовую запись
                {
                    DriversLicenseNumber = "123456",
                    OwnerFullName = "Иванов Иван Иванович",
                    OwnerPhone = "+79001234567",
                    MechanicFullName = "Петров Петр Петрович",
                    MechanicQualification = "Высший",
                    CarNumber = "А123БВ",
                    CarBrand = "Toyota",
                    CarColor = "Синий",
                    WorkshopName = "Авто-Сервис БТО",
                    WorkshopPhone = "+74951112233"
                };

                service.AddRecord(record); //добавил тестовую запись в файл
                var loaded = service.LoadRecords();// загрузил все записи в массив

                Assert.AreEqual(1, loaded.Count);
                Assert.AreEqual("Toyota", loaded[0].CarBrand);
            }

            [TestCleanup]
            public void Cleanup()
            {
                if (File.Exists(TestFile))
                    File.Delete(TestFile);
            }
        }
    }

