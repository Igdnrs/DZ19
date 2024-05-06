using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehDeath : EnemyBeh
{
    public EnemyBehDeath(Enemy agent) : base(agent) {}
    public override void Enter()
    {
        Debug.Log("EnterDeathBeh");
    }

    public override void Exit()
    {
        Debug.Log("ExitDeathBeh");
    }

    public override void Update()
    {
        Debug.Log("UpdateDeathBeh");
    }
}
