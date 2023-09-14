namespace Basic_Console_App.SubPrograms.Files
{
    internal class FileInformation : iSubProgram
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

        public static FileInformation ReadProgram()
        {
            return (FileInformation)new FileInformation().Initialize();
        }

        public iSubProgram Initialize()
        {
            FileInformation fileInfo = new()
            {
                programName = "File Info"
            };
            return fileInfo;
        }

        public void Start(int Mode)
        {
            // LinkedIn Learning Course .NET Programming with C# by Joe Marini
            // Working with file information

            // Make sure the example file exists
            const string filename = "TestFile.txt";

            if (!File.Exists(filename))
            {
                using (StreamWriter sw = File.CreateText(filename))
                {
                    sw.WriteLine("This is a text file.");
                }
            }

            // Get some information about the file
            Console.WriteLine(File.GetCreationTime(filename));
            Console.WriteLine(File.GetLastWriteTime(filename));
            Console.WriteLine(File.GetLastAccessTime(filename));

            File.SetAttributes(filename, FileAttributes.ReadOnly);
            Console.WriteLine(File.GetAttributes(filename));

            // We can also get general information using a FileInfo
            try
            {
                FileInfo fi = new FileInfo(filename);
                Console.WriteLine($"{fi.Length}");
                Console.WriteLine($"{fi.Directory}");
                Console.WriteLine($"{fi.IsReadOnly}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e}");
            }

            // File information can also be manipulated
            DateTime dt = new DateTime(2020, 7, 1);
            File.SetCreationTime(filename, dt);
            Console.WriteLine(File.GetCreationTime(filename));

            MainProgram.MainProgram.ReturnToMenue(Mode);
        }
    }
}