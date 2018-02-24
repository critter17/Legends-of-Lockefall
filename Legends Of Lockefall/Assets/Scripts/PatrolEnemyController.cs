using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolEnemyController : MonoBehaviour {

    Animator anim;
    public float radius;

    public Waypoint[] waypoints;
    private int currentWaypoint;
    private int rotation;
    public float moveSpeed;
    public bool moving;
    float delay;

    float horizontal, vertical;
    
	void Start ()
    {
        anim = GetComponent<Animator>();
        transform.position = waypoints[currentWaypoint].transform.position;
        delay = waypoints[currentWaypoint].waitTime;
    }
	
	void Update ()
    {
        float distance = Vector2.Distance(transform.position, PlayerManager.instance.player.transform.position);
        if(distance <= radius)
        {
            transform.position = Vector2.MoveTowards(transform.position, PlayerManager.instance.player.transform.position, moveSpeed * Time.deltaTime);
            DetectDirection(PlayerManager.instance.player.transform);
        }
        else
        {
            PatrolWaypoints();
        }

        anim.SetFloat("Rotation", rotation);
        anim.SetFloat("Horizontal", -horizontal);
        anim.SetFloat("Vertical", -vertical);
        anim.SetBool("Moving", moving);
    }

    public void PatrolWaypoints()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypoint].transform.position, moveSpeed * Time.deltaTime);

        if (transform.position == waypoints[currentWaypoint].transform.position)
        {
            rotation = waypoints[currentWaypoint].rotationInteger;
            delay -= Time.deltaTime;
            if (delay <= 0)
            {
                if (currentWaypoint < waypoints.Length - 1)
                {
                    currentWaypoint += 1;
                }
                else if (currentWaypoint == waypoints.Length - 1)
                {
                    currentWaypoint = 0;
                }
                rotation = waypoints[currentWaypoint].rotationInteger;
                delay = waypoints[currentWaypoint].waitTime;
            }
        }

        if (currentWaypoint >= waypoints.Length)
        {
            currentWaypoint = 0;
        }

        DetectDirection(waypoints[currentWaypoint].transform);
    }

    void DetectDirection(Transform target)
    {
        horizontal = transform.position.x - target.position.x;
        vertical = transform.position.y - target.position.y;

        if(horizontal == 0 && vertical == 0)
        {
            moving = false;
        }
        else
        {
            moving = true;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
