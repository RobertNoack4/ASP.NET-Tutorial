using Basic_Console_App.SubPrograms.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Console_App.SubPrograms.Number_and_Dates
{
    internal class NumberAndDatesOperationen : iSubProgram
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

        public static NumberAndDatesOperationen ReadProgram()
        {
            return (NumberAndDatesOperationen)new NumberAndDatesOperationen().Initialize();
        }


        public iSubProgram Initialize()
        {
            NumberAndDatesOperationen numberAndDatesOperationen = new NumberAndDatesOperationen();
            numberAndDatesOperationen.programName = "Number And Dates";
            return numberAndDatesOperationen;

        }

        public void Start()
        {
            MainProgram.RunMainProgram(2);
        }
    }
}
