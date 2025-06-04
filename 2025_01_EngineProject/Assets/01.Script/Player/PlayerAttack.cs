using System.Collections;
using UnityEngine;

namespace _01.Script.Player
{
    public class PlayerAttack : MonoBehaviour
    {
        [SerializeField] private PlayerInputSo playerInputSo;
        public Collider2D point;

        private void Start()
        {
            point.enabled = false;
        }

        private void OnEnable()
        {
            playerInputSo.OnAttackPressed += TryAttack;
        }

        private void TryAttack()
        {
            point.enabled = true;
            StartCoroutine(WaitSpawnCollider());
        }

        private IEnumerator WaitSpawnCollider()
        {
            yield return new WaitForSeconds(0.1f);
            point.enabled = false;
        }
    }
}