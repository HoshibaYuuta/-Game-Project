using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeDierctor : MonoBehaviour
{
    public Text timetext;

    float timedir = 120;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //時間を表示する
        timetext.text = timedir.ToString("f0");
        //
        timedir -= Time.deltaTime;

        if (timedir <= 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }        
    }
}
