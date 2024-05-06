using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehCombat : EnemyBeh
{
    PersMove persMove;
    public EnemyBehCombat(Enemy agent) : base(agent) {}
    public override void Enter()
    {
        Debug.Log("EnterBehCom");
    }

    public override void Exit()
    {
        Debug.Log("EnterExitBehCom");
    }

    public override void Update()
    {
        Debug.Log("UpdateBehCom");
        Vector3 targetPoint = Player.Instance.transform.position;
        persMove??= agent.GetComponent<PersMove>();
        Move();
        Attack();
        void Move()
        {
            NavMeshPath path = new NavMeshPath();
                NavMesh.CalculatePath(agent.transform.position, 
                targetPoint, NavMesh.AllAreas, path);
            if(path.corners != null && path.corners.Length > 1)
            {
                Vector3 vec3 = path.corners[1] - path.corners[0];
                if(vec3.magnitude > 1f ||
                path.corners.Length >2) {
                    persMove.SetMove(vec3);
                }
                else
                {
                    persMove.SetMove(Vector3.zero);
                }
            }
        }
        void Attack()
        {
            float dist = (targetPoint - agent.transform.position).magnitude;
            if(dist > 2f) return;
            Player.Instance.SetDamage(1 * Time.deltaTime);
        }
    }
}
