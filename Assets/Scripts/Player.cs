using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] LayerMask groundLayers;

    private bool jumpKeyWasPressed;

    private bool canDoubleJump;
    private float horizontalInput;
    private bool isGrounded;
    private Rigidbody rigidbodyComponent;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position, 0.1f, groundLayers, QueryTriggerInteraction.Ignore);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
            if (isGrounded) {
                canDoubleJump = true;
            }
        }
        horizontalInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(transform.position, 0.1f, groundLayers, QueryTriggerInteraction.Ignore);

        if (jumpKeyWasPressed)
        {
            Debug.Log("Space key pressed");
            
            if(isGrounded) {
                rigidbodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            }
            else if (canDoubleJump) {
                rigidbodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
                canDoubleJump = false;
            }
            jumpKeyWasPressed = false;
        }

        rigidbodyComponent.velocity = new Vector3(horizontalInput * 2.5f, rigidbodyComponent.velocity.y, 0);
    }
}
