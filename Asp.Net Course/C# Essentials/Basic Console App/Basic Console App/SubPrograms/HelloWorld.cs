namespace Basic_Console_App.SubPrograms
{
    public class HelloWorld : iSubProgram
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

        public static HelloWorld ReadProgram()
        {
            return (HelloWorld)new HelloWorld().Initialize();
        }

        public iSubProgram Initialize()
        {
            HelloWorld helloWorld = new HelloWorld();
            helloWorld.programName = "Hello World";
            return helloWorld;
        }

        public void Start()
        {
            string response;
            Console.WriteLine("What is your name?");
            response = Console.ReadLine();
            Console.WriteLine($"Enjoy the course, {response}");

            OperatingSystem thisOs = Environment.OSVersion;
            Console.WriteLine(thisOs.Platform);
            Console.WriteLine(thisOs.VersionString);
        }
    }
}