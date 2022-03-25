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
            
            int rollDice, playerPos = 0;
            int count = 0;

         
            Random random = new Random();
       
            var list = new List<string> { "No Play", "Ladder", "Snake" };

         
            rollDice = random.Next(1, 7);
            Console.WriteLine("Dice number is : " + rollDice);

          
            Console.WriteLine("Player checks options 1.No Play  2.Ladder   3.Snake");

          
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
            else if (playerPos + rollDice == 100 && list[pos] == "Ladder")
            {
                playerPos += rollDice;

            }

            if (playerPos < 0)
            {
                playerPos = 0;
            }
       
            Console.WriteLine("\n");
            Console.WriteLine("Player current position : " + playerPos);
            count++;
            Console.WriteLine("Final position is :" + playerPos);
            Console.WriteLine("Total MOves:" + count);
        }

    }
}
