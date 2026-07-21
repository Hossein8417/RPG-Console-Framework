public enum Flow
{
    Start,
    MainMenu,
    CharacterSelect,
    Battle,
    Quit
}

class CurrentFlow {

    public Flow CurrentState = Flow.Start;
}