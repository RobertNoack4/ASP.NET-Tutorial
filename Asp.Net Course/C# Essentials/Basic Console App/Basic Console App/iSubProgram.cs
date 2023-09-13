using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Console_App
{
    public interface iSubProgram
    {
        string ProgramName { get; internal set; }
        public iSubProgram Initialize();
        public void Start();
    }
}
