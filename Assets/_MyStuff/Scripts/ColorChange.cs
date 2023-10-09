using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    
    public Material colorRed, colorBlue, colorWhite;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    
    //  OnTriggerEnter was not the right way this time

    //  private void OnTriggerEnter(Collider other)
    //  {
    //        gameObject.GetComponent<MeshRenderer>().material = colorBlue;
    //  }
    

    //OnTrigger below changes color of the vubes along the path the player drives
    //I did not havetime to make it the way I wanted so I took a Bad approach to just get it done and to see the result
    //A friend wanted me to do it also since I hade talked about it earlier ;)
    private void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<MeshRenderer>().material = colorWhite;
    }
    
    private void OnTriggerStay(Collider other)
    {
        gameObject.GetComponent<MeshRenderer>().material = colorBlue;
    }


}
