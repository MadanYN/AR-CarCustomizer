using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelToggle : MonoBehaviour
{
    [SerializeField] GameObject dropdown, soundButton, wheel1, wheel2, wheel3, heightSlide, rotateSlide, scaleSlide;
    bool isOn = false;

    void Start()
    {
        /*dropdown = GameObject.Find("DropdownColours");
        soundButton = GameObject.Find("SoundButton");
        wheel1 = GameObject.Find("Wheel-1");
        wheel2 = GameObject.Find("Wheel-2");
        wheel3 = GameObject.Find("Wheel-3");
        heightSlide = GameObject.Find("HeightSlider");
        rotateSlide = GameObject.Find("RotateSlider");
        scaleSlide = GameObject.Find("ScaleSlider");*/
    }

    // Update is called once per frame
    public void onToggle()
    {
        if (isOn)
        {
            dropdown.SetActive(false);
            scaleSlide.SetActive(false);
            rotateSlide.SetActive(false);
            heightSlide.SetActive(false);
            wheel1.SetActive(false);
            wheel2.SetActive(false);
            wheel3.SetActive(false);
            soundButton.SetActive(false);

            isOn = false;
        }
        else
            dropdown.SetActive(true);
            scaleSlide.SetActive(true);
            rotateSlide.SetActive(true);
            heightSlide.SetActive(true);
            wheel1.SetActive(true);
            wheel2.SetActive(true);
            wheel3.SetActive(true);
            soundButton.SetActive(true);

            isOn = true;
    }
}
