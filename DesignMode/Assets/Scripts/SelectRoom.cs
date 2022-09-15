using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRoom : MonoBehaviour
{
    //Variables to select rooms to edit
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private string roomTag = "Room";

    private Transform _selection;
    private Camera topDownView;

    void Start()
    {
        topDownView = Camera.main;
        Debug.Log("Select Room script activated");
    }

    // Update is called once per frame
    void Update()
    {
        //If statement to store material of objects before highlighting them
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetChild(0).GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
            Debug.Log(_selection.ToString());
        }

        //Ray variable to get the object located at mouse position and highlight it
        Vector3 ray = topDownView.ViewportToWorldPoint(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, topDownView.transform.forward, out hit))
        {
            Debug.Log("Raycast hit: " + hit.ToString());
            Transform selection = hit.transform;
            Debug.Log("Selection: " + selection.ToString());
            Debug.Log("Tag: " + selection.gameObject.tag);
            if (selection.gameObject.CompareTag(roomTag))
            {
                Debug.Log("GameObject has tag Room.");
                Renderer selectionRenderer = selection.GetChild(0).GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    Debug.Log("Selection Renderer:" + selectionRenderer.ToString());
                    selectionRenderer.material = highlightMaterial;
                    if (Input.GetMouseButtonDown(0))
                    {
                        Instantiate(selection.gameObject);
                    }
                }
                _selection = selection.transform;
            }
            else Debug.Log("Room tag cannot be found");
        }
    }
}
