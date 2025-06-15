using System;
using UnityEngine;

namespace Project.Scripts
{
    [Serializable]
    public class ElfSettings: EnemySettings
    {
        [field: SerializeField] public int Accuracy { get; private set; }
        [field: SerializeField] public int RangeAttack { get; private set; }
        [field: SerializeField] public int Dodge { get; private set; }
    }
}