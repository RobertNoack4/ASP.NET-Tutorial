namespace Basic_Console_App.SubPrograms
{
    internal class GarbageCollect : iSubProgram
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

        public static GarbageCollect ReadProgram()
        {
            return (GarbageCollect)new GarbageCollect().Initialize();
        }

        public iSubProgram Initialize()
        {
            GarbageCollect garbageCollect = new()
            {
                programName = "Garbage Collector"
            };
            return garbageCollect;
        }

        public void Start(int Mode)
        {
            // Exercise file for LinkedIn Learning Course .NET Programming with C# by Joe Marini
            // Demonstration of Garbage Collection

            void DoSomeBigOperation()
            {
                // create a large memory allocation that's only used in this function
                byte[] myArray = new byte[1000000];

                Console.WriteLine($"Allocated memory is: {GC.GetTotalMemory(false)}");
                Console.ReadLine();
            }

            // Retrieve and print the total memory allocated
            Console.WriteLine($"Allocated memory is: {GC.GetTotalMemory(false)}");
            Console.ReadLine();

            // Call the function that allocates a large memory chunk
            DoSomeBigOperation();
            // After the function completes, force a Garbage Collection
            GC.Collect();

            // Retrieve and print the updated total memory amount
            Console.WriteLine($"Allocated memory is: {GC.GetTotalMemory(false)}");

            MainProgram.MainProgram.ReturnToMenue(Mode);
        }
    }
}