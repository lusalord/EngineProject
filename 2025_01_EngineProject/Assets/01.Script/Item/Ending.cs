using System;
using _01.Script.Interface;
using UnityEngine;

namespace _01.Script.Item
{
    public class Ending : MonoBehaviour, IItem
    {
        [SerializeField] private GameObject gameClear;

        private void Awake()
        {
            gameClear = GameObject.FindGameObjectWithTag("Clear");
        }

        public void Use(GameObject target)
        {
            gameClear.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
