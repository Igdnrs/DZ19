using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public static Weapons Instance;
    [SerializeField] Weapon weaponPrefab;
    [SerializeField] List<WeaponData> weaponDatas;
    void Awake()
    {
        Instance = this;
    }
    public static Weapon GetWeapon(WeaponData weaponData)
    {
        GameObject weaponGO = Instantiate(Instance.weaponPrefab.gameObject);
        Weapon weapon = weaponGO.GetComponent<Weapon>();

        GameObject visual = Instantiate(weaponData.Prefab);
        visual.transform.parent = weaponGO.transform;
        visual.transform.localPosition = Vector3.zero;

        weapon.data = weaponData;

        return weapon;
    }
}