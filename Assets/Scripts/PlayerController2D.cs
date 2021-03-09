using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    private PlayerInput playerInput;
    private Rigidbody2D rb;
    [SerializeField]
    private float _speed = 5f;

    public MapGenerator MapGen;
    public Camera main;

    void Awake()
    {
        playerInput = new PlayerInput();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }
    private void OnDisable()
    {
        playerInput.Disable();
    }
    void FixedUpdate()
    {
        Vector2 moveInput = playerInput.Movement.Move.ReadValue<Vector2>();
        rb.velocity = moveInput * _speed;
    }
    private void Update()
    {
      
    }
}
