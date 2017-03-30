using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public static float VELOCITY = 20;

    // get reference to ball prefab object
    public GameObject BallPrebab;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
        }
        else if (Input.GetKeyDown("a") || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ThrowBall(KeyCode.LeftArrow);
        }
        else if (Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.UpArrow))
        {
            ThrowBall(KeyCode.UpArrow);
        }
        else if (Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.RightArrow))
        {
            ThrowBall(KeyCode.RightArrow);
        }
        else if (Input.GetKeyDown("s") || Input.GetKeyDown(KeyCode.DownArrow))
        {
            ThrowBall(KeyCode.DownArrow);
        }
    }

    void ThrowBall(KeyCode kc)
    {
        // create a new GameObject of passed Prefab
        GameObject newBall = Instantiate(BallPrebab);
        // set ball's spawn location (script's parent is camera => relative to it)
        newBall.transform.position = transform.position;
        // get ball's rigidbody component
        //  Rigidbody rb = newBall.GetComponent("RigidBody");
        // compile-safe version:
        Rigidbody rb = newBall.GetComponent<Rigidbody>();

        Vector3 velocityVector;
        switch (kc)
        {
            case KeyCode.A:
            case KeyCode.LeftArrow:
                velocityVector = Vector3.left;
                break;
            case KeyCode.D:
            case KeyCode.RightArrow:
                velocityVector = Vector3.right;
                break;
            case KeyCode.W:
            case KeyCode.UpArrow:
                velocityVector = Vector3.forward;
                break;
            case KeyCode.S:
            case KeyCode.DownArrow:
                velocityVector = Vector3.back;
                break;
            default:
                velocityVector = new Vector3(0, 0, 0);
                break;
        }

        // edit velocity property
        rb.velocity = velocityVector*VELOCITY;
    }
}