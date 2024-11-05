using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HpUp : MonoBehaviour
{
    public Slider slider;
    public void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Kit")
        {
            Debug.Log("IN");
            Destroy(other.gameObject, 0.3f);
            slider.value +=10;
        }
    }
}
