namespace R3BinderTools.Compilation.NSIS
{
    using System.ComponentModel;
    using System.Windows.Forms;

    [Description("Класс со свойствами генерации билд файла")]
    public class NsiBuild
    {
        public string IconPath { get; set; } // Полный путь к иконке
        public string BuildName { get; set; } // Имя билд файла

        public CheckBox PropetiesBuild { get; set; } // Установка свойств для билд файла
        public CheckBox CheckAdmin { get; set; } // Установка запуска билд файла от Админа
        public CheckBox CheckIcon { get; set; } // Установка иконки для билд файла
        public CheckBox CheckSuicide { get; set; } // Установка самоудаления билд файла после запуска
        public CheckBox CheckIsHideFiles { get; set; } // Установка скрытия файлов после распаковки
        public CheckBox CheckIsAdminRunFiles { get; set; } // Установка запуска файлов от имени Администратора
        public ListBox SpisokFiles { get; set; } // Список файлов добавленных в ListBox

        // Свойства файла
        public string VIProductName { get; set; } // Имя продукта
        public string VIProductVersion { get; set; } // Версия продукта
        public string VIDescriptionName { get; set; } // Описание файла
        public string VICompanyName { get; set; } // Имя компании
        public string VICopyright { get; set; } // Авторские права
        public string VIFileDescription { get; set; } // Описание файла
        public string VIFileVersion { get; set; } // Версия файла
        public string VILegalTrademarks { get; set; } // Товарный знак
    }
}