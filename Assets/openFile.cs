using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openFile : MonoBehaviour
{
    public string fileName = "Juggling";
    public bool enter = true;
    public bool stay = true;
    public bool exit = true;


    void Update()
    {

    }

    // stayCount allows the OnTriggerStay to be displayed less often
    // than it actually occurs.
    private float stayCount = 0.0f;
    // private void OnTriggerStay(Collider other)
    // {
    //     if (stay)
    //     {
    //         if (stayCount > 0.25f)
    //         {
    //             Debug.Log("staying");
    //             stayCount = stayCount - 0.25f;
    //         }
    //         else
    //         {
    //             stayCount = stayCount + Time.deltaTime;
    //         }
    //     }
    // }

    private void OnTriggerExit(Collider other)
    {
        if (exit)
        {
            Debug.Log("exit");
            SceneManager.LoadScene(fileName);
        }
    }
}
