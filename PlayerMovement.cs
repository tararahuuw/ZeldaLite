using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigidbody;

    private Vector3 change;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // Vector2 buat movement wasd
        change = Vector3.zero;

        change.x = Input.GetAxis("Horizontal");
        change.y = Input.GetAxis("Vertical");

        if (change != Vector3.zero) {
            MoveCharacter();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
        }
    }

    void MoveCharacter() 
    {
        myRigidbody.MovePosition (
            transform.position + change * speed * Time.deltaTime
        );
    }

}
