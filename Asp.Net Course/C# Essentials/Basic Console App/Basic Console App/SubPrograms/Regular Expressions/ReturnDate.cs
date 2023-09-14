using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Basic_Console_App.SubPrograms.Regular_Expressions
{
    internal class ReturnDate : iSubProgram
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

        public static ReturnDate ReadProgram()
        {
            return (ReturnDate)new ReturnDate().Initialize();
        }

        public iSubProgram Initialize()
        {
            ReturnDate returnDate = new()
            {
                programName = "Return Date"
            };
            return returnDate;
        }

        public void Start(int Mode)
        {
            // LinkedIn Learning Course .NET Programming with C# by Joe Marini
            // Solution to programming challenge for "Reverse Date Formats"

            // Takes a date in the form mm/dd/yyyy and returns the date
            // formatted as yyyy-mm-dd. Month and day can be 1 or 2 digits,
            // and the year can be 2 or 4 digits
            static string ReverseDateFormat(string sourceDate)
            {
                const int TIMEOUT = 1000;
                try
                {
                    return Regex.Replace(sourceDate,
                           @"^(?<day>\d{1,2})/(?<mon>\d{1,2})/(?<year>\d{2,4})$",
                          "${year}-${mon}-${day}", RegexOptions.None,
                          TimeSpan.FromMilliseconds(TIMEOUT));
                }
                catch (RegexMatchTimeoutException)
                {
                    return sourceDate;
                }
            }

            do
            {
                // Ask the user for the date to convert
                Console.WriteLine("Date to Convert? (Use dd/mm/yyyy, or 'exit' to quit)");
                string inputStr = Console.ReadLine();

                if (inputStr == "exit")
                {
                    break;
                }

                // Make sure it's a valid date before we try to convert it
                DateTime result;
                if (DateTime.TryParse(inputStr, out result))
                {
                    string reverseDate = ReverseDateFormat(inputStr);
                    Console.WriteLine($"The reversed format is {reverseDate}");
                }
                else
                {
                    Console.WriteLine("That's not a valid date, try again");
                }
            } while (true);

            MainProgram.MainProgram.ReturnToMenue(Mode);
        }
    }
}
