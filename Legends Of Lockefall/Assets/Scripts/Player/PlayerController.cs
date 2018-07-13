using UnityEngine.EventSystems;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private HeroStatManager hero;
    private Animator anim;
    [HideInInspector] public Rigidbody2D playerRigidBody;

    public bool moving;
    public Vector2 lastMove;
    public bool canMove = true;
    private int speed;

	void Start ()
    {
        hero = GetComponent<HeroStatManager>();
        anim = GetComponent<Animator>();
        playerRigidBody = GetComponent<Rigidbody2D>();
        lastMove = new Vector2(0, -1);
        speed = hero.heroStats.baseSpeed;
	}

    private void Update ()
    {
        moving = false;
        float horizontal = Mathf.RoundToInt(Input.GetAxisRaw("Horizontal"));
        float vertical = Mathf.RoundToInt(Input.GetAxisRaw("Vertical"));

        if (canMove)
        {
            if(horizontal != 0 && vertical != 0)
            {
                playerRigidBody.MovePosition(new Vector2(transform.position.x + (horizontal * speed), transform.position.y + (vertical * speed)));
                moving = true;
                lastMove = new Vector2(horizontal, vertical);
            }

            else if (horizontal != 0)
            {
                playerRigidBody.MovePosition(new Vector2(transform.position.x + (horizontal * speed), transform.position.y));
                moving = true;
                lastMove = new Vector2(horizontal, 0f);
            }

            else if (vertical != 0)
            {
                playerRigidBody.MovePosition(new Vector2(transform.position.x, transform.position.y + (vertical * speed)));
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
