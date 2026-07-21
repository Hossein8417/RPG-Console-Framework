class ReLoopApp
{
    public static void ReLoop()
    {
        AppInterface.PlayAgainDisplayer();

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
        else AppInterface.UserHelp();
    }
}