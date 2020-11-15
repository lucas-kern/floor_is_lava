using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTile : MonoBehaviour
{

     public float fallSpeed = .01f;

    // Start is called before the first frame update
    void Start()
    {

    }
 
     void Update() {
      if (transform.position.y < -25) {
			Destroy(gameObject);
		}
     }

    void OnTriggerEnter(Collider other) {
        
        //on collision have the object fall
	    transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
	}
 }
