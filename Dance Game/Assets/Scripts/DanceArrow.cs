using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceArrow : MonoBehaviour {
public string inputName;
public bool inPerfect;
public bool inGood;

void FixedUpdate (){

 if (Input.GetButtonDown (inputName))
 {
      if (inPerfect == true)
      {
        print ("Perfect");
      }
      else if (inGood == true)
      {
          print ("Good");
      }
      else if (inGood == false && inPerfect == false)
      {
          print ("Miss");
      }
 }

    

}







}
