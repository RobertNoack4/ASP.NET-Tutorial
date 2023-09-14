using Basic_Console_App.SubPrograms;
using Basic_Console_App.SubPrograms.Files;
using Basic_Console_App.SubPrograms.Number_and_Dates;
using Basic_Console_App.SubPrograms.Strings;
using Basic_Console_App.MainProgram;
using Basic_Console_App.SubPrograms.Regular_Expressions;

MainProgram.RunMainProgram(0);

namespace Basic_Console_App.MainProgram
{
    public static class MainProgram
    {
        public static void RunMainProgram(int Mode)
        {
            Console.Clear();
            List<iSubProgram>? iSubPrograms;

            switch (Mode)
            {
                case 0:

                    // Hauptmenü
                    iSubPrograms = new List<iSubProgram>
                    {
                        HelloWorld.ReadProgram(),
                        GarbageCollect.ReadProgram(),
                        StringOperationen.ReadProgram(),
                        NumbersAndDatesOperationen.ReadProgram(),
                        FilesOperationen.ReadProgram(),
                        RegularExpressionsOperationen.ReadProgram(),

                    };
                    break;

                case 1:

                    // String Operationen
                    iSubPrograms = new List<iSubProgram>
                    {
                        Interpolation.ReadProgram(),
                        Formating.ReadProgram(),
                        Manipulation.ReadProgram(),
                        Searching.ReadProgram(),
                    };
                    break;

                case 2:

                    // Number and Dates Operationen
                    iSubPrograms = new List<iSubProgram>
                    {
                        ParseNumbers.ReadProgram(),
                        FormatNumbers.ReadProgram(),
                        DateTimeClass.ReadProgram(),
                        FormatDates.ReadProgram(),
                        ParseDates.ReadProgram(),
                        DaysSince.ReadProgram(),
                    };
                    break;

                case 3:

                    // Files
                    iSubPrograms = new List<iSubProgram>
                    {
                        CreateFiles.ReadProgram(),
                        ReadWriteFiles.ReadProgram(),
                        FileInformation.ReadProgram(),
                        Directories.ReadProgram(),
                        FilesCollection.ReadProgram(),
                    };
                    break;

                case 4:
                    iSubPrograms = new List<iSubProgram>
                    {
                        Finding.ReadProgram(),
                        Replacing.ReadProgram(),
                    };
                    // Regular Expressions

                    break;

                default:
                    iSubPrograms = null;
                    break;
            }

            if (iSubPrograms == null || iSubPrograms.Count == 0)
            {
                MainProgram.RunMainProgram(0);
            }

            if(Mode == 0)
            {
                iSubPrograms.Add(ExitProgram.ReadProgram());
            }
            else
            {
                iSubPrograms.Add(ReturnToMainMenue.ReadProgram());
            }
           
            for (int i = 0; i < iSubPrograms.Count; i++)
            {
                Console.WriteLine($"{i}: {iSubPrograms[i].ProgramName}");
            }

            string Input = Console.ReadLine();

            bool error = MainProgram.ConvertToNumber(Input, out int InputNumber);

            if (!error)
            {
                error = MainProgram.LadeSubProgram(InputNumber, iSubPrograms, out iSubProgram inputSubProgram);

                if (!error)
                {
                    inputSubProgram.Start(Mode);
                }
                else
                {
                    Console.ReadLine();
                    RunMainProgram(0);
                }
            }
            else
            {
                Console.ReadLine();
                RunMainProgram(0);
            }
        }

        public static void ReturnToMenue(int Mode)
        {
            Console.ReadLine();
            RunMainProgram(Mode);
        }

        private static bool LadeSubProgram(
            int InputNumber,
            List<iSubProgram> programList,
            out iSubProgram InputSubProgram)
        {
            InputSubProgram = null;
            bool error = false;
            try
            {
                InputSubProgram = programList[InputNumber];
            }
            catch
            {
                Console.WriteLine("Bitte geben Sie eine gültige Zahl ein!");
                error = true;
            }

            return error;
        }

        private static bool ConvertToNumber(string Input, out int InputNumber)
        {
            InputNumber = -1;

            bool error = false;
            try
            {
                InputNumber = Convert.ToInt32(Input);
            }
            catch
            {
                Console.WriteLine("Bitte geben sie eine Zahl ein!");
                error = true;
            }

            return error;
        }
    }
}
