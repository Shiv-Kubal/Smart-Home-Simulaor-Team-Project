using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newUI : MonoBehaviour
{
    public GameObject popup;
    public Text info;
    public GameObject Object;
    // Start is called before the first frame update
    void Start()
    {
        popup.SetActive(false);
        info.text = Object.gameObject.name + "\n" + Object.GetComponent<GUID>().itemID;
    }

}   