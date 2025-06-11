using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _01.Script
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] PlayerInputSo playerInput;
        
        [SerializeField] private float _moveSpeed = 10f;
        private Rigidbody2D _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            
        }

        private void Update()
        {
            _rb.linearVelocity = playerInput.moveDir * _moveSpeed;
            FlipX();
            Debug.Log(playerInput.moveDir);
        }
        

        private void FlipX() // 플레이어 반전
        {
            if (playerInput.moveDir.x < 0)
            {
                transform.localScale = new Vector3(2, 2, 2);
            }
            else if (playerInput.moveDir.x > 0)
            {
                transform.localScale = new Vector3(-2, 2, 2);
            }
        }
    }
}
