namespace Project.Scripts
{
    public class Orс: Enemy
    {
        public int Endurance { get; private set; }
        public int MeleeAttack { get; private set; }
        public int Armor { get; private set; }

        public void Initialize(int endurance, int meleeAttack, int armor)
        {
            Endurance = endurance;
            MeleeAttack = meleeAttack;
            Armor = armor;
        }
    }
}