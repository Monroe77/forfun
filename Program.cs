using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello! Welcome to my the Change Machine \n");
            Console.WriteLine("Please Enter Amount to be Paid\n$");
            double bill = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Amount Due is {0}\n", bill);
            Console.WriteLine("Now please enter amount given!\n$");
            double payment = double.Parse(Console.ReadLine());
            double change = payment - bill;
            Console.Write("Your change amount is: {0} \n", change);
            double changes = change * 100;


            double hundred = (int)(changes / 10000);
            double fifty = (int)(changes % 10000) / 5000;
            double twenty = (int)((changes % 10000) % 5000) / 2000;
            double ten = (int)(((changes % 10000) % 5000) % 2000) / 1000;
            double five = (int)((((changes % 10000) % 5000) % 2000) % 1000) / 500;
            double one = (int)(((((changes % 10000) % 5000) % 2000) % 1000) % 500) / 100;
            double quarter = (int)((((((changes % 10000) % 5000) % 2000) % 1000) % 500) % 100) / 25;
            double dime = (int)(((((((changes % 10000) % 5000) % 2000) % 1000) % 500) % 100) % 25) / 10;
            double nickle = (int)((((((((changes % 10000) % 5000) % 2000) % 1000) % 500) % 100) % 25) % 10) / 5;
            double pennie = (int)(((((((((changes % 10000) % 5000) % 2000) % 1000) % 500) % 100) % 25) % 10) % 5) / 1;

            if (hundred > 0)
            {
                Console.WriteLine("{0} Hundred Dollar Bills\n", hundred);
            }
            else
            {
                Console.Write("");
            }
            if (fifty > 0)
            {
                Console.WriteLine("{0} Fifty Dollar Bills\n", fifty);
            }
            else
            {
                Console.Write("");
            }
            if (twenty > 0)
            {
                Console.WriteLine("{0} Twenty Dollar Bills\n", twenty);
            }
            else
            {
                Console.Write("");
            }
            if (ten > 0)
            {
                Console.WriteLine("{0} Ten Dollar Bills\n", ten);
            }
            else
            {
                Console.Write("");
            }
            if (five > 0)
            {
                Console.WriteLine("{0} Five Dollar Bills\n", five);
            }
            else
            {
                Console.Write("");
            }
            if (one > 0)
            {
                Console.WriteLine("{0} One Dollar Bills\n", one);
            }
            else
            {
                Console.Write("");
            }
            if (quarter > 0)
            {
                Console.WriteLine("{0} Quarters\n", quarter);
            }
            else
            {
                Console.Write("");
            }
            if (dime > 0)
            {
                Console.WriteLine("{0} Dimes\n", dime);
            }
            else
            {
                Console.Write("");
            }
            if (nickle > 0)
            {
                Console.WriteLine("{0} Nickles\n", nickle);
            }
            else
            {
                Console.Write("");
            }
            if (pennie > 0)
            {
                Console.WriteLine("{0} Pennies\n", pennie);
            }
            else
            {
                Console.Write("");
            }

            //Console.WriteLine("Your change is : \n{0} Hundred Dollar Bills" +
            //   "\n{1} Fifty Dollar Bills\n{2} Twenty Dollar Bills \n{3} Ten Dollar Bills \n{4} Five Dollar Bills" +
            //   "\n{5} One Dollar Bills \n{6} Quarters \n{7} Dimes \n{8} Nickles \n{9} pennies", hundred, fifty, twenty, ten, five, one, quarter, dime, nickle, pennie);

        }
    }
}
