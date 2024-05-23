using UnityEngine;

public class Enemy : Character
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
        if (newBeh == null) return;
        behActive?.Exit();
        behActive = newBeh;
        behActive.Enter();
    }
}