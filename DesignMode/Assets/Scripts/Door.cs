using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float speed=3;
    public float angle;
    public Vector3 direction;
    public bool doorOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        angle = transform.eulerAngles.y;

    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Round(transform.eulerAngles.y) != angle) // If the rounded down angle of the door doesn't match our desired angle
        {
            transform.Rotate(direction * speed);
        }
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
                if (hit.transform.tag == "Door")
                {
                    {
                        if (doorOpen == false)
                        {
                            angle = 90;
                            direction = Vector3.up;
                            doorOpen = true;
                        }
                        else if (doorOpen == true)
                        {
                            angle = 0;
                            direction = -Vector3.up;
                            doorOpen = false;
                        }
                    }
            }
        }

        

    }
}
