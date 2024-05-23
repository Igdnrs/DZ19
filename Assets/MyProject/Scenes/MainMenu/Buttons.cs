using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void ButtonPlayClick()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
