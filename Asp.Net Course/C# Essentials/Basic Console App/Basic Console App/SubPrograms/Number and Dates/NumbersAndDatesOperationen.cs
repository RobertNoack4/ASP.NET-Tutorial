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
            NumbersAndDatesOperationen numberAndDatesOperationen = new()
            {
                programName = "Number And Dates"
            };
            return numberAndDatesOperationen;
        }

        public void Start()
        {
            MainProgram.MainProgram.RunMainProgram(2);
        }
    }
}