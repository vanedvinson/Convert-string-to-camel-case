using System;

/*Complete the method/function so that it converts dash/underscore delimited words into camel casing. 
 * The first word within the output should be capitalized only if the original word was 
 * capitalized (known as Upper Camel Case, also often referred to as Pascal case).
 */

namespace Convert_string_to_camel_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToCamelCase("the_stealth_warrior"));
            //Console.WriteLine(ToCamelCase("The-Stealth-Warrior"));


            string ToCamelCase(string str)
            {
                //Taking the string, splitting it a puting it into an array
                string[] words = str.Split('_');
                string s = words[0];

                //krenuvsi od drugog elementa u nizu radim capitalize
                for(int i = 1; i < words.Length; i++) s += char.ToUpper(words[i][0]) + words[i].Substring(1);

                //spajam sve i smestam u string
                return s;
            }
        }
    }
}
