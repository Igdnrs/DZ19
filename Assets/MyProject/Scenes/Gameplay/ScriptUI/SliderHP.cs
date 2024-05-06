using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SliderHP : MonoBehaviour
{
    #region Default Methods
        
    void Start()
    {
        Invoke("Init", 0.5f);
    }
    void Update()
    {
        
    }
    #endregion
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
