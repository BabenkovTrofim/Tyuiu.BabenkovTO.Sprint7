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
    public partial class FormGuide : Form
    {
        public FormGuide()
        {
            InitializeComponent();
            textBoxGuide_BTO.Text = @"РУКОВОДСТВО ПОЛЬЗОВАТЕЛЯ

1. Открытие файла: меню 'Файл → Открыть' или кнопка на панели.
2. Добавление записи: нажмите 'Добавить' → заполните форму.
3. Удаление: выделите строку → 'Удалить'.
4. Поиск:
   - По владельцу: введите ФИО → 'Поиск (владелец)'.
   - По марке: введите марку → 'Поиск (марка)'.
5. Сохранение: 'Файл → Сохранить как...'.
6. Статистика: 'Отчёты → Статистика' (таблица + диаграмма).";
        }
    }
}
