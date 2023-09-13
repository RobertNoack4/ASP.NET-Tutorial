using Basic_Console_App.SubPrograms;

MainProgram.RunMainProgram();

public static class MainProgram
{
    public static void RunMainProgram()
    {
        List<iSubProgram> iSubPrograms = new List<iSubProgram>
        {
            HelloWorld.ReadProgram(),
            GarbageCollect.ReadProgram(),
        };

        for (int i = 0; i < iSubPrograms.Count; i++)
        {
            Console.WriteLine($"{i}: {iSubPrograms[i].ProgramName}");
        }

        string Input = Console.ReadLine();

        bool error = MainProgram.ConvertToNumber(Input, out int InputNumber);

        if (!error)
        {
            error = MainProgram.LadeSubProgram(InputNumber, iSubPrograms, out iSubProgram inputSubProgram);

            if (!error)
            {
                inputSubProgram.Start();
            }
            else
            {
                RunMainProgram();
            }
        }
        else
        {
            RunMainProgram();
        }
    }

    private static bool LadeSubProgram(
        int InputNumber,
        List<iSubProgram> programList,
        out iSubProgram InputSubProgram)
    {
        InputSubProgram = null;
        bool error = false;
        try
        {
            InputSubProgram = programList[InputNumber];
        }
        catch
        {
            Console.WriteLine("Bitte geben Sie eine gültige Zahl ein!");
            error = true;
        }

        return error;
    }

    private static bool ConvertToNumber(string Input, out int InputNumber)
    {
        InputNumber = -1;

        bool error = false;
        try
        {
            InputNumber = Convert.ToInt32(Input);
        }
        catch
        {
            Console.WriteLine("Bitte geben sie eine Zahl ein!");
            error = true;
        }

        return error;
    }
}