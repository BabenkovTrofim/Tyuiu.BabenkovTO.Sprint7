using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.BabenkovTO.Sprint7.Project.V5.Lib
{
    public class RepairRecord
    {
        [DisplayName("Номер прав")]
        public string DriversLicenseNumber { get; set; }

        [DisplayName("ФИО владельца")]
        public string OwnerFullName { get; set; }

        [DisplayName("Телефон владельца")]
        public string OwnerPhone { get; set; }




        [DisplayName("ФИО механика")]
        public string MechanicFullName { get; set; }

        [DisplayName("Квалификация")]
        public string MechanicQualification { get; set; }




        [DisplayName("Номер авто")]
        public string CarNumber { get; set; }

        [DisplayName("Марка")]
        public string CarBrand { get; set; }

        [DisplayName("Цвет")]
        public string CarColor { get; set; }





        [DisplayName("Мастерская")]
        public string WorkshopName { get; set; }

        [DisplayName("Телефон мастерской")]
        public string WorkshopPhone { get; set; }

        public override string ToString() =>
            $"{DriversLicenseNumber},{OwnerFullName},{OwnerPhone}," +
            $"{MechanicFullName},{MechanicQualification}," +
            $"{CarNumber},{CarBrand},{CarColor}," +
            $"{WorkshopName},{WorkshopPhone}";
    }
}
