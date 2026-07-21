class GameData { 

    public Player Player { get; set; }

    public AI Ai { get; set; }

    public UserInput UserInput { get; set; }

    public Characters Characters { get; set; }

    public CurrentFlow CurrentFlow { get; set; }

    
    public GameData(Player player, AI ai, UserInput userInput, Characters characters, CurrentFlow currentFlow) { 
        Player = player;
        Ai = ai;
        UserInput = userInput;
        Characters = characters;
        CurrentFlow = currentFlow;
    }
}