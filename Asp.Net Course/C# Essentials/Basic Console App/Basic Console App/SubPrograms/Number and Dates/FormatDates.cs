using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Console_App.SubPrograms.Number_and_Dates
{
    internal class FormatDates : iSubProgram
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

        public static FormatDates ReadProgram()
        {
            return (FormatDates)new FormatDates().Initialize();
        }


        public iSubProgram Initialize()
        {
            FormatDates formatDates = new FormatDates();
            formatDates.programName = "Format Dates";
            return formatDates;

        }

        public void Start()
        {
            // LinkedIn Learning Course .NET Programming with C# by Joe Marini
            // Example file for formatting date information

            // Define a date
            DateTime AprFools = new DateTime(2025, 4, 1, 13, 23, 30);

            // 'd' Short date: mm/dd/yyyy (or dd/mm depending on locale)
            Console.WriteLine($"{AprFools:d}");
            // 'D' Full date: mm/dd/yyyy (or dd/mm depending on locale)
            Console.WriteLine($"{AprFools:D}");

            // 'f' Full date, short time
            Console.WriteLine($"{AprFools:f}");
            // 'F' Full date, long time
            Console.WriteLine($"{AprFools:F}");

            // 'g' General date and time
            Console.WriteLine($"{AprFools:g}");
            // 'G' General date and time
            Console.WriteLine($"{AprFools:G}");

            // Format using a specific CultureInfo
            Console.WriteLine(AprFools.ToString("d", CultureInfo.CreateSpecificCulture("de-DE")));

            // Defining custom date and time formats
            Console.WriteLine($"{AprFools:dddd, MMMM d yyyy}");
            Console.WriteLine($"{AprFools:ddd h:mm:ss tt}");
            Console.WriteLine($"{AprFools:MMM d yyyy}");
        }
    }
}
