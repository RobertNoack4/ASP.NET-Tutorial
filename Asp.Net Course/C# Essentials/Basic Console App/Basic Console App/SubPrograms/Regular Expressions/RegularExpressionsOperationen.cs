using Basic_Console_App.SubPrograms.Number_and_Dates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Console_App.SubPrograms.Regular_Expressions
{
    internal class RegularExpressionsOperationen : iSubProgram
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

        public static RegularExpressionsOperationen ReadProgram()
        {
            return (RegularExpressionsOperationen)new RegularExpressionsOperationen().Initialize();
        }

        public iSubProgram Initialize()
        {
            RegularExpressionsOperationen regularExpressionsOperationen = new()
            {
                programName = "Regular Expressions"
            };
            return regularExpressionsOperationen;
        }

        public void Start(int Mode)
        {
            MainProgram.MainProgram.RunMainProgram(4);
        }
    }
}
