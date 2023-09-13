using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Console_App.SubPrograms.Strings
{
    internal class StringOperationen : iSubProgram
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

        public static StringOperationen ReadProgram()
        {
            return (StringOperationen)new StringOperationen().Initialize();
        }


        public iSubProgram Initialize()
        {
            StringOperationen stringOperationen = new StringOperationen();
            stringOperationen.programName = "String Operationen";
            return stringOperationen;

        }

        public void Start()
        {
            MainProgram.RunMainProgram(1);
        }
    }
}
