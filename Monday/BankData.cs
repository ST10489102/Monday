using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Console;

namespace Monday
{
    internal class BankData
    {
        private string v;
        private string v1;
        private int v2;
        private string v3;

        public string Username { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
        public decimal AccountNumber { get; set; }

        //
        BankData(string username, string password, decimal balance, decimal accountnumber)
        {
            Username = username;
            Password = password;
            Balance = balance;
            AccountNumber = accountnumber;
        }

        public BankData(string v)
        {
            this.v = v;
        }

        public BankData(string v, string v1, int v2, string v3) : this(v)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                WriteLine("Deposit successul :"); ;
                WriteLine("New Balance " + this.Balance);
            }
            else
            {
                WriteLine("Invalid Amount");
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                WriteLine("You are withdrawing " + amount);
                WriteLine("Withdrawal Succesful");
                WriteLine("New Balance : " + this.Balance);
            }
            else
            {
                WriteLine(" too tufffff");
            }
        }
        public void CheckBalance(decimal amount)

        {
            WriteLine(" The Balance is :R" + this.Balance);
        } 
        public void Print_Details()
        {
            WriteLine("-----Account Details-----");
            WriteLine("Account Holder:" + this.Username);
            WriteLine("Account Number:" + this.AccountNumber);
            WriteLine("Balance :R" + this.Balance);
            
        }
    }
}
    
    

