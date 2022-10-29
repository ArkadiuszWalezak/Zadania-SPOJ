using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public enum GamerType
    {
        X,
        O
    }

    public class Program
    {
        static int iteration = 0;
        public static bool isValid = true;
        public static bool winner = false;
        public static bool endSILoop = false;

        public static int[] Xpositions = new int[3];
        public static int[] Ypositions = new int[3];

        public static List<Point> points = new List<Point>();

        static GamerType CurrentGamerType;

        public static int x = 0;
        public static int y = 0;

        static void Main()
        {
            Xpositions[0] = 5;
            Xpositions[1] = 9;
            Xpositions[2] = 13;

            Ypositions[0] = 1;
            Ypositions[1] = 2;
            Ypositions[2] = 3;

            while (true)
            {
                
                DrawTable();

                foreach (var point in points)
                {
                    DrawSignXY(Xpositions[point.x - 1], Ypositions[point.y - 1], point.gamerType);
                }

                Console.SetCursorPosition(0, 5);
                CheckPotentialWinner(iteration, CurrentGamerType);
                Quit();
                CurrentGamerType = SelectGamerType(iteration);
                ShowInfo(CurrentGamerType);
                ReadInput();
                PointAddingValidation();
                PointAdding();
                
                Console.Clear();
            }
        }

        public static GamerType SelectGamerType(int iteration)
        {
            GamerType CurrentGamerType;
            if (iteration % 2 == 0)
            {
                CurrentGamerType = GamerType.X;
            }
            else
            {
                CurrentGamerType = GamerType.O;

            }
            return CurrentGamerType;
        }

        public static void DrawTable()
        {
            Console.WriteLine("___| 1 | 2 | 3 |");
            Console.WriteLine(" 1 |");
            Console.WriteLine(" 2 |");
            Console.WriteLine(" 3 |");
        }

        public static void DrawSignXY(int x, int y, GamerType type)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(type);
        }

        public static void ShowInfo(GamerType CurrentGamerType)
        {
            if (isValid == false)
            {
                Console.WriteLine("Podałeś zajęty punkt, popraw się! Teraz kolej gracza: {0}", CurrentGamerType);
                isValid = true;
            }
            else
            {
                Console.WriteLine("Teraz kolej gracza: {0}", CurrentGamerType);
            }
        }

        public static void ReadInput()
        {
            if (CurrentGamerType == GamerType.O)
            {
                Opponent.Play();
            }

            else
            {
                string scoordinates = Console.ReadLine();
                string[] coordinatesArray = scoordinates.Split(' ');

                x = int.Parse(coordinatesArray[0]);
                y = int.Parse(coordinatesArray[1]);
            }
        }

        public static void PointAddingValidation()
        {
            foreach (var point in points)
            {
                if (point.x == x && point.y == y)
                {
                    if(CurrentGamerType == GamerType.O)
                    {
                        endSILoop = true;
                    }

                    isValid = false;
                    break;
                }
            }
        }

        public static void PointAdding()
        {
            if (isValid == true)
            {
                Point point = new Point();
                point.x = x;
                point.y = y;
                point.gamerType = CurrentGamerType;
                points.Add(point);

                iteration++;
            }
        }

        public static void CheckPotentialWinner(int iteration, GamerType CurrentGamerType)
        {
            if (iteration > 4)
            {
                List<Point> currentGamerPoints = new List<Point>();
                foreach (var point in points)
                {
                    if (point.gamerType == CurrentGamerType)
                    {
                        currentGamerPoints.Add(point);
                    }
                }

                int counter = 0;

                for (int X = 1; X < 4; X++)
                {
                    foreach (var point in currentGamerPoints)
                    {
                        if (point.x == X)
                        {
                            counter++;
                        }
                    }

                    if (counter > 2)
                    {
                        Console.WriteLine("Wygrana gracza {0}!", CurrentGamerType);
                        Console.ReadKey();
                        winner = true;

                        return;
                    }
                    counter = 0;
                }

                for (int Y = 1; Y < 4; Y++)
                {
                    foreach (var point in currentGamerPoints)
                    {
                        if (point.y == Y)
                        {
                            counter++;
                        }
                    }

                    if (counter > 2)
                    {
                        Console.WriteLine("Wygrana gracza {0}!", CurrentGamerType);
                        Console.ReadKey();
                        winner = true;

                        return;
                    }
                    counter = 0;
                }

                foreach (var point in currentGamerPoints)
                {
                    if (point.y == point.x)
                    {
                        counter++;
                    }
                }

                if (counter > 2)
                {
                    Console.WriteLine("Wygrana gracza {0}!1", CurrentGamerType);
                    Console.ReadKey();
                    winner = true;

                    return;
                }
                counter = 0;

                foreach (var point in currentGamerPoints)
                {
                    if (point.y + point.x == 4)
                    {
                        counter++;
                    }
                }

                if (counter > 2)
                {
                    Console.WriteLine("Wygrana gracza {0}!2", CurrentGamerType);
                    Console.ReadKey();
                    winner = true;
                    return;
                }
                counter = 0;
                
                if (iteration == 9 && winner == false)
                {
                    Console.WriteLine("Oj, byq, nikt nie wygrał. Sztuczna inteligencja pełną gębom :)");
                    Console.ReadKey();
                    winner = true;
                    return;
                }

            }
        }

        public static void Quit()
        {
            if (winner == true)
            {
                Environment.Exit(0);
            }
        }
    }
}
