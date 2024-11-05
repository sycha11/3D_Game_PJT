using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBut : MonoBehaviour
{
   public void OnClickStartBtn()
    {
        Debug.Log("Clicked start btn");
        SceneManager.LoadScene("SampleScene");
    }

    public void OnClickOptionBtn()
    {
        Debug.Log("Clicked Option btn");
        SceneManager.LoadScene("OptionScene");
    }
}
