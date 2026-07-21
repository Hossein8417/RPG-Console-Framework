using System;
using System.Threading.Tasks;

class BattleState : IState{

    public void Run(GameData data)
    {
        AppInterface.BattleInfoDisplayer(data);

        Inventory.ShowCharacterInventory(data.Player.PlayerCharacter);
        Inventory.ShowCharacterInventory(data.Ai.AiCharacter);

        AppInterface.HealthDisplayer(data.Player.PlayerCharacter);
        AppInterface.HealthDisplayer(data.Ai.AiCharacter);

        

        data.Player.PlayerCharacter.CalculateDamage();
        data.Ai.AiCharacter.CalculateDamage();

        for (int round = 1; round <= 6; round++)
        {
            AppInterface.RoundCountDisplayer(round);

            AppInterface.HealthUpdateDisplayer(data.Player.PlayerCharacter);
            AppInterface.HealthUpdateDisplayer(data.Ai.AiCharacter);

            if (round == 1 || round == 3 || round == 5)//player attacks
            {
                data.Player.PlayerCharacter.Attack();
                data.Ai.AiCharacter.Defend();
                data.Ai.AiCharacter.UpdateHealth(data.Player.PlayerCharacter);
            }

            else if (round == 2 || round == 4 || round == 6)//ai attacks
            {
                data.Ai.AiCharacter.Attack();
                data.Player.PlayerCharacter.Defend();
                data.Player.PlayerCharacter.UpdateHealth(data.Ai.AiCharacter);
            }

        }
        ReLoop.Loop(data);
    }


}