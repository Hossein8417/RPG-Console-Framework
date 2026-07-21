using System;

class MainMenuState : IState{

    public static bool loop = true;
    public void Run(GameData data)
    {
        
        AppInterface.WelcomeDisplayer();
        while (loop)
        {
            bool menuLoop = true;
            AppInterface.PlayMenuDisplayer(data);
            
            while (menuLoop)
            {
                if (data.UserInput.input == "play" || data.UserInput.input == "1")
                {
                    data.CurrentFlow.CurrentState = Flow.CharacterSelect;
                    loop = false;
                    break;
                }

                else if (data.UserInput.input == "quit" || data.UserInput.input == "2")
                {
                    data.CurrentFlow.CurrentState = Flow.Quit;
                    loop = false;
                    break;
                }

                else
                {
                    AppInterface.UserHelper();
                    break;
                }
            }
        }
    }

}