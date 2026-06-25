using System.Collections.Generic;

class QuestSystem {
    public string Title { get; protected set; }
    public string Description { get; protected set; }
    public int RewardGold { get; protected set; }
    public bool IsCompleted { get; protected set; }
    public QuestSystem(string title, string description, int rewardGold, bool isCompleted)
    {
        Title = title;
        Description = description;
        RewardGold = rewardGold;
        IsCompleted = isCompleted;
    }

    public void StartQuest() { 

    }

    public void CompleteQuest()
    {

    }
}

class QuestLog {

    List<QuestSystem> quests;

}