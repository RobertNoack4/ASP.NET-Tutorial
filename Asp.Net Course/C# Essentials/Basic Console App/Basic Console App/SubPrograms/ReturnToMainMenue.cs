namespace Basic_Console_App.SubPrograms
{
    internal class ReturnToMainMenue : iSubProgram
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

        public static ReturnToMainMenue ReadProgram()
        {
            return (ReturnToMainMenue)new ReturnToMainMenue().Initialize();
        }

        public iSubProgram Initialize()
        {
            ReturnToMainMenue returnToMainMenue = new()
            {
                programName = "Return to main menue"
            };
            return returnToMainMenue;
        }

        public void Start(int Mode)
        {
            MainProgram.MainProgram.RunMainProgram(0);
        }
    }
}