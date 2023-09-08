using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public FixedJoystick joystick;
    public float movespeed;
    public Animator animator;
    public void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(joystick.Horizontal * movespeed, rigidbody.velocity.y);
        animator.SetFloat("speed", Mathf.Abs(rigidbody.velocity.x));
        animator.SetFloat("down", joystick.Vertical);
    }

}
