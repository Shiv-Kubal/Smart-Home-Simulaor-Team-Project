using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LightScripts : MonoBehaviour
{
    Light lightComponent;
    private Renderer materialColour;

    //Set the Color to white to start off
    public Color color = Color.white;


    private float variable;

    // Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light>();
        materialColour = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //turn Light ON
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.lightComponent.enabled = true;
        }

        //Turn Light OFF
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.lightComponent.enabled = false;
        }
    }

    private void OnGUI()
    {
        //Sliders for the red, green and blue components of the Color
        var materialColor = materialColour.material.color;
        materialColor.r = color.r = GUI.HorizontalSlider(new Rect(5, 40, 100, 30), color.r, 0, 1);

        materialColor.g = color.g = GUI.HorizontalSlider(new Rect(5, 80, 100, 30), color.g, 0, 1);

        materialColor.b = color.b = GUI.HorizontalSlider(new Rect(5, 120, 100, 30), color.b, 0, 1);
        

        //Set the Color of the GameObject's Material to the new Color
        lightComponent.color = color;


        //set intensity of light 

        lightComponent.intensity = GUI.HorizontalSlider(new Rect(5, 160, 100, 30), lightComponent.intensity, 0, 100);
    }
}