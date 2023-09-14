using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Basic_Console_App.SubPrograms.Regular_Expressions
{
    internal class Timeouts : iSubProgram
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

        public static Timeouts ReadProgram()
        {
            return (Timeouts)new Timeouts().Initialize();
        }

        public iSubProgram Initialize()
        {
            Timeouts timeouts = new()
            {
                programName = "Timeouts"
            };
            return timeouts;
        }

        public void Start(int Mode)
        {
            // LinkedIn Learning Course .NET Programming with C# by Joe Marini
            // Using Timeout settings for RegEx in .NET

            const int MAX_REGEX_TIME = 1000; // Timeout value in milliseconds
            const string thestr = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            // Use a Stopwatch to show elapsed time
            Stopwatch sw;

            // Use a Timeout value when executing RegEx to guard against bad input
            TimeSpan Timeout = TimeSpan.FromMilliseconds(MAX_REGEX_TIME);

            // Run the expression and output the result
            try
            {
                sw = Stopwatch.StartNew();
                Regex CapWords = new Regex(@"(a+a+)+b", RegexOptions.None, Timeout);
                MatchCollection mc = CapWords.Matches(thestr);
                sw.Stop();
                Console.WriteLine($"Found {mc.Count} matches in {sw.Elapsed} time:");
                foreach (Match match in mc)
                {
                    Console.WriteLine($"'{match.Value}' found at position {match.Index}");
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                Console.WriteLine($"The Regex took too long to execute! {e.MatchTimeout}");
            }

            MainProgram.MainProgram.ReturnToMenue(Mode);
        }
    }
}