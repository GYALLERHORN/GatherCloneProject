using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;

    private Vector2 _moveDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;
    private Animator anim;
    private Camera _camera;

    [SerializeField] private float speed = 150f;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
        _camera = Camera.main;
    }

    private void FixedUpdate()
    {
        ApplyMove(_moveDirection);
    }

    private void Move(Vector2 moveDirection)
    {
        _moveDirection = moveDirection;
    }

    private void ApplyMove(Vector2 direction)
    {
        if (direction != new Vector2(0, 0))
        {
            anim.SetBool("IsMove", true);
        }
        else
        {
            anim.SetBool("IsMove", false);
        }
        _rigidbody.velocity = direction * speed * Time.deltaTime;
        _camera.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }
}
