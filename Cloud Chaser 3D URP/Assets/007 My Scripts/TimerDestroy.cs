using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDestroy : MonoBehaviour
{

    public float interval; 
   void Start()
    {
        Destroy(gameObject, interval); 
    }
    
    //Below Enables a RigidBody on the gameObject 


   /* void Update()
    {
        if (interval > 0)
        {
            interval -= Time.deltaTime; 
        }
        else
        {
            enabled = false;
            gameObject.AddComponent<Rigidbody>(); 
        }
    }*/ 
}
