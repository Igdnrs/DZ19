using UnityEngine;

public class EnemyBehPursuit : EnemyBeh
{
    public EnemyBehPursuit(Enemy agent) : base(agent) {}
    public override void Enter()
    {
        Debug.Log("EnterPurBeh");
    }

    public override void Exit()
    {
        Debug.Log("ExitPurBeh");
    }

    public override void Update()
    {
        Debug.Log("UpdatePurBeh");
    }
}
