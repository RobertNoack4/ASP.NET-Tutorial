using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Console_App.SubPrograms.Files
{
    internal class FilesOperationen : iSubProgram
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

        public static FilesOperationen ReadProgram()
        {
            return (FilesOperationen)new FilesOperationen().Initialize();
        }

        public iSubProgram Initialize()
        {
            FilesOperationen helloWorld = new()
            {
                programName = "Files"
            };
            return helloWorld;
        }

        public void Start()
        {
            MainProgram.RunMainProgram(3);
        }
    }
}
