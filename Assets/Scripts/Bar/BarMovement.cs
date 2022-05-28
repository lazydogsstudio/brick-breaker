using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class BarMovement : MonoBehaviour
{
    PlayerInput playerInput;

    public float speed = 2f;

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // if (other.gameObject.CompareTag("Player"))
        // {
        //     other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 2f);
        // }

    }


    private void FixedUpdate()
    {
        Vector2 moveValue = playerInput.actions["Move"].ReadValue<Vector2>();
        transform.Translate(Vector3.right * moveValue.x * speed);
    }

}