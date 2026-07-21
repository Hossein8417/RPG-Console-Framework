using System;
class Program {
    public static bool AppLoop = true;

    
    public static void Main(string[] args)
    {
        Player player = new Player();
        AI ai = new AI();
        UserInput userInput = new UserInput();
        Characters characters = new Characters();
        CurrentFlow currentFlow = new CurrentFlow();
        StateMachine stateMachine = new StateMachine();
        

        GameData gameData = new GameData(player, ai, userInput, characters, currentFlow);
       
        while (AppLoop)
        {
            stateMachine.Machine(gameData);
        }
    }
}