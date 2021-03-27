using System;

namespace MDT112_Midterm_Test_The_Nim
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerA, playerB;

            Console.WriteLine("Please input name of Player A : ");
            playerA = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input name of Player B : ");
            playerB = int.Parse(Console.ReadLine());

            int a, b, c;

            Console.WriteLine("Please input number of box in Tank NO.1 : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input number of box in Tank NO.2 : ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input number of box in Tank NO.3 : ");
            c = int.Parse(Console.ReadLine());

            int d, e, f, g;

            Console.WriteLine("Number of Tank : ");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of box pick out by Player A : ");
            e = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of Tank : ");
            f = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of box pick out by Player B : ");
            g = int.Parse(Console.ReadLine());

            switch (playerA, playerB)
            {
                case "Player A pick out box from tank 1":
                    Console.WriteLine("2 boxes");
                    break;
                case "Player B pick out box from tank 3":
                    Console.WriteLine("2 boxes");
                    break;
                case "Player A pick out box from tank 2":
                    Console.WriteLine("1 boxes");
                    break;
                case "Player B pick out box from tank 3":
                    Console.WriteLine("2 boxes");
                    break;
                case "Player A pick out box from tank 1":
                    Console.WriteLine("1 boxes");
                    break;
                case "Player B pick out box from tank 2":
                    Console.WriteLine("1 boxes");
                    break;
            }
            winner = playerA 

            string winner;

            Console.WriteLine("The Winner is {0}", winner);

            Console.ReadLine();

        }
    }
}
