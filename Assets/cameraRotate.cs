using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotate : MonoBehaviour
{
    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(0 , -1 * speed * Time.deltaTime, 0);
        } 
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(0 , speed * Time.deltaTime, 0);
        }   
    }
}

