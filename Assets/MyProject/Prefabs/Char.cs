using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour
{
    [SerializeField] protected float HP = 100;
    /*[SerializeField]*/ protected float MaxHP = 100;
    public Action<float, float> isDamage;
    void Start()
    {
        
    }
    void Update()
    {

    }
    public void SetDamage(float damage)
    {
        HP -= damage;
        isDamage?.Invoke(HP, MaxHP);
    }
}
