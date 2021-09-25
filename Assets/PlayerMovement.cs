using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 1;

    [SerializeField]
    float jumpSpeed = 1;

    Rigidbody rb;

    public bool isJumping = true;

    // Start is called before the first frame update
    void Start()
    {
        //get rigidbody attached to object
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(h * moveSpeed,
                                  rb.velocity.y,
                                  v * moveSpeed);

        //if isJumping = false allow player to jump and turn isJumping to true
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.velocity = new Vector3(rb.velocity.x,
                                      jumpSpeed,
                                      rb.velocity.z);
            isJumping = true;
        }
    }
    //Check to see if Player is colliding with ground, if so the player isn't jumping
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }

    }
}
