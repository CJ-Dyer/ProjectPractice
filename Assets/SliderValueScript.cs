using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueScript : MonoBehaviour
{
    public Slider MySlider;
    public Text SliderValue;

    void Update()
    {
        SliderValue.text = MySlider.value.ToString("f2");
    }
}
