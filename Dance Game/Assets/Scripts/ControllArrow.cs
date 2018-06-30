using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllArrow : MonoBehaviour
{
    public Collider2D perfect;
    public Collider2D good;


    public void OnTriggerEnter2d(Collider col)
    {
        if (col.gameObject.tag == "Arrow")
        {
            print("er gebeurd iets");
        }
    }




}
           
            
