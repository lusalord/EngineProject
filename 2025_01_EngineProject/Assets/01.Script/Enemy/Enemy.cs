using UnityEngine;
using UnityEngine.Serialization;

namespace _01.Script.Enemy
{
    public class Enemy : MonoBehaviour
    {
        private HealthSystem _healthSystem;
        [FormerlySerializedAs("_itemPrefab")] [SerializeField] private GameObject itemPrefab;
        
        
        private void Awake()
        {
            _healthSystem = GetComponent<HealthSystem>(); //Enemy의 HealthSystem을 가져옴
        }

        private void Update()
        {
            if (_healthSystem.isDead) // healthSystem의 isDead가 true 일 때, 아이템을 소환하고, 에너미를 죽임(삭제)
            {
                Instantiate(itemPrefab, transform.position, Quaternion.identity); // 아이템 소환
                Destroy(gameObject); //에너미 삭제
            }
        }
    }
}
