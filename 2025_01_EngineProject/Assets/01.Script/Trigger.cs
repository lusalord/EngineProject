using System;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace _01.Script
{
    public class Trigger : MonoBehaviour
    {
        [SerializeField] private Tilemap tilemap;

        private void Start()
        {
            tilemap.gameObject.SetActive(false);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            tilemap.gameObject.SetActive(true);
        }
    }
}
