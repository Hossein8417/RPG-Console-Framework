using System;

class BattleState{

    public static void Battle()
    {
        AppInterface.BattleInfoDisplayer();

        Inventory.ShowCharacterInventory(Player.PlayerCharacter);
        Inventory.ShowCharacterInventory(AI.AiCharacter);

        AppInterface.HealthDisplayer(Player.PlayerCharacter);
        AppInterface.HealthDisplayer(AI.AiCharacter);

        Player.PlayerCharacter.CalculateDamage(Player.PlayerCharacter);
        AI.AiCharacter.CalculateDamage(AI.AiCharacter);

        for (int round = 1; round <= 6; round++)
        {
            AppInterface.RoundCountDisplayer(round);

            AppInterface.HealthUpdateDisplayer(Player.PlayerCharacter);
            AppInterface.HealthUpdateDisplayer(AI.AiCharacter);

            if (round == 1 || round == 3 || round == 5)//player attacks
            {
                Player.PlayerCharacter.Attack(Player.PlayerCharacter, AI.AiCharacter);
                AI.AiCharacter.Defend(AI.AiCharacter, Player.PlayerCharacter);
            }

            else if (round == 2 || round == 4 || round == 6)//ai attacks
            {
                AI.AiCharacter.Attack(AI.AiCharacter, Player.PlayerCharacter);
                Player.PlayerCharacter.Defend(Player.PlayerCharacter, AI.AiCharacter);
            }

            //Delay(1500);
            //Console.Clear();
        }
        ReLoop.Loop();
    }


}