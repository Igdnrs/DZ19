using System;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    static protected List<Character> chars = new();
    [SerializeField] CharacterData charData;
    [SerializeField] protected float HP = 100;
    private Animator anim;
    public Animator ModelAnimator { get { return anim; } }
    public Action<float, float> isDamage;
    void Start(){}
    void Update(){}
    public void SetDamage(float damage)
    {
        HP -= damage;
        isDamage?.Invoke(HP, charData.MaxHP);
    }
    public void Init(CharacterData charData)
    {
        this.charData = charData;
        HP = charData.MaxHP;
        ChangeModel();
        void ChangeModel()
        {
            if (anim != null)
                Destroy(anim.gameObject);

            GameObject model = Instantiate(charData.Prefab, gameObject.transform);
            anim = model.GetComponent<Animator>();

            Weapon weapon = Weapons.GetWeapon(charData.GunData);

            Transform handR = CalcHand.FindDeepChild(model.transform, "Hand_R");

            weapon.transform.parent = handR;
            weapon.transform.localPosition = new Vector3(-0.036f, 0.1f, 0);

            Quaternion rotateWeapon = new()
            {
                eulerAngles = new Vector3(-5, 50, -90)
            };
            weapon.transform.localRotation = rotateWeapon;
        }
    }
    public static Enemy GetNewEnemy(CharacterData charData)
    {
        Enemy result = null;
        checkList();
        createNew();
        result.Init(charData);
        return result;
        void checkList()
        {
            foreach (Character character in chars)
            {
                if (character.gameObject.activeSelf ||
                    character is not Enemy)
                {
                    continue;
                }
                result = character as Enemy;
                break;
            }
        }
        void createNew()
        {
            if (result != null) return;
            GameObject enemyGO = Instantiate(Creatures.Instance.Enemy.gameObject, 
            Creatures.Instance.transform);
            result = enemyGO.GetComponent<Enemy>();
            chars.Add(result);
        }
    }
    public static Player GetNewPlayer(CharacterData charData)
    {
        Player result = null;
        checkList();
        createNew();
        result.Init(charData);
        return result;
        void checkList()
        {
            foreach (Character character in chars)
            {
                if (character.gameObject.activeSelf ||
                    character is not Player)
                {
                    continue;
                }
                result = character as Player;
                break;
            }
        }
        void createNew()
        {
            if (result != null) return;
            GameObject playerGO = Instantiate(Creatures.Instance.Player.gameObject, 
            Creatures.Instance.transform);
            result = playerGO.GetComponent<Player>();
            chars.Add(result);
        }
    }
}