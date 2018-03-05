using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private HeroStatManager hero;
    private Animator anim;
    private Rigidbody2D playerRigidBody;

    public bool moving;
    public Vector2 lastMove;
    public bool canMove = true;

	void Start ()
    {
        hero = GetComponent<HeroStatManager>();
        anim = GetComponent<Animator>();
        playerRigidBody = GetComponent<Rigidbody2D>();
        lastMove = new Vector2(0, -1);
	}

	void Update ()
    {
        moving = false;
        float horizontal = Mathf.RoundToInt(Input.GetAxisRaw("Horizontal"));
        float vertical = Mathf.RoundToInt(Input.GetAxisRaw("Vertical"));

        if (canMove)
        {
            if (horizontal > 0.5f || horizontal < -0.5f)
            {
                playerRigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * hero.heroStats.baseSpeed, playerRigidBody.velocity.y);
                moving = true;
                lastMove = new Vector2(horizontal, 0f);
            }

            if (vertical > 0.5f || vertical < -0.5f)
            {
                playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, Input.GetAxisRaw("Vertical") * hero.heroStats.baseSpeed);
                moving = true;
                lastMove = new Vector2(0f, vertical);
            }
        }

        if(horizontal < 0.5f && horizontal > -0.5f)
        {
            playerRigidBody.velocity = new Vector2(0f, playerRigidBody.velocity.y);
        }

        if(vertical < 0.5f && vertical > -0.5f)
        {
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, 0f);
        }

        anim.SetFloat("Vertical", vertical);
        anim.SetFloat("Horizontal", horizontal);
        anim.SetFloat("LastMoveVertical", lastMove.y);
        anim.SetFloat("LastMoveHorizontal", lastMove.x);
        anim.SetBool("Moving", moving);
    }

    public void CanMove(bool state)
    {
        canMove = state;
    }
}
