using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurtainController : MonoBehaviour
{
    
    public float close = 1;

    public float speed = 28f;
    //public Vector3 openScale; //= 0.4; //amount of scale applied when the curtains are fully open.
    //public Vector3 closedScale;// = 0.05;//amount of scale applied when the curtains are fully closed.

    Ray ray;
    RaycastHit hit;

    private Transform left_curtain;
    private Transform right_curtain;

    void Awake()
    {
        // Start is called before the first frame update
        left_curtain = gameObject.transform.GetChild(0);
        right_curtain = gameObject.transform.GetChild(1);
    }

    void Update()
    {
        
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (close == 1)
                {
                    left_curtain.transform.Translate(Vector3.left * Time.deltaTime * speed);
                    right_curtain.transform.Translate(Vector3.left*Time.deltaTime * speed);
                    close = 0;
                }
                else
                {
                    left_curtain.transform.Translate(Vector3.right * Time.deltaTime * speed);
                    right_curtain.transform.Translate(Vector3.right*Time.deltaTime * speed);
                    close = 1;
                }
            }

           
        }
    }

}
/*private void OnMouseDown()
            {
                float scale = Mathf.Lerp(openScale, closedScale, close);

                if (left_curtain != null)
                    left_curtain.localScale = new Vector3(scale, 1, 1);
                if (right_curtain != null)
                    right_curtain.localScale = new Vector3(scale, 1, 1);
            }*/
