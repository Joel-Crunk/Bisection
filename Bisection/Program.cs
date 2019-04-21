using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playGame = true;
            do
            {

                Console.Clear();
            Console.WriteLine(" 1) Guess the number\n 2) Computer guess the number");
            string input = Console.ReadLine();
            if (input == "1")
            {
                HumanPlays();
            }
            if (input == "2")
            {
                ComputerPlays();
            }
            Console.WriteLine(" Do you want to play again? \n Y or N");
            string input2 = Console.ReadLine();
            input2.ToUpper();
                if (input2 == "N")
                {
                    playGame = false;
                }

            } while (playGame);



        }

        private static void HumanPlays()
        {
            Random ran = new Random();


            int[] numlist = new int[10];
            int answer = ran.Next(numlist.Length);

            for (int i = 0; i < numlist.Length; i++)
            {
                numlist[i] = i + 1;
            }
            int target;
            int length = numlist.Length;
            

            bool found = false;
            
            while (!found)
            {
                
                Console.WriteLine($"Enter a number between 1 and {length}");
                target = int.Parse(Console.ReadLine());

                if (target != answer)
                {
                    Console.WriteLine("Wrong number guess again!");

                    if (target > answer)
                    {
                        Console.WriteLine($"{target} is too high");
                    }
                    else if (target < answer)
                    {
                        Console.WriteLine($" {target} is too low");
                    }
                   
                }
                if (target == answer)
                {
                    found = true;
                    Console.WriteLine($" {answer} is your number");
                }
                   
                

            }
        }
        private static void ComputerPlays()
        {
         
            int[] numlist = new int[10];
          
            for (int i = 0; i < numlist.Length; i++)
            {
                numlist[i] = i + 1;
            }
           
            int length = numlist.Length;
            Console.WriteLine($"Enter a number between 1 and {length}");
            int answer = int.Parse(Console.ReadLine());

            bool found = false;
            int mid;
            int beginning = 1;


            while (!found)
            {
                mid = (beginning + length) / 2;

                if (answer < mid)
                {
                    length = mid - 1; ;
                    Console.WriteLine($"{mid} is too high");
                }
                else if (answer > mid)
                {
                    beginning = mid + 1;
                    Console.WriteLine($"{mid} is too low");
                }
                else
                {
                    found = true;
                    Console.WriteLine($" {answer} is your number");
                }

            }
        }
    }
}
