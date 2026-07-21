using System;

class QuitState : IState{

    public void Run(GameData data)
    {
        //Console.Clear();
        AppInterface.GoodbyeDisplayer();
        Program.AppLoop = false;
    }

}