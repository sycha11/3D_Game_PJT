using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeAttack : MonoBehaviour
{
    public float done = 185.0f;
    public Text gui_text;
    public Text gui_text2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (done > 0f)
        {
            done -= Time.deltaTime;
            gui_text.text = "Time: " + done + "초";
            gui_text2.text = "Speed:" + GameObject.Find("Player").GetComponent<PlayerController>().moveSpd;
        }
        else
        {
            print("Time is Over");
            SceneManager.LoadScene("End");
        }
    }
    
}
