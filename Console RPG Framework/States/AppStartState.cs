using System;

class AppStartState {

    public static void AppStart()
    {
        AppInterface.LoadingDisplayer();
        //Delay(3000);
        //Console.Clear();
        CurrentFlow.CurrentState = Flow.MainMenu;
    }
}