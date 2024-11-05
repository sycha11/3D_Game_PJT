using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitDoor : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Wall")
        {
            if (GameObject.Find("ExitKey").GetComponent<GetKey>().key == 1)
            {
                Debug.Log("IN");
                Destroy(other.gameObject, 0.5f);
                SceneManager.LoadScene("ExitEnd");
            }
        }
       

    }
}
