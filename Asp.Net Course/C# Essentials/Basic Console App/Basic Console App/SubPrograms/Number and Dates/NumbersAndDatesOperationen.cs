using Basic_Console_App.SubPrograms.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Console_App.SubPrograms.Number_and_Dates
{
    internal class NumbersAndDatesOperationen : iSubProgram
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

        public static NumbersAndDatesOperationen ReadProgram()
        {
            return (NumbersAndDatesOperationen)new NumbersAndDatesOperationen().Initialize();
        }


        public iSubProgram Initialize()
        {
            NumbersAndDatesOperationen numberAndDatesOperationen = new NumbersAndDatesOperationen();
            numberAndDatesOperationen.programName = "Number And Dates";
            return numberAndDatesOperationen;

        }

        public void Start()
        {
            MainProgram.RunMainProgram(2);
        }
    }
}
