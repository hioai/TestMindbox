using System;

namespace ClassLibraryFigures
{
    public class Figure
    {
        public double CircleSquare (double radius)
        {
            return Math.PI * radius;
        }

        public double TriangleSquare (double[] triangleSide)
        {

            double perimeter, check, abCheck, abEdge;

            if (triangleSide[0] + triangleSide[1] > triangleSide[2] & triangleSide[0] + triangleSide[2] > triangleSide[1] & triangleSide[1] + triangleSide[2] > triangleSide[0])
            {
                Console.WriteLine("Triangle Exist");

                check = triangleSide[0];

                foreach (double a in triangleSide)
                {
                    if (a > check)
                    {
                        check = a;
                    }

                }
                abCheck = 0;
                abEdge = 0;
                foreach (double a in triangleSide)
                {
                    abCheck += Math.Pow(a, 2);
                    abEdge += a;
                }
                abCheck -= Math.Pow(check, 2);
                abEdge -= check;

                if (abCheck == check)
                {
                    return 1 / 2 * abEdge;
                }
                else
                {
                    perimeter = triangleSide.Sum() / 2;
                    return Math.Sqrt(perimeter * (perimeter - triangleSide[0]) * (perimeter - triangleSide[1]) * (perimeter - triangleSide[2]));
                }
            }
            else
            {
                Console.WriteLine("Triangle doesn't exist. Repeat enter");
                return -1;
            }
                      
            
        }
    }
}