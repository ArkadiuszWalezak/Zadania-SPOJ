using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public static class Opponent
    {
        private static bool XPosibleWin = true;
        private static bool YPosibleWin = true;
        private static bool cross1PosbileWin = true;
        private static bool cross2PosbileWin = true;
        public static void Play()
        {
            if (Program.points.Count < 2)
            {
                Random random = new Random();

                int d = random.Next(1, 4);
                int b = random.Next(1, 4);

                Program.x = d;
                Program.y = b;
            }
            else
            {
                CheckIfPlayerCanWin();
            }
        }

        public static void CheckIfPlayerCanWin()
        {
            List<Point> currentGamerPoints = new List<Point>();
            foreach (var point in Program.points)
            {
                if (point.gamerType == GamerType.X)
                {
                    currentGamerPoints.Add(point);
                }
            }

            int counter = 0;

            XPosibleWin = true;

            if (XPosibleWin == true)
            {
                for (int X = 1; X < 4; X++)
                {
                    foreach (var point in currentGamerPoints)
                    {
                        if (point.x == X)
                        {
                            counter++;
                        }
                    }

                    if (counter == 2)
                    {
                        int counting = 6;

                        Program.x = X;
                        foreach (var point in currentGamerPoints)
                        {
                            if (point.x == X)
                            {
                                counting = counting - point.y;
                            }
                        }
                        Program.y = counting;

                        if (AIPointAddingValidation(Program.x, Program.y) == false)
                        {
                            X++;
                            if (X + 1 > Program.Xpositions.Length)
                            {
                                //checking = true;
                                X = 0;
                                break;
                            }
                        }
                    }

                    if (2 < counter)
                    {
                        XPosibleWin = false;
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

                    if (counter == 2)
                    {
                        int counting = 6;
                        
                        Program.y = Y;
                        foreach (var point in currentGamerPoints)
                        {

                            if (point.y == Y)
                            {
                                counting = counting - point.x;
                            }
                        }
                        Program.x = counting;

                        if (AIPointAddingValidation(Program.x, Program.y) == false)
                        {
                            Y++;
                            if (Y + 1 > Program.Xpositions.Length)
                            {
                                //checking = true;
                                Y = 0;
                                break;
                            }
                        }
                    }

                    if (2 < counter)
                    {
                        YPosibleWin = false;
                    }
                    counter = 0;
                }

                foreach (var point in currentGamerPoints)
                {
                    if (point.y == point.x)
                    {
                        counter++;
                    }

                    if (counter == 2)
                    {
                        bool one = false;
                        bool two = false;
                        bool three = false;
                        int x = 0;
                        int y = 0;

                        foreach (var points in currentGamerPoints)
                        {
                            if ((points.x == points.y) && (points.y == 1))
                            {
                                one = true;
                            }
                            if ((points.x == points.y) && (points.y == 2))
                            {
                                two = true;
                            }
                            if ((points.x == points.y) && (points.y == 3))
                            {
                                three = true;
                            }
                        }
                        if (one == true && two == true)
                        {
                            x = 3;
                            y = 3;
                        }
                        if (one == true && three == true)
                        {
                            x = 2;
                            y = 2;
                        }
                        if (two == true && three == true)
                        {
                            x = 1;
                            y = 1;
                        }
                        if (AIPointAddingValidation(x, y) == false)
                        {
                            cross1PosbileWin = false;
                        }
                        if (AIPointAddingValidation(x, y) == true)
                        {
                            Program.x = x;
                            Program.y = y;
                        }
                    }
                }

                counter = 0;

                foreach (var point in currentGamerPoints)
                {
                    if (point.y + point.x == 4)
                    {
                        counter++;
                    }
                }

                if (counter == 2)
                {
                    List<Point> temp = new List<Point>();

                    foreach (var point in currentGamerPoints)
                    {
                        if (point.y + point.x == 4)
                        {
                            temp.Add(point);
                        }
                    }
                    bool one = false;
                    bool two = false;
                    bool three = false;
                    int x = 0;
                    int y = 0;

                    foreach (var points in temp)
                    {
                        if (points.x == 1)
                        {
                            one = true;
                        }
                        if (points.x == 2)
                        { 
                            two = true;
                        }
                        if (points.x == 3)
                        {
                            three = true;
                        }
                    }
                    if (one == true && two == true)
                    {
                        x = 1;
                        y = 3;
                    }
                    if (one == true && three == true)
                    {
                        x = 2;
                        y = 2;
                    }
                    if (two == true && three == true)
                    {
                        x = 1;
                        y = 3;
                    }

                    if (AIPointAddingValidation(x, y) == false)
                    {
                        cross2PosbileWin = false;
                    }

                    if (AIPointAddingValidation(x, y) == true)
                    {
                        Program.x = x;
                        Program.y = y;
                    }
                }

                if (counter < 2)
                {
                    cross2PosbileWin = false;
                    return;
                }
                counter = 0;
                
            }
            if (XPosibleWin == false && YPosibleWin == false && cross1PosbileWin == false && cross2PosbileWin == false)
            {
                Random random = new Random();

                int d = random.Next(1, 4);
                int b = random.Next(1, 4);

                Program.x = d;
                Program.y = b;

                Console.WriteLine("Właśnie zadziałał random. Nacisniej enter.");
                Console.ReadKey();
            }
        }
        public static void WhereShouldSIPutTagX()
        {
            List<Point> currentGamerPointsX = new List<Point>();
            foreach (var point in Program.points)
            {
                if (point.gamerType == GamerType.O)
                {
                    currentGamerPointsX.Add(point);
                }
            }

            int counter = 0;

            for (int X = 1; X < 4; X++)
            {
                foreach (var point in currentGamerPointsX)
                {
                    if (point.x == X)
                    {
                        counter++;
                    }
                }

                if (counter == 2)
                {
                    int counting = 6;
                    Program.x = X;
                    foreach (var point in currentGamerPointsX)
                    {

                        if (point.x == X)
                        {
                            counting = counting - point.y;
                        }
                    }
                    Program.y = counting;
                }
            }
        }
        public static void WhereShouldSIPutTagY()
        {
            List<Point> currentGamerPointsO = new List<Point>();
            foreach (var point in Program.points)
            {
                if (point.gamerType == GamerType.O)
                {
                    currentGamerPointsO.Add(point);
                }
            }

            int counter = 0;

            for (int X = 1; X < 4; X++)
            {
                foreach (var point in currentGamerPointsO)
                {
                    if (point.x == X)
                    {
                        counter++;
                    }
                }

                if (counter == 2)
                {
                    int counting = 6;
                    Program.y = X;
                    foreach (var point in currentGamerPointsO)
                    {

                        if (point.x == X)
                        {
                            counting = counting - point.y;
                        }
                    }
                    Program.y = counting;
                }
            }
        }

        public static bool AIPointAddingValidation(int x, int y)
        {
            bool result = true;
            
            foreach (var point in Program.points)
            {
                if (point.x == x && point.y == y)
                {
                    result = false;
                }
               
            }
            return result;
        }
    }
}

