using System;
using System.Threading;

namespace drinking_game
{
    class Program
    {
        public static string spacer = ""; // Gør det lidt nemmere at læse skriften.
        public static string player1; // Holder spillernes navn
        public static string player2;

        public static int p1Number1;
        public static int p1Number2;
        public static int p1Number3;
        public static int p1Number4;
        public static int p1Number5;
        public static int p1Number6;
        public static int p1Number7;
        public static int p1Number8;
        public static int p1Number9;
        public static int p1Number10;
        public static int p1Total;

        public static int p2Number1;
        public static int p2Number2;
        public static int p2Number3;
        public static int p2Number4;
        public static int p2Number5;
        public static int p2Number6;
        public static int p2Number7;
        public static int p2Number8;
        public static int p2Number9;
        public static int p2Number10;
        public static int p2Total;

        static void Main() // Menu.
        {
            // Den første del her er en introduktion til spillet.
            Thread.Sleep(300); // Venter 300 ms før den går videre. Det gør så tingene ikke bare flyver afsted.
            Console.Clear();
            Console.WriteLine("Welcome!");
            Thread.Sleep(1000); // Venter 1 sekund.
            Console.WriteLine(spacer);
            Console.WriteLine("This is a dice game.\n2 players will input their name, and each roll the dice 10 times.\n\nHe who rolls highest, wins the game.");
            Thread.Sleep(2000); // Venter 2 sekunder.
            Console.WriteLine(spacer);
            Console.WriteLine("Press any key to start the game...");
            Console.ReadKey(); // Venter på at en spiller trykker på en tast.
            Console.Clear(); // Rydder konsollen af alt tekst.
            Thread.Sleep(300);

            // Her tilgiver spillernes deres navne
            Console.Clear();
            Console.Write("Player 1 please enter your name: ");
            player1 = Console.ReadLine();
            Thread.Sleep(500);
            Console.Write("Player 2 please enter your name: ");
            player2 = Console.ReadLine();
            Console.Clear();
            Thread.Sleep(300);

            Game();

        }

        static void Game()
        {
            // Spiller 1 tager sin tur
            Console.Clear();
            Thread.Sleep(300);
            Console.WriteLine("Good luck!");
            Console.WriteLine(spacer);
            Console.WriteLine(player1 + " it is your turn to roll.");
            Console.WriteLine(spacer);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            DiceRoll(); // Funktionen der leverer de tilfældige tal.
            Console.Clear();
            Thread.Sleep(300);


            //Anden spiller gætter.
            Console.WriteLine(player2 + " it is your turn to roll.");
            Console.WriteLine(spacer);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            DiceRoll();
            Console.Clear();
            Thread.Sleep(500);

            // Viser spillerne hvad de har kastet.
            Player1Rolled();
            Player2Rolled();
            Console.WriteLine(spacer);
            Thread.Sleep(500);

            // Visuelt feedback.
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Gathering results...");
                Thread.Sleep(500);
            }
            Thread.Sleep(300);
            Console.WriteLine(spacer);


            // Nu sammenligner den spillerenes tal og vudere hvem der vinder.
            if (p1Total > p2Total)
            {
                string choice;
                Console.WriteLine(player1 + " has won the game with the highest score of: " + p1Total);
                Console.WriteLine(spacer);
                Console.WriteLine(player2 + " scored: " + p2Total);
                Console.WriteLine(spacer);
                Console.Write("Do you wish to play again? [y/n]: "); // I stedet for at starte et nyt spil så kan man spille igen med samme navne.
                choice = Console.ReadLine(); // holder spillererens valg.
                if (choice == "y")
                    Game();
                else if (choice == "n") // Hvis man vælger NO så går man til introduktionen igen.
                    Main();

            }
            else if (p1Total < p2Total)
            {
                string choice;
                Console.WriteLine(player2 + " has won the game with the highest score of: " + p2Total);
                Console.WriteLine(spacer);
                Console.WriteLine(player1 + " scored: " + p1Total);
                Console.WriteLine(spacer);
                Thread.Sleep(1000);
                Console.Write("Do you wish to play again? [y/n]: ");
                choice = Console.ReadLine();
                if (choice == "y")
                    Game();
                else if (choice == "n")
                    Main();
            }
        }

        // Dette er funktionen der spytter de tilfældige tal ud.
        static void DiceRoll()
        {
            var rand = new Random(); // Kalder på random klassen fra system library.

            // Holder spillerenes tal.
            p1Number1 = rand.Next(1, 7); // rand.Next vælger et tilfædigt integer mellem 1 og 6. nextDouble ville gøre det samme bare med decimaler.
            p1Number2 = rand.Next(1, 7);
            p1Number3 = rand.Next(1, 7);
            p1Number4 = rand.Next(1, 7);
            p1Number5 = rand.Next(1, 7);
            p1Number6 = rand.Next(1, 7);
            p1Number7 = rand.Next(1, 7);
            p1Number8 = rand.Next(1, 7);
            p1Number9 = rand.Next(1, 7);
            p1Number10 = rand.Next(1, 7);
            p1Total = p1Number1 + p1Number2 + p1Number3 + p1Number4 + p1Number5 + p1Number6 + p1Number7 + p1Number8 + p1Number9 + p1Number10; // Ligger tallene sammen.

            p2Number1 = rand.Next(1, 7);
            p2Number2 = rand.Next(1, 7);
            p2Number3 = rand.Next(1, 7);
            p2Number4 = rand.Next(1, 7);
            p2Number5 = rand.Next(1, 7);
            p2Number6 = rand.Next(1, 7);
            p2Number7 = rand.Next(1, 7);
            p2Number8 = rand.Next(1, 7);
            p2Number9 = rand.Next(1, 7);
            p2Number10 = rand.Next(1, 7);
            p2Total = p2Number1 + p2Number2 + p2Number3 + p2Number4 + p2Number5 + p1Number6 + p1Number7 + p1Number8 + p1Number9 + p1Number10;

            // Visuelt feedback.
            Console.Clear();
            Console.WriteLine("Rolling dice.");
            Thread.Sleep(500);
            Console.WriteLine("Rolling dice.");
            Thread.Sleep(500);
            Console.WriteLine("Rolling dice.");
            Thread.Sleep(500);
            Console.WriteLine("Rolling dice.");
            Thread.Sleep(500);
            Console.WriteLine("Rolling dice.");
            Thread.Sleep(500);
            Console.WriteLine("Rolling dice.");
            Thread.Sleep(500);
            Console.WriteLine("Rolling dice.");
            Thread.Sleep(500);
            Console.WriteLine("Rolling dice.");
            Thread.Sleep(500);
            Console.WriteLine("Rolling dice.");
            Thread.Sleep(500);
            Console.WriteLine("Rolling dice.");
            Thread.Sleep(500);
            Console.Clear();
        }

        // De her to funktioner er kun for visuelt feedback.
        static void Player1Rolled()
        {
            Console.Write(player1 + ", you rolled: ");
            Thread.Sleep(600);
            Console.Write(p1Number1 + " ");
            Thread.Sleep(600);
            Console.Write(p1Number2 + " ");
            Thread.Sleep(600);
            Console.Write(p1Number3 + " ");
            Thread.Sleep(600);
            Console.Write(p1Number4 + " ");
            Thread.Sleep(600);
            Console.Write(p1Number5 + " ");
            Thread.Sleep(600);
            Console.Write(p1Number6 + " ");
            Thread.Sleep(600);
            Console.Write(p1Number7 + " ");
            Thread.Sleep(600);
            Console.Write(p1Number8 + " ");
            Thread.Sleep(600);
            Console.Write(p1Number9 + " ");
            Thread.Sleep(600);
            Console.WriteLine(p1Number10);
            Thread.Sleep(1000);
        }

        static void Player2Rolled()
        {
            Console.Write(player2 + ", you rolled: ");
            Thread.Sleep(600);
            Console.Write(p2Number1 + " ");
            Thread.Sleep(600);
            Console.Write(p2Number2 + " ");
            Thread.Sleep(600);
            Console.Write(p2Number3 + " ");
            Thread.Sleep(600);
            Console.Write(p2Number4 + " ");
            Thread.Sleep(600);
            Console.Write(p2Number5 + " ");
            Thread.Sleep(600);
            Console.Write(p2Number6 + " ");
            Thread.Sleep(600);
            Console.Write(p2Number7 + " ");
            Thread.Sleep(600);
            Console.Write(p2Number8 + " ");
            Thread.Sleep(600);
            Console.Write(p2Number9 + " ");
            Thread.Sleep(600);
            Console.WriteLine(p2Number10);
        }

    }
}



