namespace Group1Library.Models
{
    public class Accounts
    {
        public List<Book> LoanList = new List<Book>();

        public Accounts()
        {
            LoanList = new List<Book>();
        }
    }
}
