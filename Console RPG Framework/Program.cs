using System;
class Program {
    public static bool AppLoop = true;
    public static void Main(string[] args)
    {

        try
        {
            while (AppLoop)
            {
                AppFlow.SectionSwitcher();
            }
        }
        catch (Exception e)
        {
            throw e;
        }
    }
}