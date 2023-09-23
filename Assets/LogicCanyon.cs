using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicCanyon : MonoBehaviour
{
    public Slider SliderEjeX;
    public float SliderEjeXValue;
    public Text RotationEjeX;

    void Start()
    {
        SliderEjeX = GameObject.FindGameObjectWithTag("BarraX").GetComponent<Slider>();
    }

    void Update()
    {
        transform.localEulerAngles = new Vector3(0, SliderEjeXValue, 0);
        RotationEjeX.text = SliderEjeX.value.ToString("0");
    }
}
