using UnityEngine;
using UnityEngine.UIElements;

public class Pers : MonoBehaviour
{
    [SerializeField] Rigidbody rig;
    [SerializeField] float speed = 10;
    //Положить в class Settings:
    [SerializeField] float sens = 10;
    void Start()
    {
        
    }
    void Update()
    {
        InpMouse();
    }
    void InpMouse()
    {
        Move();
        Rotate();
        void Move()
        {
            if(rig == null) return;
            float ver = Input.GetAxis("Vertical");
            float hor = Input.GetAxis("Horizontal");
            Vector3 moveDirection = new Vector3(hor, 0, ver);
            moveDirection = transform.TransformDirection(moveDirection);
            rig.AddForce(moveDirection, ForceMode.VelocityChange);
        }
        void Rotate()
        {
            float mouseX = Input.GetAxis("Mouse X")*sens;
            transform.Rotate(Vector3.up * mouseX);
        }
    }
}