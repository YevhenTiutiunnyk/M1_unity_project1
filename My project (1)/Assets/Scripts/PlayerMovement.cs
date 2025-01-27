using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float speed = 5f;
    public float jumpHeight = 2f;
    public float gravity = -9.81f;

    private CharacterController controller;

    private Animator _animator;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
        
    }


    private void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");


        Vector3 move = transform.right * horizontal + transform.forward * vertical;


        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            _animator.SetFloat("speed", 1);
        }
        else
        {
            _animator.SetFloat("speed", 0);
        }

        // Vector3 movement = new Vector3(0, 0, 0);
        // if (Input.GetKey(KeyCode.W))
        // {
        //     movement += transform.forward * movementSpeed * Time.deltaTime;
        // }
        //if (Input.GetKey(KeyCode.S))
        //{
        //    movement -= transform.forward * movementSpeed * Time.deltaTime;
        //}
        //transform.position += movement.normalized * movementSpeed * Time.deltaTime;


    }
}