using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSocket : MonoBehaviour
{ 
public ParticleSystem onParticle;
public ParticleSystem offParticle;
public static bool powerOn = false;
// Start is called before the first frame update
void Start()
{

}

private void OnMouseDown()
{
    if (powerOn == false)
    {
        Instantiate(onParticle, transform.position, onParticle.transform.rotation);
        powerOn = true;
    }

        else if (powerOn == true)
        {
            Instantiate(offParticle, transform.position, offParticle.transform.rotation);
            powerOn = false;
        }

    }
// Update is called once per frame
void Update()
{

}
}
