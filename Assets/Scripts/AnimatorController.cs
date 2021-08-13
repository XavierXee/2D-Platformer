using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{

    private Animator animator;
    private SpriteRenderer spriteRenderer;

    private float moveInput = 0;
    private bool faceingRight = true;

    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Move(float moveInput)
    {
        if (moveInput != 0)
        {
            faceingRight = moveInput > 0;

            if (animator != null)
            {
                animator.SetBool("Moving", true);
            }
        } else {
            if (animator != null)
            {
                animator.SetBool("Moving", false);
            }
        }
    }

    public void Jump() {
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("Jump");
        }
    }

    void Update()
    {
        // moveInput = Input.GetAxisRaw("Horizontal");

        spriteRenderer.flipX = !faceingRight;

        // if (moveInput != 0)
        // {
        //     faceingRight = moveInput > 0;

        //     if (animator != null)
        //     {
        //         animator.SetBool("Moving", true);
        //     }
        // } else {
        //     if (animator != null)
        //     {
        //         animator.SetBool("Moving", false);
        //     }
        // }

        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("Jump");
        }
    }

}
