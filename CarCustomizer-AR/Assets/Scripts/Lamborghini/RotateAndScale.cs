using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateAndScale : MonoBehaviour
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


    void Start()
    {
        scaleSlider = GameObject.Find("ScaleSliderLombo").GetComponent<Slider>();
        scaleSlider.minValue = scaleMinValue;
        scaleSlider.maxValue = scaleMaxValue;

        scaleSlider.onValueChanged.AddListener(ScaleSliderUpdate);

        rotateSlider = GameObject.Find("RotateSliderLombo").GetComponent<Slider>();
        rotateSlider.minValue = rotateMinValue;
        rotateSlider.maxValue = rotateMaxValue;

        rotateSlider.onValueChanged.AddListener(RotateSliderUpdate);

        heightSlider = GameObject.Find("HeightSliderLombo").GetComponent<Slider>();
        heightSlider.minValue = heightMinValue;
        heightSlider.maxValue = heightMaxValue;

        heightSlider.onValueChanged.AddListener(HeightSliderUpdate);
    }

    // Update is called once per frame
    public void ScaleSliderUpdate(float value)
    {
        transform.localScale = new Vector3(value, value, value);
    }
    public void RotateSliderUpdate(float value)
    {
        transform.localEulerAngles = new Vector3(-90f, value, transform.rotation.z);
    }
    public void HeightSliderUpdate(float value)
    {
        transform.localPosition = new Vector3(0, value, 0);
    }
}
