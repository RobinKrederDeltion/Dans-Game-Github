using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float speed;
    

	

	void FixedUpdate () {
        transform.position += Vector3.down * Time.deltaTime * speed;
    
	
	}
}
