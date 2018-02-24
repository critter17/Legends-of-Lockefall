using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Animator anim;

    public float moveSpeed;
    public bool moving;
    public Vector2 lastMove;
    public bool canMove = true;

	void Start ()
    {
        anim = GetComponent<Animator>();
        lastMove = new Vector2(0, -1);
	}

	void Update ()
    {
        moving = false;
        float horizontal = Mathf.RoundToInt(Input.GetAxisRaw("Horizontal"));
        float vertical = Mathf.RoundToInt(Input.GetAxisRaw("Vertical"));

        if (canMove)
        {
            if (horizontal != 0)
            {
                transform.Translate(new Vector3(horizontal * moveSpeed * Time.deltaTime, 0f, 0f));
                moving = true;
                lastMove = new Vector2(horizontal, 0f);
            }

            if (vertical != 0)
            {
                transform.Translate(new Vector3(0f, vertical * moveSpeed * Time.deltaTime, 0f));
                moving = true;
                lastMove = new Vector2(0f, vertical);
            }
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
