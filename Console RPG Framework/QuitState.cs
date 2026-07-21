using System;

class QuitState
{
    public static void Quit()
    {
        AppInterface.GoodbyeDisplayer();
        Program.AppLoop = false;
    }
}