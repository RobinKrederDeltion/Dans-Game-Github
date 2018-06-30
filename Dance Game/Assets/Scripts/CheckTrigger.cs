using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTrigger : MonoBehaviour {

    public bool perfect;

    void OnTriggerStay(Collider collision)
    {
        
        if(collision.gameObject.tag == "Arrow")
        {
            if (perfect)
            {
                collision.gameObject.GetComponent<DanceArrow>().inPerfect = true;
                
            }
            else
            {
                collision.gameObject.GetComponent<DanceArrow>().inGood = true;
                
            }
            
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Arrow")
        {
            if (perfect)
            {
                collision.gameObject.GetComponent<DanceArrow>().inPerfect = false;
                
            }
            else
            {
                collision.gameObject.GetComponent<DanceArrow>().inGood = false;
               
            }
            
        }
    }
}
