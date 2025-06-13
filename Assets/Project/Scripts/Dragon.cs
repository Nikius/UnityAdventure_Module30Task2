namespace Project.Scripts
{
    public class Dragon: Enemy
    {
        public int Energy { get; private set; }
        public int MagicPower { get; private set; }
        public int Shield { get; private set; }

        public void Initialize(int energy, int magicPower, int shield)
        {
            Energy = energy;
            MagicPower = magicPower;
            Shield = shield;
        }
    }
}