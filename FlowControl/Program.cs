﻿namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;

            do
            {
                Console.WriteLine("0 = Avsluta");
                Console.WriteLine("1 = Biljettpriser");
                Console.WriteLine("2 = Räkna ut totalkostnad");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        loop = false;
                    break;

                    case "1":
                        Console.WriteLine("Ange ålder:");
                        int age = Convert.ToInt32(Console.ReadLine());

                        if (age < 20)
                        {
                            Console.WriteLine("Ungdomspris: 80kr");
                        }

                        else if(age > 64)
                        {
                            Console.WriteLine("Pensionärspris: 90kr");
                        }

                        else
                        {
                            Console.WriteLine("Standarpris: 120kr");
                        }

                     break;

                    case "2":
                        int totalSum = 0;
                        int age2;
                        Console.WriteLine("Ange antal personer:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int c = 0; c < n; c++)
                        {
                            Console.WriteLine("Ange ålder för person " + (c + 1) + ":");
                            age2 = Convert.ToInt32(Console.ReadLine());

                            if (age2 < 20)
                            {
                                totalSum += 80;                            }

                            else if (age2 > 64)
                            {
                                totalSum += 90;
                            }

                            else
                            {
                                totalSum += 120;
                            }
                        }
                         
                        Console.WriteLine("Antal personer = " + n);
                        Console.WriteLine("Totalkostnad = " + totalSum + "kr");
                    break;

                    default:
                        Console.WriteLine("Ej giltig input");
                    break;
                }
            }
            while (loop);
        }
    }
}
