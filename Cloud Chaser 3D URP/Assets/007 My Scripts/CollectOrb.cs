using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectOrb : MonoBehaviour
{
    public AudioSource collectSound;  



    void OnTriggerEnter(Collider othoer)
    {
        collectSound.Play(); //plays audio sound
        ScoringSystem.theScore += 50;
        Destroy(gameObject);
    }
}
