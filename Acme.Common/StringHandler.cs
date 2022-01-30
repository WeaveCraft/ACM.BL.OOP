using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class StringHandler
    {

        //This adds a comment about the InsertSpaces method that we can call from the in intellisense 

        /// <summary>
        /// Inserts spaces before each capital letter in a string.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty; //initialze a result variable which will be our return value.

            if (!String.IsNullOrWhiteSpace(source)) //skip if the string is null or empty or contain space.
            {
                foreach (char letter in source) //if it finds anything, it will loop through each letter/char of the string looking for uppercase.
                {
                    if (char.IsUpper(letter)) //if it does find an uppercase it will add an " "(space) and thereafter continue.
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            result = result.Trim();
            return result;
        }
    }
}
