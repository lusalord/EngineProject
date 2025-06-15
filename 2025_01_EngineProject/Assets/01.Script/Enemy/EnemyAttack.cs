using System.Collections;
using _01.Script.Player;
using UnityEngine;

namespace _01.Script
{
    public class EnemyAttack : MonoBehaviour
    {
        private readonly int _damage = 1;
        private HealthSystem _healthSystem;
        private bool _isAttack = true;

        private void OnCollisionStay2D(Collision2D other)
        {
            _healthSystem = other.gameObject.GetComponent<HealthSystem>(); //부딪힌 오브젝트의 healthSystem을 가져옴
            if (_isAttack)
            {
                Debug.Log("공격");
                StartCoroutine(Attack());
            }
        }

        private IEnumerator Attack() //공격이 0.5초 단위로 실행되게 함
        {
            _isAttack = false;
            _healthSystem.GetDamaged(_damage);
            yield return new WaitForSeconds(0.5f);
            _isAttack = true;
            
        }
    }
}
