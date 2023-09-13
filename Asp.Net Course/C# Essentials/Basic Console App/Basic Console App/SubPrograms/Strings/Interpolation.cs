using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Console_App.SubPrograms.Strings
{
    internal class Interpolation : iSubProgram
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

        public static Interpolation ReadProgram()
        {
            return (Interpolation)new Interpolation().Initialize();
        }


        public iSubProgram Initialize()
        {
            Interpolation interpolation = new Interpolation();
            interpolation.programName = "Interpolation";
            return interpolation;

        }

        public void Start()
        {
            // LinkedIn Learning Course .NET Programming with C# by Joe Marini

            // String Interpolation is a feature that enables the easy insertion of data
            // and expression values into a string variable

            int a = 100;
            float b = 250.0f;
            string c = "CSharp";

            // String output the old way - using placeholders
            Console.WriteLine("The values are {0}, {1} and {2}", a, b, c);

            // Using string interpolation, the code is much easier to read
            Console.WriteLine($"The values are {a}, {b} and {c}");

            // Interpolated strings can contain expressions as well
            Console.WriteLine($"(a + b)/b is {(a + b) / b}");
            Console.WriteLine($"{c} in upper-case is {c.ToUpper()}");

            // Complex objects can be embedded in strings this way as well
            DateTime now = DateTime.Now;
            Console.WriteLine($"Today is {now}");
        }
    }
}
