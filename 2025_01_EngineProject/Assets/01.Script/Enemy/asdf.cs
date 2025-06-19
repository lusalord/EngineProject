using UnityEngine;

namespace _01.Script.Enemy
{
    public class Asdf : MonoBehaviour
    {
        private GameObject _player;
        
        private Vector3 _playerPos;
        private Vector3 _moveDir;
        
        private Rigidbody2D _rb;
        
        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            _player = GameObject.FindGameObjectWithTag("Player");
            _playerPos = _player.transform.position;
            _moveDir = _playerPos - transform.position;
            _moveDir.Normalize();
            
            float angle = Mathf.Atan2(_moveDir.y, _moveDir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

        private void Update()
        {
            _rb.linearVelocity = _moveDir * 5;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Destroy(gameObject);
            }
        }
    }
}
