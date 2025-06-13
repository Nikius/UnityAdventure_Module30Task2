using System;

namespace Project.Scripts
{
    [Serializable]
    public class DragonSettings: EnemySettings
    {
        public int energy;
        public int magicPower;
        public int shield;
    }
}