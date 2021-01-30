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
        public static int[] ValidXLocations = new int[8];
        public static int[] ValidYLocations = new int[8];

        public static List<Pawn> ActivePawns     = new List<Pawn>();

        public static bool ValidPositionToMove(Point newLocation, bool isWhite)
        {
            foreach (Pawn pawn in ActivePawns)
            {
                if (!(pawn.Location == newLocation && isWhite != pawn.isWhite))
                    return false;
            }

            return true;
        }

        public static void InitializeVariables()
        {
            for (int i = 0; i < 8; i++)
                ValidXLocations[i] = 14 + 94 * i;

            for (int j = 0; j < 8; j++)
                ValidYLocations[j] = 14 + 94 * j;
        }

        public static Pawn GetPawnByLocation(Point location)
        {
            var PawnLocations = (from pawn in ActivePawns select pawn.Location).ToList();

            int i = 0;
            int pos = -1;
            int LowestDX = 10000;
            foreach (Point p in PawnLocations)
            {
                int DX = Math.Abs(p.X - location.X);
                int DY = Math.Abs(p.Y - location.Y);

                int Difference = Math.Abs(DX - DY);
                if (Difference < LowestDX)
                {
                    LowestDX = Difference;
                    pos = i;
                }
                    
                i++;
            }

            if (i == -1)
                return null;

            return ActivePawns[pos];
        }
        
    }
}
