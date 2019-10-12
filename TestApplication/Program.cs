using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LearnBay Assignments");
            Console.WriteLine("1. Get Max Value");
            Console.WriteLine("2. Crate Wave using Numbers");
            Console.WriteLine("3. Reverse set of characters in a array");
            Console.WriteLine("4. Implementation of dutch flag");
            Console.WriteLine("5. Generate largest number of a given value in a array");
            Console.WriteLine("6. Find the row which has max 1's");
            Console.WriteLine("7. Find number in a matrix (rows and cols sorted)");
            Console.WriteLine("8. Spiral Printing of Martrix");
            Console.WriteLine("9. Get All duplicate numbers");
            Console.WriteLine("10. Convert string to number");
            Console.WriteLine("11. Number Of bits required");
            Console.WriteLine("12. Next Greater element in an array");
            Console.WriteLine("13. Next Greater element in an array");
            Console.WriteLine("14. Validate Palindrome");
            int Assignemnt = Convert.ToInt32(Console.ReadLine());
            switch(Assignemnt)
            {
                case 1 :
                    GetMaxValue();
                    break;
                case 2:
                    CreateWaveOfIntegers();
                    break;
                case 3:
                    ReverseSetOfCharacters();
                    break;
                case 4:
                    ImplementationOfDutchFlag();
                    break;
                case 5:
                    GenerateLargestNumber();
                    break;
                case 6:
                    GetRowHasMaximum1();
                    break;
                case 7:
                    FindNumberInMatrix();
                    break;
                case 8: GetMatrixInAsSpiral();
                    break;
                case 9: GetDuplicateNumber();
                    break;
                case 10: ConvertStringToNumber();
                    break;
                case 11: GetRequireBitsToFormANumber();
                    break;
                case 12: GetNextGreaterElement();
                    break;
                case 13:
                    GetNextGreaterElement1();
                    break;
                case 14: ValidatePalindrome();
                    break;
                default: Console.WriteLine("No Assignment specified");
                    break;
            }
            
        }

        private static void ValidatePalindrome()
        {
            int palin = 12035;
            int temp = 0;            
            int l = 0;
            int r = 0;
            bool ispalin = true;
            int digit = 0;
            while(palin>9)
            {
                temp = palin;
                digit = 1;
                while (temp > 0)
                {
                    l = temp;
                    temp = temp / 10;
                    digit = digit * 10;
                }                
                r = palin % 10;
                palin = palin % (digit/10);
                palin = palin / 10;
                if (l != r)
                {
                    ispalin = false;
                    break;
                }
            }

            Console.WriteLine("Is given number is palindrome? " + ispalin);
            Console.ReadKey();


        }

        private static void GetNextGreaterElement1()
        {
            int[] items = new int[] { 11, 13, 21, 3, 42, 5 };
            //int[] items = new int[] { 4, 5, 2, 25, 7, 32, 8, 6 };
            int l = 0;
            int r = 1;
            while (l < r && l < items.Length)
            {
                while (items[l] == 0)
                {
                    l++;
                    r = l + 1;
                    if (l == items.Length - 1)                        
                    {                        
                        break;
                    }           
                    
                }
                
                while (r < items.Length && items[l] > items[r])
                {
                    r++;
                }
                if (r < items.Length && items[r] > items[l])
                {
                    Console.WriteLine(items[l] + "----->" + items[r]);
                    items[l] = 0;                    
                    l++;
                    r = l + 1;
                }
                else if (r < items.Length && items[r] < items[l])
                {
                    l++;
                    items[l] = 0;
                }

                while (l < items.Length-1 && r >= items.Length)
                {
                    l++;
                    Console.WriteLine(items[l] + "-----> -1");
                                  
                }               

            }
        }

        private static void GetNextGreaterElement()
        {
            int[] items = new int[] { 11, 13, 21, 3, 42, 5 };
            int l = 0;
            int r = 1;
            while(l<r && l<items.Length)
            {                
                while(items[l]==0)
                {
                    if (l == items.Length-1)
                        break;
                    l++;
                    r = l + 1;
                }
                if(l==items.Length-1 && r>=items.Length)
                {
                    break;
                }                
                while(items[l] > items[r])
                {
                    r++;
                }
                if(items[r]>items[l])
                {
                    Console.WriteLine(items[l] + "----->" + items[r]);
                    items[l] = 0;
                    items[r] = 0;
                    l++;
                    r = l + 1;                    
                }                

            }

        }

        private static void GetRequireBitsToFormANumber()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int[] bits = new int[100];
            int reqBits = 0;
            while(number >= 1)
            {   
                if (number % 2 == 0)
                {
                    bits[reqBits] = 0;
                }
                else
                    bits[reqBits] = 1;
                reqBits++;
                number = number / 2;
            }

            Console.WriteLine("Required number of bits is " + reqBits);
            Console.WriteLine("And the required bits are ::- ");
            for(int i= reqBits-1 ; i >= 0;i--)
            {
                Console.WriteLine(bits[i]);
            }
            Console.ReadKey();
            
        }

        private static void ConvertStringToNumber()
        {
            string str = "-88297 248252140B12 37";
            char[] ch = str.ToCharArray();
            int i = 0;
            bool isNegative = false;
            int number = 0;
            bool valid = true;
            char[] match = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }; 
            if(ch[0] == '-')
            {
                isNegative = true;
                i++;
            }
            while(i<ch.Length)
            {
                for(int j=0; j<match.Length;j++)
                {
                    if (ch[i].ToString() != match[j].ToString())
                    {
                        valid = false; ;
                    }
                    else
                    {
                        valid = true;
                        break;
                    }
                
                }
                if (!valid)
                    break;                
                else
                    number = number * 10 + Convert.ToInt32(ch[i].ToString());
                i++;
            }
            if (isNegative)
            {
                Console.WriteLine( number * -1);
            }
            else
                Console.WriteLine(number);
            Console.ReadKey();
        }

        private static void GetDuplicateNumber()
        {
            int[] items = new int[] { 1, 2, 2, 2, 2, 4, 5, 7, 8, 8 };
            Dictionary<int, int> dup = new Dictionary<int, int>();
              
            
            for(int i=0;i<items.Length; i++ )
            {
                if (dup.ContainsKey(items[i]))
                {
                    dup[items[i]]++;
                }
                else
                    dup.Add(items[i], 1);
               
            }
            int[] duparray = dup.Where(x => x.Value > 1).Select(x=>x.Key).ToArray();
            foreach(int data in duparray)
            {
                Console.WriteLine(data);
            }
            Console.ReadKey();
            
        }

        private static void GetMatrixInAsSpiral()
        {
            
            int[,] items = new int[5, 4]{
                                            { 1, 2, 3, 4 },
                                            { 5, 6, 7, 8 },
                                            { 9, 10, 11, 12 },
                                            { 13, 14, 15, 16 },
                                            { 17, 18, 19, 20 }
                                        };
            string str = string.Empty;
            int maxHeight = items.GetLength(0);
            int maxWidth = items.GetLength(1);            
            int minHeight = 0;
            int minWidth = 0;

            
            while(minWidth < maxWidth && minHeight < maxHeight )
            {
                for(int i=minWidth; i<maxWidth; i++)
                { str = str + items[minHeight, i].ToString() + ",";
                }
                minHeight++;
                for(int j= minHeight; j<maxHeight;j++)
                {
                    str = str + items[j, maxWidth-1].ToString() + ",";
                }
                maxWidth--;
                for (int i = maxWidth; i > minWidth; i--)
                {
                    str = str + items[maxHeight-1, i-1].ToString() + ",";
                }
                maxHeight--;
                for (int i = maxHeight; i > minHeight; i--)
                {
                    str = str + items[i-1, minWidth].ToString() + ",";
                }
                minWidth++;

                
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }

        private static void FindNumberInMatrix()
        {
            int[,] items = new int[5, 5] { { 11, 21, 31, 41, 51 },
                                            { 12, 22, 32, 42, 52 },
                                            { 13, 23, 33, 43, 53 },
                                            { 14, 24, 34, 44, 54 },
                                            { 15, 25, 35, 45, 55 } };
            int m = 5; int n = 5;
            Console.WriteLine("Enter the number you want to search");
            try
            {
                bool found = false;
                int search = Convert.ToInt32(Console.ReadLine());
                for(int i =m-1; i>=0;i--)
                {
                    for(int j=0;j<n;j++)
                    {
                        if(items[i,j] == search)
                        {
                            found = true;
                            Console.WriteLine("number found at row number  " + (i+1).ToString() + "  and column number  " + (j+1).ToString());
                        }
                        else if(items[i,j] > search)
                        {
                            break;
                        }                        
                    }
                }
                if (found)
                {
                    Console.WriteLine("Search success");
                }
                else
                    Console.WriteLine("Number Not found");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("there is some issue and the error details is " + e.Message);
            }

        }
        

        private static void GetRowHasMaximum1()
        {
            int n = 3; int m = 4;
            int[,] items = new int[3, 4] {
                                            {0, 0, 0, 1}
                                            ,{1,1,1,1}
                                            ,{0,1,1,1}
                                          };
            
            
            int rownum=0;
            int right=m-1;
            for (int i = 0; i < n; i++)
            {
                while(right>=0)
                {
                    if (items[i, right] == 1)
                    {
                        right--;
                        rownum = i;
                    }
                    else break;
                }
            }
            Console.WriteLine("The maximum number or 1's is at row" + rownum);
            Console.ReadKey();
        }

        private static void GenerateLargestNumber()
        {
            int maxdigit = 0;
            string largestnumber = "";
            int index = 0;            
            int[] items = new int[] { 12, 30, 234, 65, 567, 66, 67};
            int length = items.Length;
            while ( length > 0)
            {
                for (int i = 0; i < items.Length; i++)
                {
                    int fdigit = Convert.ToInt32(items[i].ToString().Substring(0, 1));
                    if (fdigit > maxdigit)
                    {
                        maxdigit = fdigit;
                        index = i;
                    }
                    else if (fdigit == maxdigit)
                    {
                        if (items[i] % 10 > 0)
                        {
                            int fitem = Convert.ToInt32(items[i].ToString().Substring(1, 1));
                            int sitem = Convert.ToInt32(items[index].ToString().Substring(1, 1));
                            maxdigit = (fitem > sitem) ? fitem : sitem ;
                            index = (fitem > sitem) ? i : index;
                        }
                    }
                    
                }
                largestnumber = largestnumber + items[index].ToString();
                items[index] = 0; maxdigit = 0;
                length--;                
            }
            Console.WriteLine("The Largest number is " + largestnumber);
            Console.ReadKey();
        }

        private static void ImplementationOfDutchFlag()
        {
            throw new NotImplementedException();
        }

        private static void ReverseSetOfCharacters()
        {
            char[] str = new char[] { 'R','A','M','E','S','H', ' ', 'l', 'o', 'v', 'e', ' ', 'i', 'n', 'd', 'i', 'a','n'};
            int l = 0;
            int r = str.Length - 1;
            char temp;
            for (int i = 0; i < str.Length / 2; i++)
            {
                temp = str[l];
                str[l] = str[r];
                str[r] = temp;
                l++;
                r--;
            }
            int right = 0; int left = 0;
            int index;
            for (int i = 0; i < str.Length; i++)
            {
                index = i;
                if (str[i] == ' ' || i == str.Length-1)
                {
                    if (i == str.Length - 1)
                        index++;
                    for (int j = 0; j <= right / 2 ; j++)
                    {
                        temp = str[index-1];
                        str[index-1] = str[left];
                        str[left] = temp;
                        left++;
                        right--;
                        index--;
                    }
                    right = 0;
                    left = i + 1;
                }
                right++;
            }
           
            foreach (char item in str)
                Console.Write(item + " ");
            Console.ReadKey();
        }

        private static void CreateWaveOfIntegers()
        {            
            int[] items = new int[] { 1,2,3,6,7,8,4,9,5};
            int[] wave = new int[items.Length];
            GetSortedArray(ref items);
            int l = 0;
            int r = items.Length;
            int index = 0;
            for (int i = 0; i < items.Length/2+1; i++)
            {              
                l = i;
                r--;
                if (l < r)
                {
                    wave[index] = items[i];
                    wave[index + 1] = items[r];
                }
                if(i==r)
                { wave[index] = items[r]; }
                index = index + 2;
            }

            Console.WriteLine("Sorted array :: ");
            foreach (int item in items)
                Console.Write(item + " ");
            Console.WriteLine("\n Wave array :: ");
            foreach (int item in wave)
                Console.Write(item + " ");
            Console.ReadKey();
        }

        private static void GetSortedArray(ref int[] items)
        {
            int temp;
            for (int i = 0; i < items.Length - 1; i++)
            {
                for (int j = 0; j < items.Length - 1; j++)
                {
                    if (items[j] > items[j + 1])
                    {
                        temp = items[j + 1];
                        items[j + 1] = items[j];
                        items[j] = temp;
                    }
                }

            }
            
        }

        private static void GetMaxValue()
        {
            int[] items = new int[] { 1,4,2,5,6,9,2,5};
            int max=0;
            int indexAt = 0;
            int length = items.Length;
            for (int i = 0; i < length; i++)
            {
                if (max <items[i])
                {
                    max = items[i];
                    indexAt = i;
                }
            }
            Console.WriteLine(string.Format("The Max element is {0} and it is at {1} index", max, indexAt));
            Console.ReadKey();
            
            throw new NotImplementedException();
        }
    }
}
