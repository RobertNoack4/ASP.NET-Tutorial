using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basic_Console_App.MainProgram;

namespace Basic_Console_App.SubPrograms.Number_and_Dates
{
    internal class DaysSince : iSubProgram
    {
        private string programName;
        private int Mode;

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

        public static DaysSince ReadProgram()
        {
            return (DaysSince)new DaysSince().Initialize();
        }

        public iSubProgram Initialize()
        {
            DaysSince daysSince = new()
            {
                programName = "Days Since"
            };
            return daysSince;
        }

        public void Start(int Mode)
        {
            MainLoop();
            this.Mode = Mode;
        }

        private void MainLoop()
        {
            Console.Clear();
            Console.WriteLine("Which Date? (or 'exit')");

            string response = Console.ReadLine();

            if(response == null) 
            {
                Console.WriteLine("Bitte geben sie etwas ein!");
                Console.ReadLine();
                MainLoop();
            }
            else if(response.ToLower() == "exit")
            {
                Exit();
            }
            else if(!ConvertToDateTime(response, out DateTime dateTime))
            {
                Console.WriteLine("Bitte geben sie das Datum im Format dd.MM.yyyy ein!");
                Console.ReadLine();
                MainLoop();
            }
            else
            {
                Console.WriteLine($"That Date went by {Math.Round((DateTime.Now - dateTime).TotalDays)} days ago!");
                Console.ReadLine();
                MainLoop();
            }

        }

        private bool ConvertToDateTime(string value, out DateTime dateTime)
        {
            CultureInfo cultureInfo = new CultureInfo("de-De");
            return DateTime.TryParseExact(value,
                                          "dd.MM.yyyy",
                                          cultureInfo,
                                          DateTimeStyles.None,
                                          out dateTime);
        }

        private void Exit()
        {
            MainProgram.MainProgram.ReturnToMenue(Mode);
        }
    }
}
