using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrMoveWithTouch : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Vector3 touchPosition = Camera.main.ScreenToViewportPoint(Input.touches[i].position);
            Debug.DrawLine(Vector3.zero, touchPosition, Color.red);
        }
    }
}
