namespace BooksLibrary
{
    public interface ILiterature
    {       
        string title { get; set; }       
        string authorLastname { get; set; }
        int pagesTotal { get; set; }
        int pagesReaded { get; set; }
        string tag { get; set; }
        string fileExtension { get; set; }
        string progress { get; }
        string pathToBook { get; set; }       
        string commentary { get; set; }

        void Save(System.IO.TextWriter textOut);
        bool Save(string filename);  
    }
}
