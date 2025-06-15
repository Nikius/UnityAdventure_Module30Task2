using System;
using UnityEngine;

namespace Project.Scripts
{
    [Serializable]
    public class DragonSettings: EnemySettings
    {
        [field: SerializeField] public int Energy { get; private set; }
        [field: SerializeField] public int MagicPower { get; private set; }
        [field: SerializeField] public int Shield { get; private set; }
    }
}