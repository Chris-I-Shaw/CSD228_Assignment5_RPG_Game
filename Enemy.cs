namespace MonsterSlayer;

abstract class Enemy : Character
{
    // The enum used in enemies
    public enum Realm
    {
        EARTH, OUTWORLD, UNDERWORLD, VULCAN
    }

    public Realm EnemyRealm { get; init; }

    public Enemy(int healthLevel, int power, String attackMessage, int level, Realm realm) : base(healthLevel, power, attackMessage)
    {
        // TODO: set the Level
        this.Level = level;

        // TODO: assign realm to this EnemyRealm
        this.EnemyRealm = realm;

    }

    // This method determines if Enemy can fight another character.
    // Enemy can fight another character ONLY if its level is less than or equal to this level
    // and c is an instance of Warrior class (the other character is a warrior)
    public override bool CanFight(Character c)
    {
        // TODO: change the return statement to return true if level of c is <= to the level of this enemy AND 
        //  the type of c is Warrior
        return(c.Level <= Level && c is Warrior);
    }
}
