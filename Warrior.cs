namespace MonsterSlayer;
class Warrior : Character
{

    private int exp = 1;
    private string WarriorName { get; init; }

    public Warrior(String warriorName) : base(10, 4, "you_shall_perish.mp3")
    {
        this.WarriorName = warriorName;
    }

    public override bool CanFight(Character c) =>
        c.Level <= Level && c is Enemy;

    // This attack method will increase the warrior's Level after every 3 attacks
    public override bool Attack(Character c)
    {
        // TODO: if calling base.Attack(c) returns true, we need to increment the experience counter
        if (base.Attack(c))
        {
            // TODO: increment the exp
            exp++;
            // TODO: if exp is a multiple of 3 we want to increment the level, print out the appropriate messages
            /// and reset the exp to 1
            if (exp % 3 == 0)
            {
                // TODO: print out "{WarriorName} is leveling up!""
                Console.WriteLine($"{WarriorName} is leveling up!");
                
                // TODO: increase the level by one
                this.Level++;

                Console.WriteLine("New level : " + Level);
                // TODO: set the exp back to 1
                exp = 1;
            }
            return true;
        }
        return false;
    }
}
