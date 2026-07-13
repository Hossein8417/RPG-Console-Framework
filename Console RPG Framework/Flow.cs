public enum Flow
{
    Start,
    MainMenu,
    CharacterSelect,
    Battle,
    Quit
}

class CurrentFlow {

    public static Flow CurrentState = Flow.Start;
}