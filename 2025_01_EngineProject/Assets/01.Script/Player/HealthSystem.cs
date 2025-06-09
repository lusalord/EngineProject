using _01.Script.Interface;
using UnityEngine;

namespace _01.Script.Player
{
    public class HealthSystem : MonoBehaviour, IDamageable
    {
        [field: SerializeField] public int Health { get; set; }
        [SerializeField] private int maxHealth;
        private bool _isDead;

        private void Awake()
        {
            Health = maxHealth;
        }

        public void GetDamaged(int damage, GameObject attacker)
        {
            Health -= damage;
            Health = Mathf.Clamp(Health, 0, maxHealth);

            if (Health <= 0)
            {
                _isDead = true;
                
            }
        }
    }
}
