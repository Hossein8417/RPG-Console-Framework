class ReLoop
{
    public static void Loop()
    {
        AppInterface.PlayAgainMessage();
        char appLoopStart;
        bool isValid = char.TryParse(AppInterface.userAction, out appLoopStart);
        if (isValid)
        {
            if (appLoopStart == 'y')
            {
                CurrentFlow.CurrentState = Flow.CharacterSelect;

            }
            if (appLoopStart == 'n')
            {
                CurrentFlow.CurrentState = Flow.Quit;
            }
        }
        else AppInterface.UserHelper();
    }
}