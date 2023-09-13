namespace Basic_Console_App.SubPrograms.Strings
{
    internal class Searching : iSubProgram
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

        public static Searching ReadProgram()
        {
            return (Searching)new Searching().Initialize();
        }

        public iSubProgram Initialize()
        {
            Searching searching = new Searching();
            searching.programName = "Searching";
            return searching;
        }

        public void Start()
        {
            // LinkedIn Learning Course .NET Programming with C# by Joe Marini
            // Example file for searching string content

            string teststr = "The quick brown Fox jumps over the lazy Dog";

            // Contains determines whether a string contains certain content
            Console.WriteLine($"{teststr.Contains("fox")}");
            Console.WriteLine($"{teststr.Contains("fox", StringComparison.CurrentCultureIgnoreCase)}");

            // StartsWith and EndsWith determine if a string starts
            // or ends with a given test string
            Console.WriteLine($"{teststr.StartsWith("the")}");
            Console.WriteLine($"{teststr.StartsWith("the", StringComparison.CurrentCultureIgnoreCase)}");
            Console.WriteLine($"{teststr.EndsWith("dog")}");
            Console.WriteLine($"{teststr.EndsWith("dog", StringComparison.CurrentCultureIgnoreCase)}");

            // IndexOf, LastIndexOf finds the index of a substring
            Console.WriteLine($"{teststr.IndexOf("the")}");
            Console.WriteLine($"{teststr.IndexOf("the", StringComparison.CurrentCultureIgnoreCase)}");
            Console.WriteLine($"{teststr.LastIndexOf("the")}");

            // Determining empty, null, or whitespace
            string str1 = null;
            string str2 = "   ";
            string str3 = String.Empty;
            Console.WriteLine($"{String.IsNullOrEmpty(str1)}");
            Console.WriteLine($"{String.IsNullOrEmpty(str3)}");
            Console.WriteLine($"{String.IsNullOrWhiteSpace(str2)}");
        }
    }
}