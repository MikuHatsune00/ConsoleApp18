using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "({}[]())";
            Console.WriteLine(Check(myString));
            Console.ReadKey();
        }
        static bool Check(string myString)
        {
            Stack<char> myStack = new Stack<char>();
            Dictionary<char, char> brackets = new Dictionary<char, char>
            {
                { '(',')'},
                { '[',']'},
                { '{','}'},

            };
            foreach (char c in myString)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    myStack.Push(brackets[c]);
                }
                if (c == ')' || c == ']' || c == '}')
                {
                    if (myStack.Count == 0  || myStack.Pop() != c)
                    {
                        return false;
                    }
                }
            }
            if (myStack.Count == 0)
            { return true; }
            else
                return false;
        }
    }
}
