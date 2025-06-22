using System;
using System.Collections;
using UnityEngine;

namespace _01.Script.Player
{
    public class PlayerAttack : MonoBehaviour
    {
        [SerializeField] private GameObject nape;
        [SerializeField] private PlayerInputSo playerInputSo;
        private Player _player;
        public Collider2D point;

        private void Start()
        {
            _player = GetComponent<Player>();
            point.enabled = false;
        }

        private void OnEnable()
        {
            playerInputSo.OnAttackPressed += TryAttack;
        }

        private void OnDisable()
        {
            playerInputSo.OnAttackPressed -= TryAttack;
        }

        private void TryAttack()
        {
            
            if (_player.isGetNapa)
            {
                Debug.Log("wkfasd");
                Instantiate(nape, transform.position, Quaternion.identity);
            }
            else
            {
                point.enabled = true;
                StartCoroutine(WaitSpawnCollider());
            }
        }

        
        private IEnumerator WaitSpawnCollider()
        {
            yield return new WaitForSeconds(0.1f);
            point.enabled = false;
        }
    }
}