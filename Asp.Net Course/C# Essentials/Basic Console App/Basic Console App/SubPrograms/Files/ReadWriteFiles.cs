using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Console_App.SubPrograms.Files
{
    internal class ReadWriteFiles : iSubProgram
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

        public static ReadWriteFiles ReadProgram()
        {
            return (ReadWriteFiles)new ReadWriteFiles().Initialize();
        }

        public iSubProgram Initialize()
        {
            ReadWriteFiles readWriteFiles = new()
            {
                programName = "Read and Write Files"
            };
            return readWriteFiles;
        }

        public void Start(int Mode)
        {
            // LinkedIn Learning Course .NET Programming with C# by Joe Marini
            // Reading and Writing data from and to files

            // Make sure the example file exists
            const string filename = "TestFile.txt";

            // 1: WriteAllText overwrites a file with the given content
            if (!File.Exists(filename))
            {
                File.WriteAllText(filename, "This is a text file. ");
            }

            // 3: AppendAllText adds text to an existing file
            File.AppendAllText(filename, "This text gets appended to the file. ");

            // 4: A FileStream can be opened and written to until closed
            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.WriteLine("Line 1");
                sw.WriteLine("Line 2");
                sw.WriteLine("Line 3");
            }

            // 2: ReadAllText reads all the content from a file
            string content;
            content = File.ReadAllText(filename);
            File.Delete(filename);
            Console.WriteLine(content);

            MainProgram.MainProgram.ReturnToMenue(Mode);
        }
    }
}
