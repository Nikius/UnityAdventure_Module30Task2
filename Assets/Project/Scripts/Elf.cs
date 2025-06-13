namespace Project.Scripts
{
    public class Elf: Enemy
    {
        public int Accuracy { get; private set; }
        public int RangeAttack { get; private set; }
        public int Dodge { get; private set; }

        public void Initialize(int accuracy, int rangeAttack, int dodge)
        {
            Accuracy = accuracy;
            RangeAttack = rangeAttack;
            Dodge = dodge;
        }
    }
}