using تمرین_2;

BankAccount User = new BankAccount(3410, "Armin Tamadoni","armintm1234");
bool checkpass = true;
while (checkpass)
{
    Console.Write("Please enter your Password: ");
    string enteredpassword = Console.ReadLine();
    checkpass= User.CheckPass(enteredpassword);
    if (!checkpass)
    {
        break;
    }
    Console.Write("Do you want to add some aoumt of nomey (+/-) ?");
    char usreanswer1 = Convert.ToChar(Console.ReadLine());
    if (usreanswer1 == '+')
    {
        Console.Write("Please enter the amount that you want to add: ");
        int incresingamount =int.Parse(Console.ReadLine());
        User.PlusAmount(incresingamount);
        Console.WriteLine("Do you want to konw your account's balance? ");
        char un1 = Convert.ToChar(Console.ReadLine());
        if (un1=='+')
        {
            User.ShowBalace();
        }
        Console.WriteLine("*******************************************");
    }
    Console.Write("Do you want to decrease some aoumt of nomey (+/-) ? ");
    char usreanswer2 = Convert.ToChar(Console.ReadLine());
    if (usreanswer2 == '+')
    {
        Console.Write("Please enter the amount that you want to decrease: ");
        int decreasingamount = int.Parse(Console.ReadLine());
        User.Rediuseamount(decreasingamount);
        Console.WriteLine("Do you want to konw your account's balance? ");
        char un1 = Convert.ToChar(Console.ReadLine());
        if (un1 == '+')
        {
            User.ShowBalace();
        }
        Console.WriteLine("*******************************************");
    }
    else
    {
        Console.WriteLine("Do you want to konw your account's balance? ");
        char un2 = Convert.ToChar(Console.ReadLine());
        if (un2 == '+')
        {
            User.ShowBalace();
            Console.WriteLine("*******************************************");
        }
    }
    Console.WriteLine("Do you want to do something else? ");
    char exteawork = Convert.ToChar(Console.ReadLine());
    if (exteawork=='-')
    {
        break;
    }
}
Console.WriteLine("***Goodbay***");
