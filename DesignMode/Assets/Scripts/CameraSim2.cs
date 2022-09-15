using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSim2 : MonoBehaviour
{
    /*
     public float ZoomAmount = 0; //With Positive and negative values
     public float MaxToClamp = 0.5f;
     public float ROTSpeed = 10;

     void Update()
     {
         ZoomAmount += Input.GetAxis("Mouse ScrollWheel");
         ZoomAmount = Mathf.Clamp(ZoomAmount, -MaxToClamp, MaxToClamp);
         float translate = Mathf.Min(Mathf.Abs(Input.GetAxis("Mouse ScrollWheel")), MaxToClamp - Mathf.Abs(ZoomAmount));
         if (Input.GetAxis("Mouse ScrollWheel") > 0)
         { 
         gameObject.transform.Translate(0, 0, 1*translate);            //translate * ROTSpeed * Mathf.Sign(Input.GetAxis("Mouse ScrollWheel"))

     }*/
     //public GameObject gameObject;
     public float zoom = 0;
     public float maxZoom = 5;
     public float zoomSpeed = 10;
     void Update()
     {
         float y = Input.mouseScrollDelta.y;
         if (y >= 1 && zoom > -maxZoom)
         {
             gameObject.transform.Translate(0, 0, 1);
             zoom--;
         }
         else if (y <= -1 && zoom < maxZoom)
         {
             gameObject.transform.Translate(0, 0, -1);
             zoom++;
         }
     }
    /*
    public float cameraDistanceMax = 20f;
    public float cameraDistanceMin = 5f;
    public float cameraDistance = 10f;
    public float scrollSpeed = 0.5f;

    private void Update()
    {
        cameraDistance -= Input.GetAxis("Mouse ScrollWheel") * scrollSpeed;
        cameraDistance = Mathf.Clamp(cameraDistance, cameraDistanceMin, cameraDistanceMax);
    }*/
}
