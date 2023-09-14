using Basic_Console_App.MainProgram;

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
            StringOperationen stringOperationen = new()
            {
                programName = "String Operationen"
            };
            return stringOperationen;
        }

        public void Start(int Mode)
        {
            MainProgram.MainProgram.RunMainProgram(1);
        }
    }
}