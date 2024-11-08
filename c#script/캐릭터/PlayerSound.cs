using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerSound : MonoBehaviour
{
  
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ZombiePlayer")
        {
            AudioSource player = GetComponent<AudioSource>();
            player.Play();
        }
    }
}
