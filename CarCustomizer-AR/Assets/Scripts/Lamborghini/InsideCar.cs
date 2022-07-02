using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class InsideCar : MonoBehaviour
{
    public Vector3 initPos;
    public Camera cam;
    private int pixelDistToDetect = 10;
    private bool fingerdown;
    private float _rotationY = 0;

    private void Update()
    {
        if (fingerdown == false && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            fingerdown = true;
            initPos = Input.touches[0].position;
        }
        if (fingerdown)
        {
            if (Input.touches[0].position.x > initPos.x + pixelDistToDetect)
            {
                transform.localEulerAngles = new Vector3(0, -10, 0);
                Debug.Log("right");
            }
            if (Input.touches[0].position.x < initPos.x + pixelDistToDetect)
            {
                transform.localEulerAngles = new Vector3(0, 10, 0);
            }
            if (Input.touches[0].position.y > initPos.y + pixelDistToDetect)
            {
                transform.localEulerAngles = new Vector3(10, 0, 0);
            }
            if (Input.touches[0].position.y > initPos.y + pixelDistToDetect)
            {
                transform.localEulerAngles = new Vector3(-10, 0, 0);
            }
        }
        if(fingerdown && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Ended)
        {
            fingerdown = false;
        }

        if(fingerdown==false && Input.GetMouseButton(0))
        {
            fingerdown = true;
            initPos = Input.mousePosition;
        }
        if (fingerdown)
        {
            if (Input.mousePosition.x > initPos.x + pixelDistToDetect)
            {
                _rotationY += 10;
                transform.localEulerAngles = new Vector3(0, _rotationY, 0);
                Debug.Log("Yes");
            }
        }
        if(fingerdown && Input.GetMouseButton(0))
        {
            fingerdown = false;
        }
    }

}
