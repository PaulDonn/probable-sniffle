using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public CharacterController2D controller;

    public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
    bool crouch = false;
    bool attack = false;

    // Update is called once per frame
    void Update () {

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));


		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
            animator.SetBool("IsJumping", true);
		}

		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		} else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}

        if (Input.GetButtonDown("Attack"))
        {
            attack = true;
            animator.SetBool("IsAttacking", true);
        }

    }

    public void OnLanding()
    {
        animator.SetBool("IsHurt", true);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsHurt", true);

    }

    void FixedUpdate ()
	{
        if (attack)
        {
            controller.Attack();
            animator.SetBool("IsAttacking", false);
            attack = false;
        }
        //attack

        else
        {
            //controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
            //jump = false;
            //animator.SetBool("IsHurt", false);
        }
	}
}
