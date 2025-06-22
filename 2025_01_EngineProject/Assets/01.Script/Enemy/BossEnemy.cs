using System;
using System.Collections;
using UnityEngine;

namespace _01.Script.Enemy
{
    public class BossEnemy : MonoBehaviour
    {
        private bool _dash = true;
        private EnemyMovement _enemyMovement;
        

        private void Awake()
        {
            _enemyMovement = GetComponent<EnemyMovement>();
            
        }

        private void Update()
        {
            if (_dash)
            {
                StartCoroutine(Dash());
            }
        }

        private IEnumerator Dash()
        {
            _dash = false;
            _enemyMovement.speed = 10f;
            yield return new WaitForSeconds(0.7f);
            _enemyMovement.speed = 2f;
            yield return new WaitForSeconds(2f);
            _dash = true;
        }
    }
}
