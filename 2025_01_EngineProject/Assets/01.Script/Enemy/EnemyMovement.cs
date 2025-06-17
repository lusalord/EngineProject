using UnityEngine;

namespace _01.Script.Enemy
{
    public class EnemyMovement : MonoBehaviour
    {
        public float detectRadius; // 플레이어 감지 반지름

        private Collider2D[] _collider;

        public ContactFilter2D whatIsPlayer;
        
        [SerializeField] private GameObject player;
        private Vector2 _moveDir; 
        private Rigidbody2D _rb;
        [SerializeField] private float speed;

        private Collider2D GetPlayerCollider()
        {
            int cnt = Physics2D.OverlapCircle(transform.position, detectRadius, whatIsPlayer, _collider);
            return cnt > 0 ? _collider[0] : null;
        }

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            _collider = new Collider2D[1];
        }
        private void Update()
        {
            Collider2D playerCollider = GetPlayerCollider();
            if (playerCollider != null)
            {
                _moveDir = playerCollider.transform.position - transform.position;
                if (_moveDir.x < 0)
                    transform.localScale = new Vector3(2, 2, 2); // 왼쪽을 바라봄
                    
                else
                    transform.localScale = new Vector3(-2, 2, 2); // 오른쪽을 바라봄
                _moveDir.Normalize();
            }
            else
            {
                _moveDir = Vector2.zero;
            }
            _rb.linearVelocity = _moveDir * speed;
            
        }
        
        #if UNITY_EDITOR

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, detectRadius);
        }
        #endif
    }
}
