using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPS
{
    internal class Program
    {
        //Rock = 1 | Paper = 2 | Siscors = 3

        public class Rock
        {
            public int draw = 1;
            public int win = 3;
            public int lose = 2;
        }

        public class Paper
        {
            public int draw = 2;
            public int win = 1;
            public int lose = 3;
        }

        public class Siscors
        {
            public int draw = 3;
            public int win = 2;
            public int lose = 1;
        }


        public static int RPS(int result, int result2)
        {

            Rock rock = new Rock();
            Paper paper = new Paper();
            Siscors siscors = new Siscors();


            //Player = 1 | Player = 2
            int winner = 0;



            if (result == 0)
            {
                if (result2 == rock.draw)
                {
                    winner = 0;
                }
                if (result2 == rock.win)
                {
                    winner = 1;
                }
                else
                {
                    winner = 2;
                }
            if (result == 1)
                {
                    if (result2 == paper.draw)
                    {
                        winner = 0;
                    }
                    if (result2 == paper.win)
                    {
                        winner = 1;
                    }
                    else
                    {
                        winner = 2;
                    }
                }
            else
                {
                    if (result2 == siscors.draw)
                    {
                        winner = 0;
                    }
                    if (result2 == siscors.win)
                    {
                        winner = 1;
                    }
                    else
                    {
                        winner = 2;
                    }
                }
            }
            return winner;
        }


        public static int Choice()
        {
            int i = 0;
            int choice = 0;
            bool flag = false;
            Random r = new Random();


            while (i < 3 && flag == false)
            {
                try
                {
                    i++;
                    Console.WriteLine("Enter your choice (Rock = 1 | Paper = 2 | Siscors = 3|)");
                    choice = int.Parse(Console.ReadLine());
                    flag = true;
                    if (choice > 3 || choice < 1)
                    {
                        Console.WriteLine("Please enter a number between 1 and 3");
                        flag = false;
                    }
                }
                catch (Exception e)
                {
                    flag = false;
                    Console.WriteLine("ERROR The input should be a digit integer between 1 and three");
                }
            }
            if (i == 3)
            {
                choice = r.Next(1, 4);
            }
            return choice;
        }






        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Siscors!");
            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();


            int playerWins = 0;
            int computerWins = 0;



            //Round one

            Random RNG = new Random();




            int round = 0;



            while (round<3)
            {
                round++;

                int player = Choice();
                int computer = RNG.Next(1, 4);

                int winner = RPS(player,computer);

                switch (winner)
                {
                    case 0:
                        Thread.Sleep(1000);
                        Console.WriteLine("The Round was a draw");
                        break;
                    case 1:
                        Thread.Sleep(2000);
                        Console.WriteLine(" You have won the round!");
                        playerWins++;
                        break;
                    case 2:
                        Thread.Sleep(2000);
                        Console.WriteLine(" You have lost the round!");
                        computerWins++;
                        break;

                }

            }

        }
    }
}
