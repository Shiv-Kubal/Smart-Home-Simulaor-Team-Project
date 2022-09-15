using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBellHandler : MonoBehaviour
{
    public AudioClip ring;
    public AudioSource doorbell;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        doorbell.PlayOneShot(ring, 1.0f);
    }
}
