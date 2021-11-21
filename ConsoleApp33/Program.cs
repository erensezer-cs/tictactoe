using System;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            string f1 = " ", f2 = " ", f3 = " ", f4 = " ", f5 = " ", f6 = " ", f7 = " ", f8 = " ", f9 = " ";
            string choices = "X";
            string user;
            int usernumber = 0;
            int choicenumber = 0;
            Console.WriteLine("WELCOME THE TİC TAC TOE !");

            
            for (int z = 0; z < 9; z++)
            {
                Console.WriteLine($" {f1} | {f2} | {f3}");
                Console.WriteLine("---+---+---");
                Console.WriteLine($" {f4} | {f5} | {f6}");
                Console.WriteLine("---+---+---");
                Console.WriteLine($" {f7} | {f8} | {f9}");


                if (z % 2 == 0) choices = "X";
                else choices = "O";

                while (choicenumber < 9)
                {
                    Console.Write($"{choices}'s move > ");
                    user = Console.ReadLine();
                    if (!int.TryParse(user, out usernumber)) continue;

                    if (usernumber == 1)
                    {
                        if (f1 != " ")
                        {
                            Console.WriteLine("Illegal Move TRY AGAİN");
                            continue;
                        }
                        f1 = choices;
                    }

                    else if (usernumber == 2)
                    {
                        if (f2 != " ")
                        {
                            Console.WriteLine("Illegal Move TRY AGAİN");
                            continue;
                        }
                        f2 = choices;
                    }

                    else if (usernumber == 3)
                    {
                        if (f3 != " ")
                        {
                            Console.WriteLine("Illegal Move TRY AGAİN");
                            continue;
                        }
                        f3 = choices;
                    }

                     else if (usernumber == 4)
                    {
                        if (f4 != " ")
                        {
                            Console.WriteLine("Illegal Move TRY AGAİN");
                            continue;
                        }
                        f4 = choices;
                    }

                   else  if (usernumber == 5)
                    {
                        if (f5 != " ")
                        {
                            Console.WriteLine("Illegal Move TRY AGAİN");
                            continue;
                        }
                        f5 = choices;
                    }

                    else if (usernumber == 6)
                    {
                        if (f6 != " ")
                        {
                            Console.WriteLine("Illegal Move TRY AGAİN");
                            continue;
                        }
                        f6 = choices;
                    }

                    else if (usernumber == 7)
                    {
                        if (f7 != " ")
                        {
                            Console.WriteLine("Illegal Move TRY AGAİN");
                            continue;
                        }
                        f7 = choices;
                    }

                    else if (usernumber == 8)
                    {
                        if (f8 != " ")
                        {
                            Console.WriteLine("Illegal Move TRY AGAİN");
                            continue;
                        }
                        f8 = choices;
                    }

                    else if (usernumber == 9)
                    {
                        if (f9 != " ")
                        {
                            Console.WriteLine("Illegal Move TRY AGAİN");
                            continue;
                        }
                        f9 = choices;
                    }


                    else 
                    {
                        Console.WriteLine("Illegal Move TRY AGAİN");
                    }

                    usernumber++;
                    break;
                }


            }
            Console.WriteLine("GAME OVER");
        }
    }
}
