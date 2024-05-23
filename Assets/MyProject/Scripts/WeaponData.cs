using UnityEngine;
[CreateAssetMenu(menuName = "Game/Weapon", fileName = "New Weapon")]
public class WeaponData : ScriptableObject
{
    [SerializeField] private float dmg;
    [SerializeField] private float cd;
    [SerializeField] public GameObject Prefab;
    public float Damage
    {
        get { return dmg; }
    }
    public float CoolDown
    {
        get { return cd; }
    }
}
