using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Threading;

public class ding : MonoBehaviour
{
    //public GameObject targetHandler;
    AudioSource audio;
    bool killed;

    // Start is called before the first frame update
    void Start()
    {
        killed = false;
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ding(GameObject targetHandler)
    {
        if (killed == false)
        {
            killed = true;
            Debug.Log("KILLED!");
            targetHandler.SendMessage("decrementCount");
            audio.Play();
            GetComponent<MeshRenderer>().enabled = false;
            UnityEngine.Object.Destroy(this.gameObject, 2.0f);
        }
    }
}
