namespace MonsterSlayer;
/*
The abstract Character class describes any character of the game.
Each character has a healthLevel, power, attack message, and a level starting at 1
*/
abstract class Character
{
    public int HealthLevel { get; set; }
    public int Power { get; init; }
    public int Level { get; set; } = 1;
    public string AttackMessage { get; init; } = "Character is attacking";

    // The public constructor
    public Character(int healthLevel, int power, String attackMessage)
    {
        HealthLevel = healthLevel;
        Power = power;
        AttackMessage = attackMessage;
    }

    public bool IsAlive() => HealthLevel > 0;

    // The attack method returns true if it succeeds with the attack, false otherwise
    // TODO: complete the attack method
    public virtual bool Attack(Character c)
    {
        // TODO: change the condition to "if c can fight this character, this character is alive and c is alive"
        if (this.CanFight(c) && c.IsAlive() && this.IsAlive())
        {
            string msg = this.GetType().Name + " is attacking a " + c.GetType().Name;
            msg += (c is Enemy ? " from " + ((Enemy)c).EnemyRealm : "");
            // TODO: print out msg
            Console.WriteLine(msg);
            // TODO: set the c's health level to its health level minus this character's power
            c.HealthLevel -= this.Power;
            // TODO: change the condition to "if c is not alive, this character has killed it. So print out the attack message and say c is dead"
            if (!c.IsAlive())
            {
                // TODO: print the attack message
                Console.WriteLine(AttackMessage);
                // TODO: print the class name of c + " is dead"
                Console.WriteLine($"{c.GetType().Name} is dead");
            }
            return true;
        }
        Console.WriteLine("Cannot attack");
        return false;
    }

    // This method receives another character and determines if THIS character can fight it
    // This abstract method needs to be implemented in the child classes
    public abstract bool CanFight(Character c);
}
