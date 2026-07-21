using System;
using System.Threading.Tasks;

class QuitState : IState{

    public void Run(GameData data)
    {
        //Console.Clear();
        AppInterface.GoodbyeDisplayer();
        Program.AppLoop = false;
    }

}