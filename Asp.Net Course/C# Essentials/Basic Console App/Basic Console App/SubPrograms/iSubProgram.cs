namespace Basic_Console_App.SubPrograms
{
    public interface iSubProgram
    {
        string ProgramName { get; internal set; }

        public iSubProgram Initialize();

        public void Start(int Mode);
    }
}