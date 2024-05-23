using UnityEngine;

public class EnemyBehPatrol : EnemyBeh
{
    public EnemyBehPatrol(Enemy agent) : base(agent) {}
    public override void Enter()
    {
        Debug.Log("EnterPatrolBeh");
    }

    public override void Exit()
    {
        Debug.Log("ExitPatrolBeh");
    }

    public override void Update()
    {
        Debug.Log("UpdatePatrolBeh");
    }
}
