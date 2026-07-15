using System;

class QuitState {

    public static void Quit()
    {
        //Console.Clear();
        AppInterface.GoodbyeDisplayer();
        Program.AppLoop = false;
    }

}