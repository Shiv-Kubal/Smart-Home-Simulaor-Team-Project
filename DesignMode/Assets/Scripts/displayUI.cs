using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayUI : MonoBehaviour
{
    public Text myText;
    public float fadeTime=10;
    public bool displayInfo;
    // Start is called before the first frame update
    void Start()
    {
        //myText = GameObject.Find("Text").GetComponent<Text>();
        myText.color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {
        FadeText();
    }
    void OnMouseOver()
    {
        displayInfo = true;
    }
    void OnMouseExit()
    {
        displayInfo = false;
    }
    void FadeText()
    {
        if (displayInfo)
        {
            myText.text = this.gameObject.name + "\n" + this.GetComponent<GUID>().itemID;
            myText.color = Color.Lerp(myText.color, Color.white, fadeTime * Time.deltaTime);
        }
        else
        {
            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
        }
    }
}
