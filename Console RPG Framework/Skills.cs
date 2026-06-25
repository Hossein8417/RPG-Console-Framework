class Skills{
    
    public int SkillLevel { get; protected set; }
    public string LevelDescription { get; protected set; }


    public Skills(int skillLevel, string description)
    {
        SkillLevel = skillLevel;
        LevelDescription = description;
    }
}

class WitcherSkill: Skills {

    public WitcherSkill(int skillLevel, string description) : base(skillLevel, description) { }
}
class AssassinSkill : Skills
{

    public AssassinSkill(int skillLevel, string description) : base(skillLevel, description) { }
}
class IronHeartSkill : Skills
{

    public IronHeartSkill(int skillLevel, string description) : base(skillLevel, description) { }
}
class WitchSkill : Skills
{

    public WitchSkill(int skillLevel, string description) : base(skillLevel, description) { }
}
class NetherBladeSkill : Skills
{

    public NetherBladeSkill(int skillLevel, string description) : base(skillLevel, description) { }
}
class AshSkill : Skills
{
    public AshSkill(int skillLevel, string description) : base(skillLevel, description) { }
}