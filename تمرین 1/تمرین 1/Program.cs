using تمرین_1;
Book book1 = new("","","",0,0);
Console.Write("Please enter the price: ");
int usreprice = int.Parse(Console.ReadLine());
Console.Write("Pleae enter name of the book: ");
string nameofbook = Console.ReadLine();
Console.Write("Please enter the categoury of the book: ");
string categoury= Console.ReadLine();
Console.Write("Please enter the name of writer: ");
string writername= Console.ReadLine();
Console.Write("Please enter the year of publish: ");
int year = int.Parse(Console.ReadLine());
book1.SetandShow(nameofbook,categoury,writername,year,usreprice);
Console.WriteLine("*************************************************");
Console.Write("Do you want to increase Price (+/-)? ");
char useranswer = Convert.ToChar(Console.ReadLine());
if (useranswer=='+')
{
    Console.Write("Please enter the amount of increasing: ");
    int increasing = int.Parse(Console.ReadLine());
    book1.IncreasingPrice(increasing);
}
Console.Write("Do you want to know the price of this book (+/-)? ");
char un1 = Convert.ToChar(Console.ReadLine());
if (un1=='+')
{
    book1.ShowPrice();
}
Console.WriteLine("*************************************************");
Console.Write("Please enter the outher's name: ");
string outhersname = Console.ReadLine();
Console.Write("Please enter the number of books: ");
int num = Convert.ToInt32(Console.ReadLine());
Book[] numbers = new Book[num];
for (int i = 0; i < num; i++)
{
    Console.Write($"Please enter the name of the book {i + 1}: ");
    string writer = Console.ReadLine();
    Book temp = new Book(writer,"","",0,0);
    numbers[i] = temp;
}
Console.WriteLine($"The lest of {outhersname}'s books is: ");
for (int i = 0; i < num; i++)
{
    numbers[i].Varsname(numbers);
}
