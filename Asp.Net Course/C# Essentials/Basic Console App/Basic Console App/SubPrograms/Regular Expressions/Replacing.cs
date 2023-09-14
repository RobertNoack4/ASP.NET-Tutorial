using System.Text.RegularExpressions;

namespace Basic_Console_App.SubPrograms.Regular_Expressions
{
    internal class Replacing : iSubProgram
    {
        private string programName;

        string iSubProgram.ProgramName
        {
            get
            {
                return programName;
            }
            set
            {
                programName = value;
            }
        }

        public static Replacing ReadProgram()
        {
            return (Replacing)new Replacing().Initialize();
        }

        public iSubProgram Initialize()
        {
            Replacing replacing = new()
            {
                programName = "Replacing"
            };
            return replacing;
        }

        public void Start(int Mode)
        {
            // LinkedIn Learning Course .NET Programming with C# by Joe Marini
            // Example file for Replacing content with Regexes

            string teststr1 = "The quick brown Fox jumps over the lazy Dog";

            Regex CapWords = new Regex(@"[A-Z]\w+");

            // Regular expressions can be used to replace content in strings
            // in addition to just searching for content
            string result = CapWords.Replace(teststr1, "***");
            Console.WriteLine(teststr1);
            Console.WriteLine(result);

            // Replacement text can be generated on the fly using MatchEvaluator
            // This is a delegate that computes the new value of the replacement
            string MakeUpper(Match m)
            {
                string s = m.ToString();
                if (m.Index == 0)
                {
                    return s;
                }
                return s.ToUpper();
            }

            string upperstr = CapWords.Replace(teststr1, new MatchEvaluator(MakeUpper));
            Console.WriteLine(teststr1);
            Console.WriteLine(upperstr);

            MainProgram.MainProgram.ReturnToMenue(Mode);
        }
    }
}