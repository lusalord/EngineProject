using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace _01.Script.Enemy
{
    public class Asdf : MonoBehaviour
    {
        private GameObject _player;
        
        private Vector3 _playerPos;
        private Vector3 _moveDir;
        
        private Rigidbody2D _rb;
        
        private HealthSystem _healthSystem;
        [SerializeField] private int damage = 3;

        private void Awake()
        {
            _player = GameObject.FindGameObjectWithTag("Player");
            _healthSystem = _player.GetComponent<HealthSystem>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                _healthSystem.GetDamaged(damage);
                Destroy(gameObject);
            }
        }
    }
}
