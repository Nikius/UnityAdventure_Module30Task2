using System;

namespace Project.Scripts
{
    [Serializable]
    public class ElfSettings: EnemySettings
    {
        public int accuracy;
        public int rangeAttack;
        public int dodge;
    }
}