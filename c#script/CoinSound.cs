using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSound : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            AudioSource Coin = GetComponent<AudioSource>();
            Coin.Play();


        }
    }
}
