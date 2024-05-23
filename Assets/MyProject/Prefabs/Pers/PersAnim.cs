using UnityEngine;

public class PersAnim : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] Character character;

    float topWeight = 0;
    const string keyAnimForwBack = "ForwardBack";
    const string keyAnimLeftRight = "LeftRight";
    const string keyAnimHit = "Hit";
    Vector3 velNow;
    Vector3 velNeed;

    void Awake()
    {
        Init();
    }
    void Init()
    {
        character ??= gameObject.GetComponent<Character>();
        character.isDamage += PlayDamage;
    }
    void Update()
    {
        TestAnim();
    }
    void TestAnim()
    {
        Init();
        LayerUpdate();
        Movement();
        void Init()
        {
            if (animator != null) return;
            Character character = gameObject.GetComponent<Character>();
            animator = character.ModelAnimator;
        }
        void LayerUpdate()
        {
            if (topWeight > 0)
            {
                topWeight -= Time.deltaTime;
            }
            animator.SetLayerWeight(1, topWeight);
        }
        void Movement()
        {
            if (rigidbody.velocity != Vector3.zero)
                velNow = rigidbody.velocity;

            velNow += 10 * Time.deltaTime * (velNeed - velNow);
            Vector3 animaDirection = velNow;
            animaDirection = transform.InverseTransformDirection(animaDirection);
            animator.SetFloat(keyAnimForwBack, animaDirection.z);
            animator.SetFloat(keyAnimLeftRight, animaDirection.x);
        }
    }
    public void PlayDamage(float health, float healthMax)
    {
        topWeight = 1;
        animator.SetBool(keyAnimHit, true);
    }
}