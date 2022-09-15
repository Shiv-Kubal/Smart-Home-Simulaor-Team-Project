using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    public ParticleSystem heatParticle;
    public ParticleSystem heatOff;
    private bool heating=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        if (PowerSocket.powerOn == true && heating==false)
        {
            Instantiate(heatParticle, transform.position, heatParticle.transform.rotation);
            heating = true;
        }
        else if (PowerSocket.powerOn == true && heating == true)
        {
            Instantiate(heatOff, transform.position, heatOff.transform.rotation);
            heating = false;
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
