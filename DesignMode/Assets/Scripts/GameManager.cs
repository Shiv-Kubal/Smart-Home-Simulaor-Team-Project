using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // UI GameObjects
    public GameObject mainMenu;
    public GameObject newOpenPropertyMenu;
    public GameObject newPropertyMenu;
    public GameObject designModeMenu;
    public GameObject simulatorMode;
    
    // Input fields
    public GameObject nameObject;
    public GameObject lengthObject;
    public GameObject widthObject;

    public TMP_InputField nameInput;
    public TMP_InputField lengthInput;
    public TMP_InputField widthInput;

    // Start is called before the first frame update
    void Start()
    {
        // Display Main Menu
        mainMenu.gameObject.SetActive(true);
        // Get references to UI Input Fields
        nameInput = nameObject.GetComponent<TMP_InputField>();
        lengthInput = lengthObject.GetComponent<TMP_InputField>();
        widthInput = widthObject.GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    // Display Design Mode Menu
    public void DesignModeMenu()
    {
        Debug.Log("Design mode button was clicked");
        mainMenu.gameObject.SetActive(false);
        newOpenPropertyMenu.gameObject.SetActive(true);
        
    }

    // Display Property Menu
    public void PropertyMenu()
    {
        Debug.Log("New property button was clicked");
        newOpenPropertyMenu.gameObject.SetActive(false);
        newPropertyMenu.gameObject.SetActive(true);
    }

    // Display New Property Menu
    public void NewProperty()
    {
        Debug.Log("OK button was clicked");
        Debug.Log("Name: " + nameInput.text + " Length: " + lengthInput.text + " Width: " + widthInput.text);
        newPropertyMenu.SetActive(false);
        designModeMenu.SetActive(true);
    }

    public void SimulatorMode()
    {
        Debug.Log("Simulator button was clicked");
        designModeMenu.SetActive(false);
        simulatorMode.SetActive(true);
    }
    
    // Quit application
    public void QuitApp()
    {
        Debug.Log("Quit button was clicked");
        Application.Quit();
    }
    
    // Open Existing Property
    public void OpenProperty()
    {
        Debug.Log("Open Property button was clicked");
        /*
        System.Diagnostics.Process p = new System.Diagnostics.Process();
        p.StartInfo = new System.Diagnostics.ProcessStartInfo("explorer.exe");
        p.Start();
        
        string path =
            "C:\\Users\\egran\\OneDrive - University of Essex\\CE292 Team Project Challenge\\ce292_team01\\Final Product\\Unity Project\\Properties\\";
        System.Diagnostics.Process.Start("explorer.exe","/select,"+ path);
        */
    }
}