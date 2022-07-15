namespace MonsterSlayer;
class Monster : Enemy
{
    public Monster() : base(10, 4, "low_pitch_noises.mp3", 3, Enemy.Realm.UNDERWORLD) { }
}
