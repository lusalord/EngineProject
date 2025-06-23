using System;
using _01.Script.Enemy;
using _01.Script.Interface;
using UnityEngine;

namespace _01.Script.Item
{
    public class Ending : MonoBehaviour, IItem
    {
        public GameObject clear;
        public GameObject boss;

        private void Update()
        {
            transform.position = boss.transform.position;
        }

        public void Use(GameObject target)
        {
            clear.SetActive(true);
        }
    }
}
