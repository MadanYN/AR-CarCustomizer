using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarRotation : MonoBehaviour
{
    private Slider scaleSlider;
    private Slider rotateSlider;
    private Slider heightSlider;
    public float scaleMinValue;
    public float scaleMaxValue;
    public float rotateMinValue;
    public float rotateMaxValue;
    public float heightMinValue;
    public float heightMaxValue;

    private void Start()
    {
        scaleSlider = GameObject.Find("ScaleSlider").GetComponent<Slider>();
        scaleSlider.minValue = scaleMinValue;
        scaleSlider.maxValue = scaleMaxValue;

        scaleSlider.onValueChanged.AddListener(ScaleSliderUpdate);

        rotateSlider = GameObject.Find("RotateSlider").GetComponent<Slider>();
        rotateSlider.minValue = rotateMinValue;
        rotateSlider.maxValue = rotateMaxValue;

        rotateSlider.onValueChanged.AddListener(RotateSliderUpdate);

        heightSlider = GameObject.Find("HeightSlider").GetComponent<Slider>();
        heightSlider.minValue = heightMinValue;
        heightSlider.maxValue = heightMaxValue;

        heightSlider.onValueChanged.AddListener(HeightSliderUpdate);

    }


    public void ScaleSliderUpdate(float value)
    {
        transform.localScale = new Vector3(value, value, value);
    }
    public void RotateSliderUpdate(float value)
    {
        transform.localEulerAngles = new Vector3(-90f, transform.rotation.y, value);
    }
    public void HeightSliderUpdate(float value)
    {
        transform.localPosition = new Vector3(-0.42227f, value, -0.343589991f);
    }
}
