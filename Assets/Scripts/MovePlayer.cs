using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{   
    private bool playerLeftInput;
    private bool playerRightInput;
    private bool playerJumped;

    private bool playerSlided;

    private float playerVertInput;
    private float playerHorizInput;
    private Vector3 userRot;

    private Rigidbody rigidBody;
    private Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        playerJumped = Input.GetButton("Jump");
        playerHorizInput = Input.GetAxis("Horizontal");
        playerVertInput = Input.GetAxis("Vertical");

        // Right
        if (playerHorizInput > 0) {
            playerRightInput = true;
        }
        // Left 
        else if (playerHorizInput < 0) {
            playerLeftInput = true;
        }

        // Jump
        if (playerVertInput > 0) {
            playerJumped = true;
        } else if (playerVertInput < 0) {
            playerSlided = true;
        }
    }

    void FixedUpdate() {
        if (playerLeftInput) {
            rigidBody.AddForce(Vector3.left, ForceMode.Impulse);
            playerLeftInput = false;
        }

        if (playerRightInput) {
            rigidBody.AddForce(Vector3.right, ForceMode.Impulse);
            playerRightInput = false;
        }
        if (playerJumped) {
            rigidBody.AddForce(Vector3.up, ForceMode.Impulse);
            playerJumped = false;
        }

        if (playerSlided) {
            userRot = transform.rotation.eulerAngles;
            rigidBody.AddForce(Vector3.down, ForceMode.Impulse);
        }

        if (rigidBody.transform.position.y >  5) {
            rigidBody.transform.position = new Vector3(rigidBody.transform.position.x, 5, rigidBody.transform.position.z);
            rigidBody.velocity = Vector3.zero;
        }
    }
}


