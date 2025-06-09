using System;
using UnityEngine;

namespace _01.Script
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        
        [field: SerializeField] public GameObject Player { get; private set; }

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
