using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public Text NameText;

    // Start is called before the first frame update
    void Start()
    {
        NameText.text = InputExample.PlayerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
