using System;
using UnityEngine;

namespace Project.Scripts
{
    [Serializable]
    public class OrсSettings: EnemySettings
    {
        [field: SerializeField] public int Endurance { get; private set; }
        [field: SerializeField] public int MeleeAttack { get; private set; }
        [field: SerializeField] public int Armor { get; private set; }
    }
}