using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehCalm : EnemyBeh
{
    public EnemyBehCalm(Enemy agent) : base(agent) {}
    public override void Enter()
    {
        Debug.Log("EnterBehCalm");
    }

    public override void Exit()
    {
        Debug.Log("ExitBehCalm");
    }

    public override void Update()
    {
        Debug.Log("UpdateBehCalm");
        SeekPlayer();
        void SeekPlayer()
        {
            Vector3 playerPos = Player.Instance.transform.position;
            Vector3 toPlayer = playerPos - agent.transform.position;
            float dist = toPlayer.magnitude;
            float distMax = 10f;
            if(dist > distMax) return;
            RaycastHit hit;
            Ray ray = new Ray(agent.transform.position, toPlayer.normalized);
            Physics.Raycast(ray, out hit, distMax);
            if(hit.collider == null) return;
            if(hit.collider.gameObject != Player.Instance.gameObject) return;
            Enemy enemy = agent.GetComponent<Enemy>();
            enemy.SetBeh(new EnemyBehCombat(agent));
        }
    }
}
