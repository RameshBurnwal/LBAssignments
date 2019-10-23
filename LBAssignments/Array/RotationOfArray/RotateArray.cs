using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array.RotationOfArray
{
    public class RotateArray
    {

        //Given a array of length k rotate from given index n
        int[] items = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        int rotateIndex = 1;
        
        //After rotate output should be {3,4,5,6,7,1,2}

        public int[] Rotate()
        {
            int[] arr = new int[rotateIndex+1];
            int index = 0;
            for (int i = 0; i <= rotateIndex; i++)
            {
                arr[i] = items[i];
            }
            for (int i = 0; i<items.Length-rotateIndex-1; i++)
            {
                items[i] = items[rotateIndex + i+ 1];
                index++;
            }
            for (int i = 0; i <= rotateIndex; i++)
            {
                items[index] =  arr[i];
                index++;
            }

            foreach(int ele in items)
            {
                Console.WriteLine(ele.ToString());
            }
           
            return null;
        }
    }
}
