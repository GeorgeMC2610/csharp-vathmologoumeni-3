using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_vathmologoumeni_3
{
    static class Chessboard
    {
        public static int[] ValidXLocations  = new int[8];
        public static int[] ValidYLocations  = new int[8];
        public static List<Point> ValidPoints = new List<Point>();
        //public static List<Point> ValidClickPoints = new List<Point>();

        public static List<Pawn> ActivePawns = new List<Pawn>();

        /// <summary>
        /// Initializes all variables associated with the <see cref="Chessboard"/> class.
        /// </summary>
        public static void InitializeVariables()
        {
            for (int i = 0; i < 8; i++)
                ValidXLocations[i] = 14 + 94 * i;

            for (int j = 0; j < 8; j++)
                ValidYLocations[j] = 14 + 94 * j;

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    ValidPoints.Add(new Point(ValidXLocations[i], ValidYLocations[j]));

            /*for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    ValidClickPoints.Add(new Point(58 + 94 * i, 58 + 94 * j));*/
        }
   
        /// <summary>
        /// Gets the coordinates of any point in the <see cref="Chessboard"/> (most likely the mouse's coordinates).
        /// </summary>
        /// <param name="clicked"></param>
        /// <returns>The closest valid point of the <see cref="Chessboard.ValidClickPoints"/>.</returns>
        /*public static Point GetLocationByClick(Point clicked)
        {
            int i = 0;
            int pos = -1;
            double LowestDistance = int.MaxValue;
            foreach (Point p in ValidClickPoints)
            {
                double Difference = Math.Pow(p.X - clicked.X, 2) + Math.Pow(p.Y - clicked.Y, 2);

                if (Difference < LowestDistance)
                {
                    LowestDistance = Difference;
                    pos = i;
                }

                i++;
            }

            return ValidPoints[pos];
        }*/
    }
}
