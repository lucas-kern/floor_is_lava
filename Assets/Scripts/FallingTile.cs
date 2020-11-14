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
         transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
     }
 
    //  void OnMouseDown() {
 
    //      renderer.enabled = false;
 
    //  }
 
 }
