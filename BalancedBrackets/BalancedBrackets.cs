using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BalancedBracketsNS
{
    public class BalancedBrackets
    {
        /**
         * The function BalancedBrackets should return true if and only if
         * the input string has a set of "balanced" brackets.
         *
         * That is, whether it consists entirely of pairs of opening/closing
         * brackets (in that order), none of which mis-nest. We consider a bracket
         * to be square-brackets: [ or ].
         *
         * The string may contain non-bracket characters as well.
         *
         * These strings have balanced brackets:
         *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
         *
         * While these do not:
         *   "[LaunchCode", "Launch]Code[", "[", "]["
         *
         * parameter str - to be validated
         * returns true if balanced, false otherwise
        */
        public static bool HasBalancedBrackets(String str)
        {
            Dictionary<char, char> bracketPair = new Dictionary<char, char> { { '[', ']' } };
            Stack<char> bracketStack = new Stack<char>();
            
           // int brackets = 0;
            try
            {
                foreach (char ch in str.ToCharArray())
                {
                    if (bracketPair.Keys.Contains(ch))
                    {
                        bracketStack.Push(ch);
                    }
                    else if (bracketPair.Values.Contains(ch))
                    {
                        if (ch == bracketPair[bracketStack.First()])
                        {
                            bracketStack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch
            {
                return false;
            }
            return bracketStack.Count == 0;
        }
    }
}
