using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            //local variable
            int rollDice, playerPos = 0;
            int count = 0;

            //To generate random number
            Random random = new Random();
            //List to check options
            var list = new List<string> { "No Play", "Ladder", "Snake" };

            //Conditions for user options
            rollDice = random.Next(1, 7);
            Console.WriteLine("Dice number is : " + rollDice);

            //Print user options
            Console.WriteLine("Player checks options 1.No Play  2.Ladder   3.Snake");

            //Use random to check user option
            int pos = random.Next(list.Count);
            Console.WriteLine("Player option is : " + list[pos]);
            if (playerPos + rollDice < 100)
            {
                if (list[pos] == "Ladder")
                {
                    playerPos += rollDice;
                }
                if (list[pos] == "Snake")
                {
                    playerPos -= rollDice;
                }
            }
            else if (playerPos + rollDice == 100)
            {
                playerPos += rollDice;

            }

            if (playerPos < 0)
            {
                playerPos = 0;
            }
            //Print to Console
            Console.WriteLine("\n");
            Console.WriteLine("Player current position : " + playerPos);
            count++;
            Console.WriteLine("Final position is :" + playerPos);
            Console.WriteLine("number of times:" + count);
        }

    }
}
