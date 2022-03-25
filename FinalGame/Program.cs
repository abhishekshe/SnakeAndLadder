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
          
            int rollDice, playerPos1 = 0, playerPos2 = 0;
            int count = 0;

            
            Random random = new Random();
            
            var list = new List<string> { "No Play", "Ladder", "Snake" };
            
            int playerChange = 1;
            while (playerPos1 <= 100 || playerPos2 <= 100)
            {
               
                Console.WriteLine("Player: " + playerChange + " is playing \n");

                
                rollDice = random.Next(1, 7);
                Console.WriteLine("Dice number is : " + rollDice + "\n");

              
                Console.WriteLine("Player checks options 1.No Play  2.Ladder   3.Snake \n");

                
                int index = random.Next(list.Count);
                Console.WriteLine("Player option is : " + list[index] + "\n");


                
                if (playerChange == 1)
                {
                    
                    if (list[index] == "No Play" && playerChange == 1)
                    {
                        playerChange = 2;
                        continue;
                    }

                   
                    if (list[index] == "Snake")
                    {
                        playerPos1 -= rollDice;
                        playerChange = 2;
                    }

             
                    if (playerPos1 + rollDice < 100 && playerChange == 1)
                    {
                        if (list[index] == "Ladder") playerPos1 += rollDice;
                    }



                   
                    if (list[index] == "Ladder" && (playerPos1 + rollDice == 100) && playerChange == 1)
                    {
                        playerPos1 += rollDice;
                        break;
                    }

                   
                    if (playerPos1 < 0 && list[index] == "Snake")
                    {
                        playerPos1 = 0;
                    }

                 
                    Console.WriteLine("\n");
                    Console.WriteLine("Player 1 current position : " + playerPos1);
                }

                
                else if (playerChange == 2)
                {
                    
                    if (list[index] == "No Play" && playerChange == 2)
                    {
                        playerChange = 1;
                        continue;
                    }

               
                    if (playerPos2 + rollDice < 100 && playerChange == 2)
                    {
                        if (list[index] == "Ladder") playerPos2 += rollDice;
                    }

                    //If player option is "Snake" , position will go down and will change player to 1
                    if (list[index] == "Snake")
                    {
                        playerPos2 -= rollDice;
                        playerChange = 1;
                    }

                    //If after rolling dice player reached "Exactly 100" then it will increment and come out of loop.Winner is Player 2
                    if (list[index] == "Ladder" && (playerPos2 + rollDice == 100) && playerChange == 2)
                    {
                        playerPos2 += rollDice;
                        break;
                    }

                    //If after getting "Snake" option , position is less than 0, then reset position to 0
                    if (playerPos2 < 0 && list[index] == "Snake")
                    {
                        playerPos2 = 0;
                    }

                    //Print to Console
                    Console.WriteLine("\n");
                    Console.WriteLine("Player 2 current position : " + playerPos2);
                    count++;
                }
            }
            Console.WriteLine("\n");
            //Print winner of 2Player Game
            if (playerPos1 == 100)
            {
                Console.WriteLine("Winner is player 1  :" + playerPos1);
                Console.WriteLine("Final position of player 2  :" + playerPos2);
            }
            else
            {
                Console.WriteLine("Winner is player 2  :" + playerPos2);
                Console.WriteLine("Final position of player 1  :" + playerPos1);
            }
            //Total Number of game played
            Console.WriteLine("Number of times game played :" + count);

        }

    }
}
