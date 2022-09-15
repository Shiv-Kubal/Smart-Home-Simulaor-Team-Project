using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlUI : MonoBehaviour
{
    public GameObject gameManager; //The object that holds the gameManager script.
    bool UIActive = false;
    void OnMouseDown()
    {
        if (UIActive == false)
        {
            gameManager.GetComponent<newUI>().popup.SetActive(true);
            UIActive = true;
        }
        else if(UIActive == true)
        {
            gameManager.GetComponent<newUI>().popup.SetActive(false);
            UIActive = false;
        }

    }
}
