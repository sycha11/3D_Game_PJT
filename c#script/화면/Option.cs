using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Option : MonoBehaviour
{
    public void OnClickOptionBtn()
    {
        Debug.Log("Clicked Option btn");
        SceneManager.LoadScene("OptionScene");
    }

    public void OnClickExplainBtn()
    {
        Debug.Log("Clicked Option btn");
        SceneManager.LoadScene("ExplainScene");
    }

    public void OnClickStartBtn()
    {
        Debug.Log("Clicked Option btn");
        SceneManager.LoadScene("0_Start");
    }

    public void OnClickDevBtn()
    {
        Debug.Log("Clicked Option btn");
        SceneManager.LoadScene("Develope");
    }
}
