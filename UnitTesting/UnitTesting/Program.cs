using System;

namespace UnitTesting
{
    public class Program
    {
        static public decimal Balance = 1000.0m;
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("******** Welcome To Hanan Bank ATM ********");
            Console.WriteLine("******************************************");

            UserInterface();
        }
        public static void UserInterface()
        {
            try
            {
                int numOfOperation;

                do
                {
                    Console.WriteLine("******************************************");
                    Console.WriteLine("Kindly.... Insert The Number Of The Operation That you want to do:");
                    Console.WriteLine(" 1 To View Balance ");
                    Console.WriteLine(" 2 To Withdraw ");
                    Console.WriteLine(" 3 To Deposit ");
                    Console.WriteLine(" 0 To Exit ");

                    numOfOperation = Convert.ToInt32(Console.ReadLine());
                    switch (numOfOperation)
                    {

                        case 1:
                            decimal Balance = ViewBalance();
                            Console.WriteLine("Your Balance = " + Balance);
                            continue;

                        case 2:

                            Console.WriteLine("Kindly...Insert The amount you want to Withdraw from the balance");
                            decimal subtract = Convert.ToDecimal(Console.ReadLine());
                            Withdraw(subtract);
                            continue;

                        case 3:
                            Console.WriteLine("Kindly...Insert The amount you want to Add to the balance ");
                            decimal add = Convert.ToDecimal(Console.ReadLine());
                            Deposit(add);


                            continue;

                    }
                }
                while (numOfOperation != 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("***************** The program Finish *****************");
            }

        }
        public static decimal ViewBalance()
        {
            return Balance;
        }
        public static decimal Withdraw(decimal subtract)
        {
            if (subtract > Balance)
            {
                Console.WriteLine("The amount should be more than or equal your balance " + "( " + Balance + " )");
                return Balance;
            }
            else if (subtract < 0)
            {
                Console.WriteLine("Cannot withdraw amount less than 0.00.");
                return Balance;
            }
            else
            {
                Balance = Balance - subtract;
                Console.WriteLine("Your new balance is " + "(" + Balance + ")");
                return Balance;
            }

        }
        public static decimal Deposit(decimal add)

        {
            if (add < 0)
            {
                Console.WriteLine("Cannot deposit a negative value.");
                return Balance;
            }
            else
            {
                Balance = Balance + add;
                Console.WriteLine($"Your new balance is {Balance}");
                return Balance;
            }


        }
    }
}
