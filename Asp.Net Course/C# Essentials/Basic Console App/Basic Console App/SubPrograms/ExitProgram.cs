﻿namespace Basic_Console_App.SubPrograms
{
    internal class ExitProgram : iSubProgram
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

        public static ExitProgram ReadProgram()
        {
            return (ExitProgram)new ExitProgram().Initialize();
        }

        public iSubProgram Initialize()
        {
            ExitProgram exitProgram = new()
            {
                programName = "Exit program"
            };
            return exitProgram;
        }

        public void Start(int Mode)
        {
            Environment.Exit(0);
        }
    }
}