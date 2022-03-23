using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacterStatInfo : MonoBehaviour
{
    public Slider valueSlider;
    public Text valueText;

    public void Set(int value)
    {
        valueText.text = $"{value}";
        valueSlider.value = value;
    }
}
