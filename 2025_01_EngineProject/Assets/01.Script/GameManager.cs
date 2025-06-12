using System;
using UnityEngine;

namespace _01.Script
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        
        [field: SerializeField] public GameObject Player { get; private set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
