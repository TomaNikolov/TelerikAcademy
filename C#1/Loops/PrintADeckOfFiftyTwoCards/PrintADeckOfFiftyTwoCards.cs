
//Problem 4. Print a Deck of 52 Cards

//    Write a program that generates and prints all possible cards from a 
//standard deck of 52 cards (without the jokers). The cards should be 
//printed using the classical notation (like 5 of spades, A of hearts,
//9 of clubs; and K of diamonds).
//        The card faces should start from 2 to A.
//        Print each card face in its four possible suits: clubs, diamonds,
//hearts and spades. Use 2 nested for-loops and a switch-case statement.


using System;



    class PrintADeckOfFiftyTwoCards
    {
        static void Main()
        {
            string[] cards = new string[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            char[] cardColor = new char[] {'♣', '♦', '♥', '♠'};

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(cards[i] + " " + "of" + " " + cardColor[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

