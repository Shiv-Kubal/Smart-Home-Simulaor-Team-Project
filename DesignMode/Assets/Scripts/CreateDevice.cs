using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CreateDevice : MonoBehaviour
{
    private bool placed; // True if room has been placed
    private bool validPosition; // True if room position is valid, within Property
    private GameObject room;
    private BoxCollider deviceCollider; // Box Collider of Room gameObject
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        // Get reference to Game Manager
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        // Variable initialisation
        placed = false;
        deviceCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if room has been placed
        if (!placed)
        {
            // If Room has not been placed, update position and scale
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 232f;
            transform.position = Camera.main.ScreenToWorldPoint(mousePos);

            // Place room using right mouse button
            if (Input.GetMouseButtonDown(1))
            {
                if (validPosition)
                {
                    placed = true;
                    gameObject.transform.parent = room.transform;
                    //property.transform.Find(room.name);
                }

                else Debug.Log("Invalid device location");
            }

            // Destroy device if 'esc' key is pressed
            if (Input.GetKeyDown("escape"))
            {
                Destroy(gameObject);
            }
        }
    }

    // Debug message
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter");
    }

    // Device is inside Property
    void OnTriggerStay(Collider other)
    {
        // Inside the box collider
        if (other.bounds.Contains(deviceCollider.bounds.min)
            && other.bounds.Contains(deviceCollider.bounds.max))
        {
            // Get room that device is placed inside
            if (other.gameObject.CompareTag("Room"))
            {
                validPosition = true;
                room = other.gameObject;
            }
            
        }
        else validPosition = false;
    }

    // Device is outside Property
    private void OnTriggerExit(Collider other)
    {
        validPosition = false;
        Debug.Log("Trigger Exit");
    }
}