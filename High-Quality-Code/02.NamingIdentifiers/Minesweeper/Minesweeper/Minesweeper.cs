namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class Minesweeper
    {
        private const int GameFieldRows = 5;
        private const int GameFieldCols = 10;

        public static void Main()
        {
            const int FieldsWithoutMains = 35;
            string command = string.Empty;
            int pointCounter = 0;
            int row = 0;
            int col = 0;
            char[,] gameField = CreateGameField();
            char[,] mines = PutMines();
            bool steppOnMine = false;
            bool isStartGame = true;
            bool wonGame = false;
            List<Player> hightScores = new List<Player>(6);

            do
            {
                if (isStartGame)
                {
                    Console.WriteLine("Let's play 'Minesweepers'. Try stepping only on the mine-free fields. " +
                    "Command 'top' shows the highscores, 'restart' starts a new game, 'exit' quits the game!");
                    PrintGameField(gameField);
                    isStartGame = false;
                }

                Console.Write("Enter row and col separate by space : ");

                command = Console.ReadLine().Trim();

                if (command.Length <= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= gameField.GetLength(0) && col <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Ranking(hightScores);
                        break;
                    case "restart":
                        gameField = CreateGameField();
                        mines = PutMines();
                        PrintGameField(gameField);
                        break;
                    case "exit":
                        Console.WriteLine("Bye, Bye!");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                ShowFieldValue(gameField, mines, row, col);
                                pointCounter++;
                            }

                            if (FieldsWithoutMains == pointCounter)
                            {
                                wonGame = true;
                            }
                            else
                            {
                                PrintGameField(gameField);
                            }
                        }
                        else
                        {
                            steppOnMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid Command\n");
                        break;
                }

                if (steppOnMine)
                {
                    PrintGameField(mines);
                    Console.Write("\n You died with {0} points. Enter your nickname ", pointCounter);
                    string niknejm = Console.ReadLine();
                    Player t = new Player(niknejm, pointCounter);
                    if (hightScores.Count < 5)
                    {
                        hightScores.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < hightScores.Count; i++)
                        {
                            if (hightScores[i].Points < t.Points)
                            {
                                hightScores.Insert(i, t);
                                hightScores.RemoveAt(hightScores.Count - 1);
                                break;
                            }
                        }
                    }

                    hightScores.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    hightScores.Sort((Player r1, Player r2) => r2.Points.CompareTo(r1.Points));
                    Ranking(hightScores);

                    gameField = CreateGameField();
                    mines = PutMines();
                    pointCounter = 0;
                    steppOnMine = false;
                    isStartGame = true;
                }

                if (wonGame)
                {
                    Console.WriteLine("\n Congratulations! You've opened all 35 fields unharmed!");
                    PrintGameField(mines);
                    Console.WriteLine("Enter your nickname: ");
                    string imeee = Console.ReadLine();
                    Player to4kii = new Player(imeee, pointCounter);
                    hightScores.Add(to4kii);
                    Ranking(hightScores);
                    gameField = CreateGameField();
                    mines = PutMines();
                    pointCounter = 0;
                    wonGame = false;
                    isStartGame = true;
                }
            } 
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void Ranking(List<Player> players)
        {
            Console.WriteLine("\nPoints:");
            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Player currentPlayer = players[i];
                    int rating = i + 1;
                    Console.WriteLine("{0}. {1} --> {2} points", rating, currentPlayer.Name, currentPlayer.Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty rank list!\n");
            }
        }

        private static void ShowFieldValue(char[,] gameField, char[,] mines, int row, int col)
        {
            char numberOfMInesAround = CalculateMinesAround(mines, row, col);
            mines[row, col] = numberOfMInesAround;
            gameField[row, col] = numberOfMInesAround;
        }

        private static void PrintGameField(char[,] gameField)
        {
            int rows = GameFieldRows;
            int cols = GameFieldCols;

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int row = 0; row < rows; row++)
            {
                Console.Write("{0} | ", row);

                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0} ", gameField[row, col]);
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int row = 0; row < boardRows; row++)
            {
                for (int col = 0; col < boardColumns; col++)
                {
                    board[row, col] = '?';
                }
            }

            return board;
        }

        private static char[,] PutMines()
        {
            int rows = GameFieldRows;
            int cols = GameFieldCols;
            char[,] gameField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> bombs = new List<int>();
            while (bombs.Count < 15)
            {
                Random random = new Random();
                int bombPosition = random.Next(50);
                if (!bombs.Contains(bombPosition))
                {
                    bombs.Add(bombPosition);
                }
            }

            foreach (var bombPosition in bombs)
            {
                int row = (bombPosition / cols);
                int col = (bombPosition % cols);

                if (col == 0 && bombPosition != 0)
                {
                    row--;
                    col = cols;
                }
                else
                {
                    col++;
                }

                gameField[row, col - 1] = '*';
            }

            return gameField;
        }

        private static void CalculateFieldValues(char[,] gameField)
        {
            int rows = GameFieldRows;
            int cols = GameFieldCols;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (gameField[row, col] != '*')
                    {
                        char numberOfMInesAround = CalculateMinesAround(gameField, row, col);
                        gameField[row, col] = numberOfMInesAround;
                    }
                }
            }
        }

        private static char CalculateMinesAround(char[,] mines, int row, int col)
        {
            int numberOfMInesAround = 0;
            int rows = GameFieldRows;
            int cols = GameFieldRows;

            if (row - 1 >= 0)
            {
                if (mines[row - 1, col] == '*')
                {
                    numberOfMInesAround++;
                }
            }

            if (row + 1 < rows)
            {
                if (mines[row + 1, col] == '*')
                {
                    numberOfMInesAround++;
                }
            }

            if (col - 1 >= 0)
            {
                if (mines[row, col - 1] == '*')
                {
                    numberOfMInesAround++;
                }
            }

            if (col + 1 < cols)
            {
                if (mines[row, col + 1] == '*')
                {
                    numberOfMInesAround++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (mines[row - 1, col - 1] == '*')
                {
                    numberOfMInesAround++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (mines[row - 1, col + 1] == '*')
                {
                    numberOfMInesAround++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (mines[row + 1, col - 1] == '*')
                {
                    numberOfMInesAround++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (mines[row + 1, col + 1] == '*')
                {
                    numberOfMInesAround++;
                }
            }

            return char.Parse(numberOfMInesAround.ToString());
        }
    }
}