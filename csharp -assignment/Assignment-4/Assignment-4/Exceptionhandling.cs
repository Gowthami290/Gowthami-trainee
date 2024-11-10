using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Insufficient_Balance_Exception : ApplicationException
    {
        public Insufficient_Balance_Exception(string msg) : base(msg)
        {

        }
    }
    class Exceptionhandling
    {
        public int amount;
        public int balance;
        public string transaction_type;
        public Exceptionhandling(int amo, int bal, string trans_type)
        {
            amount = amo;
            balance = bal;
            transaction_type = trans_type;

        }
        public void Deposit(int amount, int balance)
        {
            balance = balance + amount;
            Console.WriteLine("The balance after depositing amount {0} is {1}", amount, balance);
        }
        public void WithDraw(int amount, int balance)
        {
            try
            {
                if (amount > balance)
                {
                    throw (new Insufficient_Balance_Exception("Customer does not have sufficient balance"));
                }
                else
                {
                    balance = balance - amount;
                    Console.WriteLine("The balance after WithDrawing amount {0} is {1}", amount, balance);
                }
            }
            catch (Insufficient_Balance_Exception insufficient_balance)
            {
                Console.WriteLine("Error :" + insufficient_balance.Message);
            }
        }
        public void Update_Balance(string transac_type)
        {
            if (transac_type == "d" || transac_type == "D")
            {
                Deposit(amount, balance);
            }
            else if (transac_type == "W" || transac_type == "W")
            {
                WithDraw(amount, balance);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the balance");
            int bal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the amount");
            int amo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the transaction type");
            string trans_type = Console.ReadLine();
            Exceptionhandling obj = new Exceptionhandling(amo, bal, trans_type);
            obj.Update_Balance(trans_type);
            Console.Read();
        }
    }
}