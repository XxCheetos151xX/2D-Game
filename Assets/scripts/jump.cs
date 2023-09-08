using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpheight;
    public Animator an;

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpheight);
        an.SetFloat("height", rb.velocity.y);
    }
    private void OnCollisionEnter2D()
    {
        an.SetFloat("height", 0f);
    }
}
