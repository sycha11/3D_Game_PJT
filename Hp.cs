using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Hp : MonoBehaviour
{
    public Slider slider;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ZombiePlayer")
        {
            Debug.Log("IN");
            slider.value -= 10.0f;
        }
    }
}
