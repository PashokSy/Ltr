namespace BooksLibrary
{
    public interface ILiterature
    {
        /// <summary>
        /// Название
        /// </summary>
        string title { get; set; }

        /// <summary>
        /// Имя автора
        /// </summary>
        string authorName { get; set; }

        /// <summary>
        /// Фамилия автора
        /// </summary>
        string authorLastname { get; set; }

        /// <summary>
        /// Всего страниц
        /// </summary>
        int pagesTotal { get; set; }

        /// <summary>
        /// Прочитано страниц
        /// </summary>
        int pagesReaded { get; set; }

        /// <summary>
        /// Метка
        /// </summary>
        string tag { get; set; }

        /// <summary>
        /// Расширение файла
        /// </summary>
        string fileExtension { get; set; }

        /// <summary>
        /// Прогресс чтения книги в процентах
        /// </summary>
        string progress { get; set; }

        /// <summary>
        /// Метод сохраняющий конктерный экземпляр
        /// </summary>
        /// <param name="textOut">Текстовый поток</param>
        void Save(System.IO.TextWriter textOut);

        /// <summary>
        /// Метод обеспечивающий поток данных в файл
        /// </summary>
        /// <param name="filename">Имя файла для сохранения</param>
        /// <returns>Удачно ли сохранение</returns>
        bool Save(string filename);  
    }
}
