using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBrickBlock : MonoBehaviour
{
    private Vector3 targetBlock = new Vector3(0f, 40f, 0f);
    private Vector3 moveBrick = new Vector3(100f, 0f, 0f);
    bool Focused;

    // startFocus function is call when the "NextMind" NextTag Tracking Event: onTriggered is Triggred
    // set the "Focused" bool to true
    public void startFocus()
    {
        Focused = true;
    }

    // At the runtime of the program the bool "Focused" will be set to false
    private void Start()
    {
        Focused = false;
        Application.targetFrameRate = 60;
    }

    // stopFocus function is call when the "NextMind" NextTag Tracking Event: onReleased is Triggred
    // set the "Focused" bool to true
    public void stopFocus()
    {
        Focused = false;
    }

    

    // Update function will carry out the effect of the bool value being true or false
    // if "Focused" is true, this means that the user using the NextMind is focusing on the object.
    // this value is triggered from the startFocus function.

    // If "Focused" is False, this means that the user using the NextMind has stop focsing on the object.
    // this value is triggered from the stopFocus function.
    public void Update()
    {
        float moveTime = Time.deltaTime;

        if (Focused)
        {
            transform.position += targetBlock * moveTime;
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += moveBrick * moveTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= moveBrick * moveTime;
        }
    }
}
