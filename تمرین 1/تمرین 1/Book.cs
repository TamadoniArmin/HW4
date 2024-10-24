namespace تمرین_1
{
    public class Book
    {
        public string NameoftheBook { get; set; }
        public string Categoury { get; set; }
        public string NameofWriter { get; set; }
        public int YearofPublish { get; set; }
        private int Price { get; set; }
        public Book(string Modelnamebook,string Modelcategoury,string Modelnamewriter,int Modelyear,int Modelprice)
        {
            NameoftheBook =Modelnamebook;
            Categoury =Modelcategoury;
            NameofWriter =Modelnamewriter;
            YearofPublish =Modelyear;
            Price = Modelprice;
        }
        public void SetandShow(string model1namebook, string model1categoury, string model1writername, int model1year,int Modelprice)
        {
            NameoftheBook = model1namebook;
            Categoury = model1categoury;
            NameofWriter = model1writername;
            YearofPublish = model1year;
            Price = Modelprice;
            Console.WriteLine($"This book's name is ({NameoftheBook}), categoury ({Categoury}), writer's name ({NameofWriter}), year of publish ({YearofPublish}),price is ({Price})");
        }
        public int IncreasingPrice(int x)
        {
            Price = Price + x;
            return Price;
        }
        public void ShowPrice()
        {
            Console.WriteLine($"The New Price of the Book is: {Price}");
        }
        public void Varsname(Book[]books)
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.NameoftheBook);
            }
        }
    }
}
