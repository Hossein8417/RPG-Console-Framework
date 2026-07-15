using System;

class MainMenuState {

    public static bool loop = true;
    public static void MainMenu()
    {
        //loop #1
        AppInterface.WelcomeDisplayer();
        while (loop)
        {
            bool menuLoop = true;
            AppInterface.PlayMenuDisplayer();
            //loop #2
            while (menuLoop)
            {
                if (AppInterface.input == "play" || AppInterface.input == "1")
                {
                    CurrentFlow.CurrentState = Flow.CharacterSelect;
                    loop = false;
                    break;
                }

                else if (AppInterface.input == "quit" || AppInterface.input == "2")
                {
                    CurrentFlow.CurrentState = Flow.Quit;
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