using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewStart : MonoBehaviour
{
    public void OnClickStartBtn()
    {
        Debug.Log("Clicked New start btn");
        SceneManager.LoadScene("SampleScene");
    }
     
}
