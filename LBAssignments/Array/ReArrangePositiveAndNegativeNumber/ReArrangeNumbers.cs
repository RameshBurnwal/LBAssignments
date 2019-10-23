using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array.ReArrangePositiveAndNegativeNumber
{
    public class ReArrangeNumbers
    {
        //Input
        //{ -1, 2, -3, 4, 5, 6, -7, 8, 9 }
        //{ -1, 2, -3, 4, 11, 5, 6, -7, 8, 9, 13 }
        //{ -1, 2, -3, 4, 5, 6, -7, 8, 9,-5,-2,-6,-8 }
        int[] items = new int[] { -1, 2, -3, 4, 5, 6, -7, 8, 9 };

        //Output
        //{9, -7, 8, -3, 5, -1, 6, 4, 2}
        //{13, -7, 11, -3, 9, -1, 8, 6, 5, 4, 2 }
        //{9, -8, 8, -7, 5, -6, 6, -5, 4, -3, 2,-2, -1}
    }
}
