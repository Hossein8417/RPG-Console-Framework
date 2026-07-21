class ReLoop
{
    public static void Loop(GameData data)
    {
        AppInterface.PlayAgainMessage(data);
        char appLoopStart;
        bool isValid = char.TryParse(data.UserInput.userAction, out appLoopStart);
        if (isValid)
        {
            if (appLoopStart == 'y')
            {
                data.CurrentFlow.CurrentState = Flow.CharacterSelect;

            }
            if (appLoopStart == 'n')
            {
                data.CurrentFlow.CurrentState = Flow.Quit;
            }
        }
        else AppInterface.UserHelper();
    }
}