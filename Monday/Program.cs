using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Monday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankData> account=new List<BankData>()
            {
                new BankData("Lerato", "pass", 50, "1234"),
                new BankData("Vhugala", "pass", 5000, "23443")
            };
            WriteLine("Banking System");

            WriteLine("Username");
            string username = ReadLine();

            WriteLine("Password");
            string password = ReadLine();   

            BankData LoggedInUser = account.Find(a  => a.Username == username && a.Password == password);
        }
    }
}
