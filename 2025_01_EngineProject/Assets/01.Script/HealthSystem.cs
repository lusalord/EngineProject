using System;
using _01.Script.Interface;
using Unity.VisualScripting;
using UnityEngine;

namespace _01.Script.Player
{
    public class HealthSystem : MonoBehaviour, IDamageable
    {
        public event Action OnDamaged;
        
        [field: SerializeField] public int Health { get; private set; }
        [SerializeField] private int maxHealth = 5;
        private HealthBarUI _healthBarUI;
        private bool _isDead;

        private void Awake()
        {
            _healthBarUI = GetComponent<HealthBarUI>();
            Health = maxHealth;
        }

        public void GetDamaged(int damage)
        {
            Health -= damage;
            Health = Mathf.Clamp(Health, 0, maxHealth);
            OnDamaged?.Invoke();

            if (Health <= 0)
            {
                _isDead = true;
            }
        }
    }
}
