using System;
using System.Collections;
using _01.Script.Interface;
using _01.Script.Player;
using UnityEngine;

namespace _01.Script
{
    public class EnemyAttack : MonoBehaviour
    {
        private int _damage = 1;
        
        private float _damageTimer;
        private IDamageable _damageable;
        private bool _isPlayerInRange;

        private void OnCollisionStay2D(Collision2D other)
        {
            
        }
    }
}
