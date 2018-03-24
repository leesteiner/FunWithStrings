using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStringFunctionality();
            StringConcatenation();
            EscapeChars();
            VerbatimString();
            StringEquality();
            StringEqualitySpecifyingCompareRules();

        }

        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }

        static void StringConcatenation()
        {
            Console.WriteLine("=> String Concatenation");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine();
        }

        static void EscapeChars()
        {
            Console.WriteLine("=> Escape Characters");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
            Console.WriteLine(strWithTabs);

            Console.WriteLine("Everyone loves \"Hello World!\"\a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");

            //Adds a total of 4 blank lines (then beep again!).
            Console.WriteLine("All Finished. \n\n\n\a ");
            Console.WriteLine();
        }

        static void VerbatimString()
        {
            //The following string is printed verbatim,
            //thus all escape characters are displayed.
            Console.WriteLine(@"C:\MyApp\bin\Debug");

            //White space is preserved with verbatim strings.
            string myLongString = @"This is a very
                very
                    very
                        long string";
            Console.WriteLine(myLongString);
            Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");
        }

        static void StringEquality()
        {
            Console.WriteLine("=> String equality");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            //Test these strings for equality.

            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine();
        }

        static void StringEqualitySpecifyingCompareRules()
        {
            Console.WriteLine("=> String equality (Case Insensitive:");
            string s1 = "Hello!";
            string s2 = "HELLO!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            //Check the results fo changing the default compare rules.
            Console.WriteLine("Default rules: s1={0}, s2={1}, s1.Equals(s2): {2}", s1, s2, s1.Equals(s2));
            Console.WriteLine("Ignore case: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case, Invariant Culture: s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}", s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine();
            Console.WriteLine("Default rules: s1={0}, s2={1}, s1.IndexOf(\"E\"): {2}", s1, s2, s1.IndexOf("E"));
            Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase):{0}", s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case, Invariant Culture: s1.IndexOf(\"E\", StringComparison.InvariantCulture): {0}", s1.IndexOf("E", StringComparison.InvariantCulture));
        }
    }
}
