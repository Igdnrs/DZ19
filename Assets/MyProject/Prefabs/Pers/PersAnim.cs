using UnityEngine;

public class PersAnim : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody rigidbody;
    const string keyAnimForwBack = "ForwardBack";
    const string keyAnimLeftRight = "LeftRight";
    Vector3 velNow;
    Vector3 velNeed;
    void Start()
    {
        
    }
    void Update()
    {
        AnimTest();
    }
    void AnimTest()
    {
        Movement();
        void Movement()
        {
            if(rigidbody.velocity != Vector3.zero)
                velNow = rigidbody.velocity;

            velNow += (velNeed - velNow) * Time.deltaTime * 10;
            Vector3 animaDirection = velNow;
            animaDirection = transform.InverseTransformDirection(animaDirection);
            animator.SetFloat(keyAnimForwBack, animaDirection.z);
            animator.SetFloat(keyAnimLeftRight, animaDirection.x);
        }
    }
}