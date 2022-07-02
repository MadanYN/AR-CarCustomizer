using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class InsideCar : MonoBehaviour
{
    public Vector3 pos = new Vector3(0, 0, 0);
    private GameObject cam;
    private GameObject obj;
    private void Start()
    {
        cam = GameObject.Find("ARCamera");
        //pos = GameObject.Find("Object_55").transform.position;
    }
    public void goInside()
    {
        cam.transform.position = pos;
    }

}
