class AppStartState : IState {

    public void Run(GameData data)
    {
        AppInterface.LoadingDisplayer();
        data.CurrentFlow.CurrentState = Flow.MainMenu;
    }
}