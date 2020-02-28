using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrMovement : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    public CharacterController controller;
    public Joystick Joystick;
    float horizontalmove = 0f;
    public float walkSpeed = 1f;
    void Update()
    {
        m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotation;

        if (Joystick.Horizontal >= .2f)
        {
            horizontalmove = walkSpeed;
        }else if (Joystick.Horizontal <= -.2f)
        {
            horizontalmove = -walkSpeed;
        }else
        {
            horizontalmove = 0f;
        }


        Vector3 move = transform.right * horizontalmove;

        controller.Move(move);
    }
}
