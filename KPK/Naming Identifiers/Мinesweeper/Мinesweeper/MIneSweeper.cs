namespace Мinesweeper
{
    using System;
    using System.Collections.Generic;

    public class MineSweeper
    {
        public static void Main(string[] args)
        {
            const int MaxMinesFreeCells = 35;

            string command = string.Empty;
            char[,] gameField = CreateGameField();
            char[,] mines = PutMinesInGameField();
            int counter = 0;
            bool isOnMine = false;
            bool isAtStart = true;
            bool isGameFinished = false;
            var bestScores = new List<Score>();
            int row = 0;
            int column = 0;

            do
            {
                if (isAtStart)
                {
                    Console.WriteLine("Let's play MineSweeper.Find all cell without mines." +
                        "Use the following commands 'top' - champions list | 'restart' - start a new game | 'exit' - end game");
                    PrintGameField(gameField);
                    isAtStart = false;
                }

                Console.Write("Enter a position or a command:");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out column) &&
                        row <= gameField.GetLength(0) && column <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        {
                            ShowRankList(bestScores);
                            break;
                        }

                    case "restart":
                        {
                            gameField = CreateGameField();
                            mines = PutMinesInGameField();
                            PrintGameField(gameField);
                            isOnMine = false;
                            isAtStart = true;
                            break;
                        }

                    case "exit":
                        {
                            Console.WriteLine("Good bye!");
                            break;
                        }

                    case "turn":
                        {
                            if (mines[row, column] != '*')
                            {
                                if (mines[row, column] == '-')
                                {
                                    ShowCellValue(gameField, mines, row, column);
                                    counter++;
                                }

                                if (counter == MaxMinesFreeCells)
                                {
                                    isGameFinished = true;
                                }
                                else
                                {
                                    PrintGameField(gameField);
                                }
                            }
                            else
                            {
                                isOnMine = true;
                            }

                            break;
                        }

                    default:
                        Console.WriteLine("Error! Invalid command!\n");
                        break;
                }

                if (isOnMine)
                {
                    PrintGameField(gameField);
                    Console.Write("You are dead!Your score: {0}" + "\nEnter your nickname: ", counter);
                    string currentNickName = Console.ReadLine();
                    Score currentPlayer = new Score(currentNickName, counter);

                    if (bestScores.Count < 5)
                    {
                        bestScores.Add(currentPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < bestScores.Count; i++)
                        {
                            if (bestScores[i].Points < currentPlayer.Points)
                            {
                                bestScores.Insert(i, currentPlayer);
                                bestScores.RemoveAt(bestScores.Count - 1);
                                break;
                            }
                        }
                    }

                    SortRankList(bestScores);
                    ShowRankList(bestScores);

                    gameField = CreateGameField();
                    mines = PutMinesInGameField();
                    counter = 0;
                    isOnMine = false;
                    isAtStart = true;
                }

                if (isGameFinished)
                {
                    Console.WriteLine("\nWINNER! You found all {0} mines-free cells", MaxMinesFreeCells);
                    PrintGameField(mines);

                    Console.Write("\nEnter your name: ");
                    string currentName = Console.ReadLine();

                    Score currentScore = new Score(currentName, MaxMinesFreeCells);
                    bestScores.Add(currentScore);
                    ShowRankList(bestScores);

                    gameField = CreateGameField();
                    mines = PutMinesInGameField();
                    isAtStart = true;
                    isGameFinished = false;
                    counter = 0;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria!");
            Console.Read();
        }

        private static void SortRankList(List<Score> scores)
        {
            scores.Sort((Score s1, Score s2) => s2.Name.CompareTo(s1.Name));
            scores.Sort((Score s1, Score s2) => s2.Points.CompareTo(s1.Points));
        }

        private static void ShowCellValue(char[,] gameField, char[,] mines, int row, int col)
        {
            char minesCount = CheckMinesCount(mines, row, col);
            mines[row, col] = minesCount;
            gameField[row, col] = minesCount;
        }

        private static char CheckMinesCount(char[,] mines, int row, int column)
        {
            int count = 0;
            int minesRows = mines.GetLength(0);
            int minesColumns = mines.GetLength(1);

            if (row - 1 >= 0)
            {
                if (mines[row - 1, column] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < minesRows)
            {
                if (mines[row + 1, column] == '*')
                {
                    count++;
                }
            }

            if (column - 1 >= 0)
            {
                if (mines[row, column - 1] == '*')
                {
                    count++;
                }
            }

            if (column + 1 < minesColumns)
            {
                if (mines[row, column + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (mines[row - 1, column - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < minesColumns))
            {
                if (mines[row - 1, column + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < minesRows) && (column - 1 >= 0))
            {
                if (mines[row + 1, column - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < minesRows) && (column + 1 < minesColumns))
            {
                if (mines[row + 1, column + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }

        private static void ShowRankList(List<Score> players)
        {
            Console.WriteLine("\nScore");

            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1}---> {2} cells", i + 1, players[i].Name, players[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty rank list");
            }
        }

        private static void PrintGameField(char[,] field)
        {
            int fieldRows = field.GetLength(0);
            int fieldColumns = field.GetLength(1);

            Console.WriteLine("\n   0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int row = 0; row < fieldRows; row++)
            {
                Console.Write("{0} |", row);
                for (int col = 0; col < fieldColumns; col++)
                {
                    Console.Write(string.Format("{0} ", field[row, col]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------");
        }

        private static char[,] PutMinesInGameField()
        {
            int fieldRows = 5;
            int fieldColumns = 10;
            char[,] field = new char[fieldRows, fieldColumns];

            for (int row = 0; row < fieldRows; row++)
            {
                for (int col = 0; col < fieldColumns; col++)
                {
                    field[row, col] = '-';
                }
            }

            var mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);

                if (!mines.Contains(randomNumber))
                {
                    mines.Add(randomNumber);
                }
            }

            foreach (var mine in mines)
            {
                int row = mine % fieldColumns;
                int col = mine / fieldColumns;

                if ((row == 0) && (mine != 0))
                {
                    col--;
                    row = fieldColumns;
                }
                else
                {
                    row++;
                }

                field[col, row - 1] = '*';
            }

            return field;
        }

        private static char[,] CreateGameField()
        {
            int fieldRows = 5;
            int fieldColumns = 10;
            char[,] field = new char[fieldRows, fieldColumns];

            for (int row = 0; row < fieldRows; row++)
            {
                for (int col = 0; col < fieldColumns; col++)
                {
                    field[row, col] = '?';
                }
            }

            return field;
        }
    }
}
