using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Group1Library.Models
{
    public class Book : PageModel
    {
        public string Title;
        public string Author;
        public string ISBN;
        public string Date;
        public bool IsAtWaterloo = false;

        public Book(string title, string author, string isbn, string date)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Date = date;
        }

        public string BookToString()
        {
            return Title + " - " + Author + " - " + ISBN + " - " + Date;
        }
    }
}
