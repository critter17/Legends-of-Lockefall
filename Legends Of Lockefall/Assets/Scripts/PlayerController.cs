using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Animator anim;

    public float moveSpeed;
    public bool moving;
    private Vector2 lastMove;

	void Start ()
    {
        anim = GetComponent<Animator>();
	}

	void Update ()
    {
        moving = false;
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        if(horizontal != 0)
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

        anim.SetFloat("Vertical", vertical);
        anim.SetFloat("Horizontal", horizontal);
        anim.SetFloat("LastMoveVertical", lastMove.y);
        anim.SetFloat("LastMoveHorizontal", lastMove.x);
        anim.SetBool("Moving", moving);
    }
}
