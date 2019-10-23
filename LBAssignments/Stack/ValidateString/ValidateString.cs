using System;
using System.Collections.Generic;
using LBAssignments.Stack.CreateStack;
using System.Text;

namespace LBAssignments.Stack.ValidateString
{
    public class ValidateString
    {        
        private static Dictionary<char, char> map = new Dictionary<char, char>();       

        public static bool Validate(string str)
        {
            LBStack<char> st = new LBStack<char>();
            map.Add('}', '{');
            map.Add(')','(');
            map.Add(']', '[');

            char[] ch = str.ToCharArray();
            foreach (char c in ch)
            {
                string s = c.ToString();
                switch (s)
                {
                    case "{": 
                    case "(": 
                    case "[": st.Push(c);break;
                    case "}":                
                    case ")":
                    case "]":
                        string popped2 = st.Pop().ToString();
                        if (map[c].ToString() != popped2)
                        { return false; }
                            break;
                    default:break;
                }
                
            }
            return st.IsEmpty();
        }
    }
}
