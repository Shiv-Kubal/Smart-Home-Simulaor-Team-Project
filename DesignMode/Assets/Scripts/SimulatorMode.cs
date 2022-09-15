using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulatorMode : MonoBehaviour
{
    public GameObject simulatorCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        simulatorCamera.SetActive(true);
        GameObject[] rooms = GameObject.FindGameObjectsWithTag("Room");
        foreach (GameObject room in rooms)
        {
            room.GetComponent<SetActiveScript>().isActive = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
