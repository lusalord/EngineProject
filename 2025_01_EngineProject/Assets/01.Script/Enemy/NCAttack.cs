using System.Collections;
using UnityEngine;

namespace _01.Script.Enemy
{
    public class NcAttack : MonoBehaviour
    {
        [SerializeField] GameObject napePrefab;
        public Transform firePoint;
        [SerializeField] private float attackRange = 5f;
        public float projectileSpeed = 10f;
        private Transform _player;
        private bool _attack = true;
        private void Update()
        {
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player"); // "Player" 태그를 가진 오브젝트 검색
            if (playerObj != null)
                _player = playerObj.transform; // 플레이어의 Transform을 저장
            else
                return; // 플레이어가 없으면 함수 종료
            
            float distance = Vector2.Distance(transform.position, _player.position);

            if (distance <= attackRange)
            {
                if (_attack)
                {
                    StartCoroutine(ThroughNape());
                }
                
            }
            
        }

        // ReSharper disable Unity.PerformanceAnalysis
        private IEnumerator ThroughNape()
        {

            _attack = false;
            Vector2 direction = (_player.position - firePoint.position).normalized;
            GameObject nape = Instantiate(napePrefab, transform.position, Quaternion.identity);
            
            Rigidbody2D rb = nape.GetComponent<Rigidbody2D>();
            
            if (rb != null)
            {
                rb.linearVelocity = direction * projectileSpeed;
            }
            yield return new WaitForSeconds(2f);
            _attack = true;
        }
    }
}
