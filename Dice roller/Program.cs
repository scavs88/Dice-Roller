using System;

namespace Dice_roller
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int choice = 0;
            int dice1=0;
            int dice2=0;
            bool again = true;
            Random rand = new Random();
            Console.WriteLine("Hello, welcome to the Dice Roller App!");
            while (true)
            {
                Console.WriteLine("How many sides should the dice have?");
                
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice < 1)
                    {
                        throw new Exception("Number was  too low");
                    } else
                    {
                        break;
                    }
                } catch (FormatException e)
                {
                    Console.WriteLine("That was not a number");
                } catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }           
            while (again)
            {
                dice1 = GetRandomNumber(rand, choice);
                dice2 = GetRandomNumber(rand, choice);

                Console.WriteLine($"Dice 1 is {dice1}");
                Console.WriteLine($"Dice 2 is {dice2}");

                if (choice == 6)
                {
                    if(dice1 ==1 && dice2 == 1)
                    {
                        Console.WriteLine("SNAKE EYES");
                    } if (dice1 ==1 && dice2 == 2)
                    {
                        Console.WriteLine("ACE DEUCE");
                    }if (dice1 == 2 && dice2 == 1)
                    {
                        Console.WriteLine("ACE DEUCE");
                    }if (dice1 + dice2 == 7 || dice1+dice2==11)
                    {
                        Console.WriteLine("WIN");
                    }if (dice1+dice2== 2 || dice1 + dice2 == 3 || dice1 + dice2 == 12)
                    {
                        Console.WriteLine("CRAPS");
                    }if (dice1 ==6 && dice2 == 6)
                    {
                        Console.WriteLine("BOXCAR");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Would you like to roll again? y/n");
                    string keepGoing = Console.ReadLine();
                    if (keepGoing == "n")
                    {
                        again = false;
                        break;
                    }
                    else if (keepGoing == "y")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }
        }



        static int GetRandomNumber(Random rand ,int choice)
        {

            int result = rand.Next(1, choice+1);
            return result;
        }




    }
}
