namespace R3BinderTools.Compilation.CodeDOM
{
    using System.ComponentModel;
    using System.Windows.Forms;

    [Description("Класс свойств для генерации билд файла под CodeDOM компилятор")]
    public class BuildDom
    {
        // Свойства файла
        public string AssTitle { get; set; } // Заголовок 
        public string AssDescription { get; set; } // Дескриптор
        public string AssCompany { get; set; } // Имя компании
        public string AssProduct { get; set; } // Имя продукта
        public string AssCopyright { get; set; } // Копирайт
        public string AssVersion { get; set; } // Версия
        public string AssFileVersion { get; set; } // Версия файла
        public string GuidBox { get; set; } // GUID
        public string BoxIconPath { get; set; } // Иконка для билд файла
        public CheckBox IconCheckBox { get; set; } // Бокс установки иконки
        public CheckBox RunTime { get; set; } // Бокс установки задержки запуска билд файла
        public CheckBox SuicideBox { get; set; } // Бокс установки самоудаления билд файла
        public CheckBox AdminBuildBox { get; set; } // Бокс установки запуска билд файла от имени Администратора
        public CheckBox AdminFilesBox { get; set; } // Бокс установки запуска файлов от имени Администратора
        public CheckBox HideResources { get; set; } // Бокс установки скрытия файлов после распаковки
        public Label LMessage { get; set; } // Для вывода сообщения пользователю
    }
}