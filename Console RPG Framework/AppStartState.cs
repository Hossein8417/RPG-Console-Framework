using System;

class AppStartState 
{
    public static void AppStart()
    {
        AppInterface.LoadingMessage();

        //Delayer.Delay(3000);
        //Console.Clear();
        CurrentFlow.CurrentState = Flow.MainMenu;
    }
}