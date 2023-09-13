using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Console_App.SubPrograms
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
            ExitProgram exitProgram = new ExitProgram();
            exitProgram.programName = "Exit program";
            return exitProgram;
        }

        public void Start()
        {
            Environment.Exit(0);
        }
    }
}
