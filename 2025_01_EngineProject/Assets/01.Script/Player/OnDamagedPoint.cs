using System.Transactions;
using UnityEngine;

namespace _01.Script.Player
{
    public class OnDamagedPoint : MonoBehaviour
    {
        private HealthSystem _healthSystem;
        private void OnTriggerEnter2D(Collider2D other) // 플레이어 공격 콜라이더
        {
            _healthSystem = other.GetComponent<HealthSystem>();
            _healthSystem.GetDamaged(1);
        }
    }
}
