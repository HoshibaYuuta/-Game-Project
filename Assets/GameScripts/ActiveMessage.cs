using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMessage : MonoBehaviour
{
    public  GameObject Message;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MessageActive()
    {
        Message.SetActive(true);
    }
}
