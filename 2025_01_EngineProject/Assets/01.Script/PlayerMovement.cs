using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _01.Script
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] PlayerInputSo playerInput;
        
        private Vector2 _moveDir;
        [SerializeField] private float _moveSpeed = 10f;
        private Rigidbody2D _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            
        }

        private void Update()
        {
            _rb.linearVelocity = playerInput.moveDir * _moveSpeed;
        }

        public void OnMove(InputValue value)
        {
            _moveDir = value.Get<Vector2>();
        }
    }
}
