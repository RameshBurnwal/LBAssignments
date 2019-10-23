using System;
using LBAssignments.Array.ReverseArrayOfString;

namespace LBAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create Stack");
            var data = Rearrange();

            Console.ReadKey();
        }

        public static int[] Rearrange()
        {
            int[] items = new int[] { -1, 2, -3, 4, 5, 6, -7, 8, 9 };
            for (int i = 1; i <= items.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (items[i-1] < 0)
                        continue;
                    else
                    {

                        for (int j = items.Length - 1; j >= 0; j--)
                        {
                            if (items[j] < 0)
                            {
                                int temp = items[i-1];
                                items[i-1] = items[j];
                                items[j] = temp;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    if (items[i-1] > 0)
                        continue;
                    else
                    {

                        for (int j = items.Length - 1; j >= 0; j--)
                        {
                            if (items[j] > 0)
                            {
                                int temp = items[i-1];
                                items[i-1] = items[j];
                                items[j] = temp;
                                break;
                            }
                        }
                    }

                }
                
            }
            return items;
        }
    }
}
