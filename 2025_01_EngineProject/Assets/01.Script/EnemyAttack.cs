using System;
using System.Collections;
using _01.Script.Interface;
using _01.Script.Player;
using UnityEngine;

namespace _01.Script
{
    public class EnemyAttack : MonoBehaviour
    {
        private int damage = 1;
        HealthSystem healthSystem;

        private void OnCollisionEnter2D(Collision2D other)
        {
            Debug.Log("공격");
            healthSystem = other.gameObject.GetComponent<HealthSystem>();
            
            healthSystem.GetDamaged(damage);
            Debug.Log(healthSystem.Health);
        }
    }
}
