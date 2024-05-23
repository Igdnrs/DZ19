using UnityEngine;

public class Creatures : MonoBehaviour
{
    [SerializeField] Enemy enemy;
    [SerializeField] Player player;
    public Enemy Enemy { get { return enemy; } }
    public Player Player { get { return player;}}
    public static Creatures Instance;
    private void Awake()
    {
        Instance = this;
    }
    void Start(){}
    void Update(){}
}
