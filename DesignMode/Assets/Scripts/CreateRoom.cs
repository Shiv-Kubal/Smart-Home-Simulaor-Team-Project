using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreateRoom : MonoBehaviour
{
    private bool placed; // True if room has been placed
    private bool validPosition; // True if room position is valid, within Property
    private BoxCollider roomCollider; // Box Collider of Room gameObject

    private GameObject widthSliderGameObject;
    private Slider widthSlider; // Room width
    private TMP_Text widthText;
    private GameObject lengthSliderGameObject;
    private Slider lengthSlider; // Room length
    private TMP_Text lengthText;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        // Get reference to Game Manager
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        // Variable initialisation
        placed = false;
        roomCollider = GetComponent<BoxCollider>();

        widthSliderGameObject = GameObject.Find("Width Slider");
        lengthSliderGameObject = GameObject.Find("Length Slider");

        widthSlider = widthSliderGameObject.GetComponent<Slider>();
        lengthSlider = lengthSliderGameObject.GetComponent<Slider>();

        widthText = widthSliderGameObject.transform.GetChild(3).gameObject.GetComponent<TMP_Text>();
        lengthText = lengthSliderGameObject.transform.GetChild(3).gameObject.GetComponent<TMP_Text>();

        // Reset dimensions
        widthSlider.value = 1;
        lengthSlider.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if room has been placed
        if (!placed)
        {
            // If Room has not been placed, update position and scale
            Vector3 mousePos = Input.mousePosition;
            Vector3 roomScale = new Vector3(widthSlider.value / 100, 1, lengthSlider.value / 100);
            mousePos.z = 235f;
            transform.position = Camera.main.ScreenToWorldPoint(mousePos);
            transform.localScale = roomScale;


            // Place room using right mouse button
            if (Input.GetMouseButtonDown(1))
            {
                if (validPosition)
                {
                    placed = true;
                }

                else Debug.Log("Invalid room location");
            }
            
            // Dimensions slider keyboard control
            
            if (Input.GetKey("up"))
            {
                lengthSlider.value++;
            }
            else if (Input.GetKey("down"))
            {
                lengthSlider.value--;
            }
            else if (Input.GetKey("right"))
            {
                widthSlider.value++;
            }
            else if (Input.GetKey("left"))
            {
                widthSlider.value--;
            }
            
            // Rotate Room with 'e' and 'q'
            if (Input.GetKeyDown("e"))
            {
                transform.Rotate(0,90,0);
            }
            else if (Input.GetKeyDown("q"))
            {
                transform.Rotate(0,-90,0);
            }

            // Destroy room if 'esc' key is pressed
            if (Input.GetKeyDown("escape"))
            {
                Destroy(gameObject);
            }

            widthText.text = "Width: " + widthSlider.value/20 + " m";
            lengthText.text = "Length: " + lengthSlider.value/20 + " m";
        }
    }

    // Debug message
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Trigger Enter");
    }

    // Room is inside Property
    void OnTriggerStay(Collider other)
    {
        if (other.bounds.Contains(roomCollider.bounds.min)
            && other.bounds.Contains(roomCollider.bounds.max))
        {
            // Inside the box collider
            validPosition = true;
        }
        else validPosition = false;
    }

    // Room is outside Property
    private void OnTriggerExit(Collider other)
    {
        validPosition = false;
        //Debug.Log("Trigger Exit");
    }

    // Sets placed variable to set argument
    public void SetPlaced(bool set)
    {
        placed = set;
    }
}