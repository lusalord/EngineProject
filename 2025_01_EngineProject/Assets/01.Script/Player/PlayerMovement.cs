using _01.Script.Interface;
using Unity.VisualScripting;
using UnityEngine;

namespace _01.Script.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] PlayerInputSo playerInput;
        
        [SerializeField] private float moveSpeed = 10f;
        private Rigidbody2D _rb;

        

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            
        }

        private void Update()
        {
            _rb.linearVelocity = playerInput.moveDir * moveSpeed;
            FlipX();
//            Debug.Log(playerInput.moveDir);
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

        private void OnTriggerEnter2D(Collider2D collision)
        {
            // 충돌한 대상이 아이템이면
            if (collision.gameObject.TryGetComponent(out IItem item))
            {
                if (!transform.root.CompareTag("Point")) // 포인트가 아닌지 확인
                {
                    item.Use(gameObject); // 아이템 사용
                    Destroy(collision.gameObject); // 아이템 제거
                }
            }
        }
    }
}
