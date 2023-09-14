namespace Basic_Console_App.SubPrograms.Number_and_Dates
{
    internal class ParseDates : iSubProgram
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

        public static ParseDates ReadProgram()
        {
            return (ParseDates)new ParseDates().Initialize();
        }

        public iSubProgram Initialize()
        {
            ParseDates parseDates = new()
            {
                programName = "Parse Dates"
            };
            return parseDates;
        }

        public void Start(int Mode)
        {
            // LinkedIn Learning Course .NET Programming with C# by Joe Marini
            // Example file for parsing dates from strings

            // Collection of various date string formats to attempt parsing
            string[] sampleDateTimes = {
                "January 1, 2025 9:30 AM",
                "1/1/2025",
                "Jan 1, 2025 7:30PM",
                "Jan 1, 25",
                "1/2025",
                "1/1 7PM",
                "Jan 1 '15",
            };

            foreach (string datestr in sampleDateTimes)
            {
                DateTime result;
                // Use the static class function TryParse to try parsing the dates
                if (DateTime.TryParse(datestr, out result))
                {
                    Console.WriteLine($"{datestr,-25} gets parsed as: {result}");
                }
                else
                {
                    Console.WriteLine($"Could not parse '{datestr}'");
                }
            }

            MainProgram.MainProgram.ReturnToMenue(Mode);
        }
    }
}