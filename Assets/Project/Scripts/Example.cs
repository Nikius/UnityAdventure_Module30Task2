using System.Collections.Generic;
using UnityEngine;

namespace Project.Scripts
{
    public class Example : MonoBehaviour
    {
        private const float MaxOffset = 10.0f;
        private const int CountOfEnemyByType = 3;
        
        [SerializeField] private List<DragonSettings> _dragonSettingsList;
        [SerializeField] private List<ElfSettings> _elfSettingsList;
        [SerializeField] private List<OrсSettings> _orcSettingsList;
        [SerializeField] private Spawner _spawner;

        private void Awake()
        {
            SpawnDragons();
            SpawnElves();
            SpawnOrсs();
        }

        private void SpawnOrсs()
        {
            for (var index = 0; index < CountOfEnemyByType; index++)
            {
                var orcSettings = _orcSettingsList[Random.Range(0, _orcSettingsList.Count)];
                Orс orс = (Orс)_spawner.Spawn(orcSettings, GetRandomPosition());
                Debug.Log($"Orc: endurance: {orс.Endurance}, melee attack: {orс.MeleeAttack}, armor: {orс.Armor}");
            }
        }

        private void SpawnElves()
        {
            for (var index = 0; index < CountOfEnemyByType; index++)
            {
                var elfSettings = _elfSettingsList[Random.Range(0, _elfSettingsList.Count)];
                Elf elf = (Elf)_spawner.Spawn(elfSettings, GetRandomPosition());
                Debug.Log($"Elf: accuracy: {elf.Accuracy}, range attack: {elf.RangeAttack}, dodge: {elf.Dodge}");
            }
        }

        private void SpawnDragons()
        {
            for (var index = 0; index < CountOfEnemyByType; index++)
            {
                var dragonSettings = _dragonSettingsList[Random.Range(0, _dragonSettingsList.Count)];
                Dragon dragon = (Dragon)_spawner.Spawn(dragonSettings, GetRandomPosition());
                Debug.Log($"Dragon: energy: {dragon.Energy}, magicPower: {dragon.MagicPower}, shield: {dragon.Shield}");
            }
        }

        private Vector3 GetRandomPosition() => new(Random.Range(-MaxOffset, MaxOffset), 0, Random.Range(-MaxOffset, MaxOffset));
    }
}
