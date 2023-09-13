namespace Basic_Console_App
{
    public interface iSubProgram
    {
        string ProgramName { get; internal set; }

        public iSubProgram Initialize();

        public void Start();
    }
}