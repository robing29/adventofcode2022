using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2-4,6-8
//2 - 3,4 - 5
//5 - 7,7 - 9
//2 - 8,3 - 7
//6 - 6,4 - 6
//2 - 6,4 - 8

namespace aoc2022_day4
{
    public static class Cleanup
    {
        public static bool CheckRange(int[] pair1, int[] pair2)
        {
            int pair1low = pair1[0];
            int pair1high = pair1[1];
            int pair2low = pair2[0];
            int pair2high = pair2[1];
            if (pair1low <= pair2low)
            {
                if (pair1high >= pair2high)
                {
                    return true;
                }
            }
            if (pair2low <= pair1low)
            {
                if(pair2high >= pair1high)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckOverlap(int[] pair1, int[] pair2) {
            int pair1low = pair1[0];
            int pair1high = pair1[1];
            int pair2low = pair2[0];
            int pair2high = pair2[1];
            //check if one value overlaps
            if (pair1low == pair2low || pair1low == pair2high || pair1high == pair2high || pair1high == pair2low ) {
                return true;
            }
            //check if pair1 fits into pair2
            if (pair1low > pair2low && pair1low < pair2high || pair1high < pair2high && pair1high > pair2low)
            {
                return true;
            }
            //check if pair2 fits into pair1
            if (pair2low > pair1low && pair2low < pair1high || pair2high < pair1high && pair2high > pair1low)
            {
                return true;
            }
            return false;
        }
    }
}
