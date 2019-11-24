using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Leap;
using Leap.Unity;
public class fireBullet : MonoBehaviour
{
    HandModel hand_model;
    Hand leap_hand;
    LineRenderer line;
    AudioSource audio;
    public GameObject targetHandler;

    void Start()
    {
        hand_model = GetComponent<HandModel>();
        audio = GetComponent<AudioSource>();
        leap_hand = hand_model.GetLeapHand();
        if (leap_hand == null) Debug.LogError("No leap_hand founded");
    }

    void Update()
    {
        FingerModel finger = hand_model.fingers[1];

        line = GetComponent<LineRenderer>();
        RaycastHit hit;
        Debug.DrawRay(finger.GetTipPosition(), finger.GetRay().direction, Color.red);
        Physics.Raycast(finger.GetTipPosition(), finger.GetRay().direction, out hit, Mathf.Infinity);

        line.SetWidth(0.01f, 0.01f);

        Vector3[] points = new Vector3[2];
        points[0] = finger.GetTipPosition();
        points[1] = finger.GetTipPosition() + 1000*finger.GetRay().direction;

        line.SetPositions(points);

        if (Input.GetKey(KeyCode.Space))
        {
            audio.Play();
            if (hit.transform.tag == "TARGET")
            {
                hit.transform.gameObject.SendMessage("Ding", targetHandler);
            }
            else
            {

            }
        }
    }
}
