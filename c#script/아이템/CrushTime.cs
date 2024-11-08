using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CrushTime : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TimePlayer")
        {
            Debug.Log("IN");
            Destroy(other.gameObject,0.3f);
            GameObject.Find("TimeOut").GetComponent<TimeAttack>().done += 10;
        }
    }
    
}
