using System;
using UnityEngine;

namespace _01.Script.Enemy
{
    public class PajeonEnemy : MonoBehaviour
    {
        private HealthSystem _healthSystem;
        
        
        private void Awake()
        {
            _healthSystem = GetComponent<HealthSystem>();
        }

        private void Update()
        {
            if (_healthSystem.isDead)
            {
                Destroy(gameObject);
            }
        }
    }
}
