using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTask
{
    internal class Phone:Product
    {
        public int RAM;
        public string Color="Black";
        public int Balance=0;


        public int balance
        {
            get { return Balance; }
            set
            {
                if (balance > 0)
                {
                    Balance = value;
                }
                else
                {
                    Console.WriteLine("Zeng edilmedi");
                }
            }
        }
        public Phone(string brandName, string modelName, decimal price, decimal cost, int count,int ram,string color,int balance):base(brandName, modelName, price, cost, count)
        {
            RAM = ram;
            Color = color;
            Balance = balance;
        }

        public void Seconds(int seconds)
        {
            
            if (Balance>=seconds/10)
            {
                Balance -= seconds/10;
                Console.WriteLine($"Balansiniz:{Balance}"); 
            }

            else
            {
                Console.WriteLine("Hesabinizda kifayet qeder mebleg yoxdur");
            }
        }
        public void Money(int money)
        {

            Balance += money;
            Console.WriteLine($"Artirmadan sonra Balansiniz:{Balance}");
        }
    }
}
