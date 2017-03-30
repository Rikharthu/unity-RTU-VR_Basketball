using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    public float speed;
    [SerializeField]
    private float minSpeed = 8;
    [SerializeField]
    private float maxSpeed = 25;
    [SerializeField]
    private float chargeRate = 1;
    public GameObject BallPrefab;
    private Camera camera;
    bool charging;
    // TODO true until controler bug is fixed
    public static bool enabled = true;

    // Use this for initialization
    void Start()
    {
        camera = GetComponent<Camera>();

        // set default values
        charging = false;
        speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (enabled)
        {
            Vector3 lookDirection = camera.transform.forward;
            Debug.DrawRay(transform.localPosition, lookDirection, Color.red);
            Debug.DrawRay(transform.localPosition, Vector3.ProjectOnPlane(lookDirection, Vector3.up), Color.yellow);

            // user pressed fire - start charging
            if (Input.GetButtonDown("Fire1"))
            {
                // start charging
                charging = true;
            }

            if (charging)
            {
                if (speed < maxSpeed)
                {
                    speed += chargeRate * Time.deltaTime;
                }
                // check if we do not overshoot
                if (speed > maxSpeed)
                {
                    speed = maxSpeed;
                }

            }

            if (charging)
            {
                print("Charging, speed=" + speed);
            }

            // user released fire button - shoot and reset
            //this resets and fires
            if (Input.GetButtonUp("Fire1"))
            {
                //Fire
                // create a new GameObject of passed Prefab (Ball)
                GameObject ball = Instantiate(BallPrefab);
                ball.tag="ball";

                // set ball's spawn location (script's parent is camera => relative to it)
                ball.transform.position = transform.position;

                // get ball's rigidbody component
                //  Rigidbody rb = newBall.GetComponent("RigidBody");
                // compile-safe version:
                Rigidbody rb = ball.GetComponent<Rigidbody>();


                // edit velocity property
                //            rb.velocity = transform.forward*Speed;
                // camera's global rotation multiplied by forward vector
                //rb.velocity = camera.transform.rotation*Vector3.forward*Speed;
                // same:
                rb.velocity = lookDirection * speed;
                //==reset==
                speed = 0;
                charging = false;
            }
        }
    }
}