using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllArrow : MonoBehaviour
{
    public Collider perfect;
    public Collider good;


    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Arrow")
        {
            print("er gebeurd iets");
        }
    }




}
           
            
