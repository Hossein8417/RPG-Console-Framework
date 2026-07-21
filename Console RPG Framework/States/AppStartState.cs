class AppStartState : IState {

    public void Run(GameData data)
    {
        AppInterface.LoadingDisplayer();
        //Delay(3000);
        //Console.Clear();
        data.CurrentFlow.CurrentState = Flow.MainMenu;
    }
}