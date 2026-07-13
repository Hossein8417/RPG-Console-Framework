using System;
class Program {
    public static bool AppLoop = true;
    public static void Main(string[] args)
    {

        try
        {
            while (AppLoop)
            {
                StateMachine.Machine();
            }
        }
        catch (Exception e)
        {
            throw e;
        }
    }
}