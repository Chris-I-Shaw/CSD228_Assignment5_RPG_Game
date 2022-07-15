using System.Diagnostics;

namespace MonsterSlayer;
public class Program
{
    public static void Main(string[] args)
    {
        Warrior hero = new Warrior("Jason");
        Enemy lizard = new Lizard();
        Enemy skull = new Skeleton();
        Enemy monster = new Monster();

        hero.Attack(lizard);

        lizard.Attack(hero);
        hero.Attack(lizard);
        lizard.Attack(hero);
        hero.Attack(lizard);
        monster.Attack(hero);
        hero.Attack(skull);
        skull.Attack(hero);
        hero.Attack(skull);
        hero.Attack(skull);
        hero.Attack(monster);
        monster.Attack(hero);
        hero.Attack(monster);
        hero.Attack(monster);
    }
}
