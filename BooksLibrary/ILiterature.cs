namespace BooksLibrary
{
    public interface ILiterature
    {       
        string title { get; set; }       
        string authorLastname { get; set; }
        int pagesTotal { get; set; }
        int pagesReaded { get; set; }
        string progress { get; }      
        string commentary { get; set; }
        string status { get; set; }

        void Save(System.IO.TextWriter textOut);
        bool Save(string filename);  
    }
}
