using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

    private Animator anim;
    private Rigidbody rb;
    private GameManager gameManager;

    public Transform[] waypoint;        // The amount of Waypoint you want
    public float patrolSpeed = 3f;       // The walking speed between Waypoints
    public bool loop = true;       // Do you want to keep repeating the Waypoints
    public float dampingLook = 6.0f;          // How slowly to turn
    public float pauseDuration = 0;   // How long to pause at a Waypoint

    private float curTime;
    private int currentWaypoint = 0;
    private CharacterController character;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        character = GetComponent<CharacterController>();
    }

    void Update()
    {

        if (currentWaypoint < waypoint.Length)
        {
            patrol();
        }
        else
        {
            if (loop)
            {
                currentWaypoint = 0;
            }
        }
    }

    void patrol()
    {

        Vector3 target = waypoint[currentWaypoint].position;
        target.y = transform.position.y; // Keep waypoint at character's height
        Vector3 moveDirection = target - transform.position;

        if (moveDirection.magnitude < 0.5f)
        {
            if (curTime == 0)
                curTime = Time.time; // Pause over the Waypoint
            if ((Time.time - curTime) >= pauseDuration)
            {
                anim.Play("idle01", -1);
                currentWaypoint++;
                curTime = 0;
            }
        }
        else
        {
            var rotation = Quaternion.LookRotation(target - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * dampingLook);
            anim.Play("crippledWalk", -1);
            character.Move(moveDirection.normalized * patrolSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            //SoundFX.playsound("getCoin");
            gameManager.GetHit();
        }
    }
}