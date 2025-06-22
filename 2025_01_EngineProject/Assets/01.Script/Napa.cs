using System;
using _01.Script;
using UnityEngine;

public class Napa : MonoBehaviour
{
    private GameObject _point;
    private Vector2 _moveDir;
    private Rigidbody2D _rb;
    private HealthSystem _healthSystem;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _point = GameObject.FindGameObjectWithTag("Point");
        
        _moveDir = transform.position - _point.transform.position;
    }

    private void Update()
    {
        _rb.linearVelocity = -_moveDir * 5;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }

        if (other.CompareTag("NapeEnemy") || other.CompareTag("PajeonEnemy"))
        {
            _healthSystem = other.gameObject.GetComponent<HealthSystem>();
            _healthSystem.GetDamaged(1);
            Destroy(gameObject);
        }
    }
}
