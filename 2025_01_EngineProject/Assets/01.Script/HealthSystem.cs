using System;
using _01.Script.Interface;
using UnityEngine;
using UnityEngine.Serialization;

namespace _01.Script
{
    public class HealthSystem : MonoBehaviour, IDamageable
    {
        public event Action OnDamaged;
        
        [field: SerializeField] public int Health { get; private set; }
        [SerializeField] private int maxHealth = 5;
        private HealthBarUI _healthBarUI;
        public bool isDead;

        private void Awake()
        {
            _healthBarUI = GetComponent<HealthBarUI>();
            Health = maxHealth; // 인스펙터 창에서 입력한 최대 체력을 Health 프로퍼티에 넣음
        }

        public void GetDamaged(int damage)
        {
            Health -= damage;
            Health = Mathf.Clamp(Health, 0, maxHealth);
            Debug.Log("invoke");
            OnDamaged?.Invoke();

            if (Health <= 0)
            {
                isDead = true;
            }
        }
    }
}
