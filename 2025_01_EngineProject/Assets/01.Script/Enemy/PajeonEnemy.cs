using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace _01.Script.Enemy
{
    public class PajeonEnemy : MonoBehaviour
    {
        private HealthSystem _healthSystem;
        [FormerlySerializedAs("_itemPrefab")] [SerializeField] private GameObject itemPrefab;
        
        
        private void Awake()
        {
            _healthSystem = GetComponent<HealthSystem>();
        }

        private void Update()
        {
            if (_healthSystem.isDead)
            {
                Instantiate(itemPrefab, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
