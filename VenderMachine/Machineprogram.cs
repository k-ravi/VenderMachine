using System;

namespace VenderMachine
{
    public class Machineprogram
    {
        private const int COST_OF_DRINK = 100;

        public int Deposit { get; set; }
        public int DrinkCost { get; set; }

        public void ChooseDrink()
        {
            Console.WriteLine("Product List");
            Console.WriteLine("1. cola for 100 cents");
            Console.WriteLine("2. ships for 50 cents");
            Console.WriteLine("3. candy for 65 cents");
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Select Product");
                if (int.TryParse(Console.ReadLine(), out int selectedItem))
                {
                    isValid = ValidateDrinkSelection(selectedItem);
                }
                else
                {
                    Console.WriteLine("Invalid Product");
                }
            }
        }

        public bool ValidateDrinkSelection(int selectedItem)
        {
            bool isValid = false;
            switch ((Items)selectedItem)
            {
                case Items.Cola:
                    Console.WriteLine("Thank you for choosing Cola");
                    isValid = true;
                    DrinkCost = COST_OF_DRINK;
                    ReturnChange();
                    break;
                case Items.Chips:
                    Console.WriteLine("Thank you for choosing Chips");
                    isValid = true;
                    DrinkCost = 50;
                    ReturnChange();
                    break;
                case Items.Candy:
                    Console.WriteLine("Thank you for choosing Candy");
                    isValid = true;
                    DrinkCost = 65;
                    ReturnChange();
                    break;
                default:
                    Console.WriteLine("Invalid Product");
                    break;
            }

            return isValid;
        }

        public void ReturnChange()
        {
            if (Deposit > DrinkCost)
            {
                Console.WriteLine("Your change {0:C}", Deposit - DrinkCost);
            }
        }
        public bool CheckDeposit()
        {
            return Deposit >= COST_OF_DRINK;
        }
        public void InsertCoins(int money)
        {

            switch ((Coins)money)
            {
                case Coins.nickels:
                    Deposit += 5;
                    break;
                case Coins.dimes:
                    Deposit += 10;
                    break;
                case Coins.quaters:
                    Deposit += 25;
                    break;
                case Coins.pennis:
                    Deposit += COST_OF_DRINK;
                    break;
                default:
                    Console.WriteLine("Invalid Coin");
                    break;
            }
            Console.WriteLine("Your Balance is {0:c}", Deposit);

        }
    }


}

