using UnityEngine;

namespace _01.Script.Player
{
    public class OnDamagedPoint : MonoBehaviour
    {
        private HealthSystem _healthSystem;
        public int damage = 1;
        private void OnTriggerEnter2D(Collider2D other) // 플레이어 공격 콜라이더
        {
            _healthSystem = other.GetComponent<HealthSystem>(); //맞은 대상의 healthSystem을 가져옴
            _healthSystem.GetDamaged(damage);
        }
    }
}
