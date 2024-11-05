using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Exit : MonoBehaviour
{
    
        public void OnEndBtn()
        {
            Debug.Log("Clicked End btn");
            SceneManager.LoadScene("0_Start");
        }
    
}
