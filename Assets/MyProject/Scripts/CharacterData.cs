using UnityEngine;
[CreateAssetMenu(menuName = "Game/Creatures/Person", fileName = "New Mob")]
public class CharacterData : ScriptableObject
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private WeaponData weaponData;
    [SerializeField] protected float MaxHealth = 100;
    public GameObject Prefab
    {
        get { return prefab; }
    }
    public WeaponData GunData
    {
        get { return weaponData; }
    }
    public float MaxHP
    {
        get { return MaxHealth; }
    }
}
