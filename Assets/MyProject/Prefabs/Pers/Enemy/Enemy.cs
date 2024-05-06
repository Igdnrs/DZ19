using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Char
{
    EnemyBeh behActive;
    void Start()
    {
        StartBeh();
    }
    void Update()
    {
        behActive?.Update();
    }
    void StartBeh()
    {
        behActive = new EnemyBehCalm(this);
    }
    public void SetBeh(EnemyBeh newBeh)
    {
        if(newBeh == null) return;
        behActive?.Exit();
        behActive = newBeh;
        behActive.Enter();
    }
}
