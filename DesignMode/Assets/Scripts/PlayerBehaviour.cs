using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public GameObject parent;
   
   private int moveSpeed=2;
   public float rotateSpeed = 1f;
   Vector3 vec = new Vector3(0, 45, 0);
   Vector3 vec1 = new Vector3(45, 0, 0);
    
    
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            //Move Forward
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            
            
            //Right Arm Pivot
            parent.transform.GetChild(2).transform.localEulerAngles = new Vector3(Mathf.PingPong(Time.time * 180, 90) - 45, 0, 0);
            

            //Left Arm Pivot
            parent.transform.GetChild(1).transform.localEulerAngles = new Vector3(-Mathf.PingPong(Time.time * 180, 90) + 45, 0, 0);

            //Right Leg Pivot
            parent.transform.GetChild(5).transform.localEulerAngles = new Vector3(Mathf.PingPong(Time.time * 180, 90)-45, 0, 0);
            //Left Leg Pivot
            parent.transform.GetChild(6).transform.localEulerAngles = new Vector3(-Mathf.PingPong(Time.time * 180, 90)+45, 0, 0);


           
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            
            //Right Leg Pivot
            parent.transform.GetChild(5).transform.localEulerAngles = new Vector3(-Mathf.PingPong(Time.time * 180, 90) +45, 0, 0);
            //Left Leg Pivot
            parent.transform.GetChild(6).transform.localEulerAngles = new Vector3(Mathf.PingPong(Time.time * 180, 90) -45, 0, 0);
            

            //Right Arm Pivot
            parent.transform.GetChild(2).transform.localEulerAngles = new Vector3(-Mathf.PingPong(Time.time * 180, 90) + 45, 0, 0);
            

           // Left Arm Pivot
            parent.transform.GetChild(1).transform.localEulerAngles = new Vector3(Mathf.PingPong(Time.time * 180, 90) -45, 0, 0);


        }

        if (Input.GetKey(KeyCode.A))
        {
            //Move Left
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            //Rotate Player Left
            transform.Rotate(-vec * rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Move Right
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            //Rotate Player Right
            transform.Rotate(vec*rotateSpeed*Time.deltaTime);
            
        }




         
    }
}
