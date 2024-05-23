using UnityEngine;

public class PersMove : MonoBehaviour
{
    [SerializeField] Rigidbody rig;
    //Положить в class Settings:
    [SerializeField] float sens = 10;
    Vector3 moveDir;
    float rotateXDir;
    void Update()
    {
        TestInp();
        TestMove();
    }
    void TestInp()
    {
        if(Player.Instance.gameObject != gameObject) return;
        Move();
        Rotate();
        void Move()
        {
            float ver = Input.GetAxis("Vertical");
            float hor = Input.GetAxis("Horizontal");
            Debug.Log("движение");
            moveDir = new Vector3(hor, 0, ver);
            moveDir = transform.TransformDirection(moveDir);
        }
        void Rotate()
        {
            rotateXDir = Input.GetAxis("Mouse X") * sens;
        }
    }
    void TestMove()
    {
        Movement();
        Rotate();
        void Movement()
        {
            if(moveDir == Vector3.zero || 
            rig == null) return;
            rig.AddForce(moveDir, ForceMode.VelocityChange);
            if (rig.velocity.magnitude > 5)
            {
                Vector3 velocity = rig.velocity;
                float y = velocity.y;
                velocity = velocity.normalized * 5;
                velocity.y = y;
                rig.velocity = velocity;
            }
        }
        rig.AddForce(moveDir, ForceMode.VelocityChange);
        void Rotate()
        {
            if(rotateXDir == 0) return;
            transform.Rotate(Vector3.up * rotateXDir);
            rotateXDir = 0;
        }
    }
    public void SetMove(Vector3 movDir)
    {
        movDir.y = 0;
        movDir.Normalize();
        moveDir = movDir;
    }
}