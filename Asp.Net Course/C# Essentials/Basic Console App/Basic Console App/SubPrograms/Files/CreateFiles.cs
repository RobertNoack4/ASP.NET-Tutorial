﻿namespace Basic_Console_App.SubPrograms.Files
{
    internal class CreateFiles : iSubProgram
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

        public static CreateFiles ReadProgram()
        {
            return (CreateFiles)new CreateFiles().Initialize();
        }

        public iSubProgram Initialize()
        {
            CreateFiles createFiles = new()
            {
                programName = "Create Files"
            };
            return createFiles;
        }

        public void Start(int Mode)
        {
            // LinkedIn Learning Course .NET Programming with C# by Joe Marini
            // Creating and Deleting Files

            const string filename = "TestFile.txt";

            // Create a new file - this will overwrite any existing file
            // Use the "using" construct to automatically close the file stream
            using (StreamWriter sw = File.CreateText(filename))
            {
                sw.WriteLine("This is a text file.");
            }

            // Determine if a file exists
            Console.WriteLine(File.Exists(filename));
            if (File.Exists(filename))
            {
                // The Delete function deletes a file
                File.Delete(filename);
            }
            else
            {
                using (StreamWriter sw = File.CreateText(filename))
                {
                    sw.WriteLine("This is a text file.");
                }
            }
            Console.WriteLine(File.Exists(filename));
            MainProgram.MainProgram.ReturnToMenue(Mode);
        }
    }
}