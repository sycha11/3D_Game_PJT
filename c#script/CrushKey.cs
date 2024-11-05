using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrushKey : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            Debug.Log("IN");
            Destroy(other.gameObject, 0.3f);
            GameObject.Find("ExitKey").GetComponent<GetKey>().key += 1;


        }
    }
}
