using System;

namespace VenderMachine
{
    public class Program
    {
        public static void Main()
        {
            Machineprogram machineprogram = new Machineprogram();
            while (!machineprogram.CheckDeposit())
            {
                Console.WriteLine("enter coins (5,10,25,100)");
                if (int.TryParse(Console.ReadLine(), out int insertedCoin))
                {
                    machineprogram.InsertCoins(insertedCoin);
                }
                else
                {
                    Console.WriteLine("Invalid Coin");
                }
            }
            machineprogram.ChooseDrink();
            //Console.Read();
        }
    }
}

