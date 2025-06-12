using _01.Script.Player;
using UnityEngine;

namespace _01.Script
{
    public class EnemyAttack : MonoBehaviour
    {
        private readonly int _damage = 1;
        private HealthSystem _healthSystem;

        private void OnCollisionEnter2D(Collision2D other)
        {
            Debug.Log("공격");
            _healthSystem = other.gameObject.GetComponent<HealthSystem>();
            
            _healthSystem.GetDamaged(_damage);
            Debug.Log(_healthSystem.Health);
        }
    }
}
