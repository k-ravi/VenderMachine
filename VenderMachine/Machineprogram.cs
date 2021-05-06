using System;

namespace VenderMachine
{
    public class Machineprogram
    {

        decimal drinkCost = 0;
        decimal deposit = 0;
        //public int Deposit { get; set; }
        //public int DrinkCost { get; set; }

        public void ChooseDrink()
        {
            Console.WriteLine("Product List");
            Console.WriteLine("1. Cost for cola is $100.00 ");
            Console.WriteLine("2. Cost for ships is $50.00 ");
            Console.WriteLine("3. Cost for candy is $65.00 ");
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
                    isValid = true;
                    drinkCost = 100;
                    Console.WriteLine("You have choosen Cola and cost is {0:c}", drinkCost);
                    break;
                case Items.Chips:
                    isValid = true;
                    drinkCost = 50;
                    Console.WriteLine("You have choosen Chips and cost is {0:c}", drinkCost);
                    break;
                case Items.Candy:
                    isValid = true;
                    drinkCost = 65;
                    Console.WriteLine("You have choosen Candy and cost is {0:c}", drinkCost);
                    break;
                default:
                    Console.WriteLine("Invalid Product");
                    break;
            }

            return isValid;
        }

        public bool ReturnChange()
        {
            if (deposit > drinkCost)
            {
                Console.WriteLine("Your change {0:C}", deposit - drinkCost);
                deposit = 0;
                drinkCost = 0;
                return true; ;
            }
            else
            {
                return false;
            }
        }
        public bool CheckDeposit()
        {
            return deposit >= drinkCost;
        }
        public void InsertCoins(int money)
        {

            switch ((Coins)money)
            {
                case Coins.nickels:
                    deposit += 5;
                    break;
                case Coins.dimes:
                    deposit += 10;
                    break;
                case Coins.quaters:
                    deposit += 25;
                    break;
                case Coins.pennis:
                    deposit += 100;
                    break;
                default:
                    Console.WriteLine("Invalid Coin");
                    break;
            }
            if (CheckDeposit())
            {
                Console.WriteLine("Thanks for purcharing drink");
            }
            else
            {
                Console.WriteLine("Your balance is {0:c} and required {1:c} more to purchase ", deposit, (drinkCost - deposit));
            }

        }
    }


}

