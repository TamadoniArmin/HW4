namespace تمرین_2
{
    internal class BankAccount
    {
        public string UserName { get; set; }
        //public string NeameoftheBank { get; set; }
        public int AccountNumber { get; set; }
        private string PassWord { get; set; }
        private int UserBalance { get; set; } = 100;
        //private bool CheckPassWord { get; set; } = true;
        public BankAccount(int Modelaccountnumber, string Modelusrename, string Modelpassword)
        {
            AccountNumber = Modelaccountnumber;
            UserName = Modelusrename;
            PassWord = Modelpassword;
        }
        public bool CheckPass(string password)
        {
            if (password!=PassWord)
            {
                Console.WriteLine("The password that you have entered is not correct so you don't have access to this account.");
                return false;
            }
            return true;

        }
        public void PlusAmount (int newamount)
        {
                UserBalance += newamount;
        }
        public void Rediuseamount(int newamount)
        {
            if (UserBalance-newamount>0)
            {
                UserBalance -= newamount;
            }
            else
                Console.WriteLine("You don't have enough money for decreasing this aomount.");

        }
        public void ShowBalace()
        {
            Console.WriteLine($"Your account Balace is: {UserBalance}");
        }

       
    }
}
