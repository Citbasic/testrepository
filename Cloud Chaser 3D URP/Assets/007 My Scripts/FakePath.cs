using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakePath : MonoBehaviour {
    public bool isFake;
    public float check = 0.2f;
    private Rigidbody myRB;

    public GameObject otherPlatform; 

    void Start() {
        myRB = GetComponent<Rigidbody>();
        myRB.isKinematic = true;

        // Set check to random between 0...1
        /**if (check > 0.50) {
            isFake = true;
        } else {
            isFake = false; 
        }**/

        
    }

    void OnTriggerEnter(Collider hit) {
        Debug.Log("COLLIDING");
        if (hit.transform.tag == "Player" && isFake) {
            myRB.isKinematic = false; 
        }
    }

}
