using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DesignMode : MonoBehaviour
{
    private GameManager gameManager;
    private GameObject property;
    public GameObject propertyPrefab;
    public GameObject propertyTextObject;
    private TMP_Text propertyText;

    public List<GameObject> roomTypes = new List<GameObject>();
    private int[] roomFreq;         // Room frequency array
    private GameObject newRoom;     // New Room
    private Vector3 mousePos;

    public List<GameObject> deviceTypes = new List<GameObject>();
    private int[] deviceFreq;       // Device frequency array
    private GameObject newDevice;
    
    // Room list
    // Device list

    // Start is called before the first frame update
    void Start()
    {
        // Get reference to Game Manager and create property
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        propertyText = propertyTextObject.GetComponent<TMP_Text>();
        CreateProperty();
        roomFreq = new int[4];
        deviceFreq = new int[6];

    }

    // Update is called once per frame
    void Update()
    {
    }

    // Instantiate and scale Property
    void CreateProperty()
    {
        // Vector to set scale of property based on user input
        Vector3 propertyScale = new Vector3(float.Parse(gameManager.widthInput.text),4,float.Parse(gameManager.lengthInput.text));
        
        // Instantiate property prefab and scale instantiated object
        property = Instantiate(propertyPrefab, transform.position, transform.rotation);
        property.transform.localScale = propertyScale;
        property.transform.position = new Vector3(950, 530, 0);     // Set property to a fixed location
        property.name = gameManager.nameInput.text;

        // Display property name
        Debug.Log(propertyText.text);
        propertyText.text = gameManager.nameInput.text;
    }

    // Instantiate a new Room when an option is selected from dropdown menu
    public void CreateRoom_Dropdown_IndexChanged(int index)
    {
        if (index == 0) return;
        newRoom = Instantiate(roomTypes[index - 1], property.transform);
        // Increment number of rooms of a room type and give room a unique name
        roomFreq[index - 1]++;
        newRoom.name = newRoom.name.Remove(newRoom.name.Length - 7) + roomFreq[index - 1];
    }


    public void CreateDevice_Dropdown_IndexChanged(int index)
    {
        Debug.Log("Device Index: " + index);
        if (index == 0) return;
        newDevice = Instantiate(deviceTypes[index - 1]);
        // Increment number of devices of a device type and give device a unique name
        deviceFreq[index - 1]++;
        newDevice.name = newDevice.name.Remove(newDevice.name.Length - 7) + deviceFreq[index - 1];
    }
    
    // Populate room dropdown
    
    // Populate device dropdown
    
    // Index changed method
        // Get the room/device selected
        // Get CreateRoom script component
        // Use SetPlaced method to set placed to false
}
