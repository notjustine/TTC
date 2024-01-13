using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private bool playerLeftInput;
    private bool playerRightInput;
    private bool userJumped;
    // private const float scaleMovement = 0.5f;
    // private const float horizontalMovement = 0.5f;

    private Rigidbody rigidBody;
    // private Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        // transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        playerLeftInput = Input.GetKey("left");
        playerRightInput = Input.GetKey("right");
        userJumped = Input.GetButton("Jump");
        
    }

    void FixedUpdate() {
        if (playerLeftInput) {
            rigidBody.AddForce(Vector3.left, ForceMode.VelocityChange);
            playerLeftInput = false;
        }

        if (playerRightInput) {
            rigidBody.AddForce(Vector3.right, ForceMode.VelocityChange);
            playerRightInput = false;
        }
        if (userJumped) {
            rigidBody.AddForce(Vector3.up, ForceMode.VelocityChange);
            userJumped = false;
        }
    }
}


