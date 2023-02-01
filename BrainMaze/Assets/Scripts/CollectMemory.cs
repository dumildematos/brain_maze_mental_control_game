using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CollectMemory : MonoBehaviour
{
    // public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        // collectSound.Play();
        // Debug.Log(other.name);
        if (other.CompareTag("Player"))
        {
            Debug.Log("Collectable picked up!");
            Score.score += 50;
            Destroy(gameObject);
        }
    }
}
