using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderHP : MonoBehaviour
{
    void Start()
    {
        Invoke("Init", 0.5f);
    }
    [SerializeField] Slider slider;
    [SerializeField] TextMeshProUGUI text;
    void Init()
    {
        Player.Instance.isDamage += ReDraw;
    }
    void ReDraw(float hp, float maxhp)
    {
        slider.value = hp;
        slider.maxValue = maxhp;
        text.text = $"{(int)hp}/{(int)maxhp}";
    }
}