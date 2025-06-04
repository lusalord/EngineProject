using System;
using UnityEngine;

namespace _01.Script
{
    public class PlayerAttack : MonoBehaviour
    {
        [SerializeField] private PlayerInputSo playerInputSo;

        private void OnEnable()
        {
            playerInputSo.OnAttackPressed += TryAttack;
        }

        private void TryAttack()
        {
            Debug.Log("Attack!");
        }
    }
}