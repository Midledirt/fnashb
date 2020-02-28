using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrTouchMovement : MonoBehaviour
{
    float movespeed = 0.2f;


    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            //Calculate touch position
            Touch touch = Input.GetTouch(0);
            Vector3 newTouchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            newTouchPosition.z = 0f;

            //Move player towards touch position
            transform.position = Vector3.MoveTowards(transform.position, newTouchPosition, movespeed);
        }

 
    }
}
