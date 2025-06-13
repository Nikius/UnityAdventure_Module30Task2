using UnityEngine;

namespace Project.Scripts
{
    public class Spawner: MonoBehaviour
    {
        [SerializeField] private Dragon _dragonPrefab;
        [SerializeField] private Elf _elfPrefab;
        [SerializeField] private Orс _orсPrefab;
        
        public Enemy Spawn(EnemySettings settings, Vector3 position)
        {
            switch (settings)
            {
                case DragonSettings dragonSettings:
                    Dragon dragon = Instantiate(_dragonPrefab, position, Quaternion.identity);
                    dragon.Initialize(dragonSettings.energy, dragonSettings.magicPower, dragonSettings.shield);
                    return dragon;
                
                case ElfSettings elfSettings:
                    Elf elf = Instantiate(_elfPrefab, position, Quaternion.identity);
                    elf.Initialize(elfSettings.accuracy, elfSettings.rangeAttack, elfSettings.dodge);
                    return elf;
                
                case OrсSettings orcSettings:
                    Orс orс = Instantiate(_orсPrefab, position, Quaternion.identity);
                    orс.Initialize(orcSettings.endurance, orcSettings.meleeAttack, orcSettings.armor);
                    return orс;
                
                default:
                    throw new System.ArgumentException("This settings is not implemented");
            }
        }
    }
}