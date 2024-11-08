using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Speedup : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "SpeedupPlayer")
        {
            Debug.Log("IN");
            Destroy(other.gameObject, 0.3f);
            GameObject.Find("Player").GetComponent<PlayerController>().moveSpd += 1;
               

        }
    }
}
