using UnityEngine;
public class Player : Character
{
    public static Player Instance;
    void Awake() => Instance = this;
}