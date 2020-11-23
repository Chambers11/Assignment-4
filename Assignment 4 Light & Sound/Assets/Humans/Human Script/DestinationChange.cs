using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationChange : MonoBehaviour
{
    public int xPos;
    public int zPos;


     void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Character")
        {
            xPos = Random.Range(6, 14);
            zPos = Random.Range(-14, -3);
            this.gameObject.transform.position = new Vector3(xPos, 4.0039f, zPos); 
         }
    }
}
