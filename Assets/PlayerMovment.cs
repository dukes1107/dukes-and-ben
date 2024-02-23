using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(DebuggerDisplay ) + "(),nq}")]
public class PlayerMovment : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    private float dirX = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 14f);
        }

        Updateanimationstate();
    }

    private void Updateanimationstate()
    {
       if (dirX > 0f)
        {
            anim.SetBool("walking", true);
        }
        else if (dirX < 0f)
        {
            anim.SetBool("walking", true);
        }
        else
        {
            anim.SetBool("walking", false);
        }
    }
    private string DebuggerDisplay => ToString();
}

