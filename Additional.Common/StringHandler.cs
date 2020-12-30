using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// To Insert Spaces Between Words
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            // GoodMillon
            string result = String.Empty;

            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach (var letter in source)
                {
                    if (char.IsUpper(letter))
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
