using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTrigger : MonoBehaviour {

    public bool perfect;

    void OnTriggerStay2D(Collider2D collision)
    {
        print("check");
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
            print(1);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
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
            print(2);
        }
    }
}
