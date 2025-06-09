using System;
using _01.Script.Player;
using UnityEngine;
using UnityEngine.UI;

namespace _01.Script
{
    public class HealthBarUI : MonoBehaviour
    {
        public Slider healthSlider;
        private int _healthCount = 0;
        private HealthSystem _healthSystem;
        
        
        private float[] _healthBarWidth;

        private float damageHealthbarSize;

        private void Awake()
        {
        }

        private void Start()
        {
            damageHealthbarSize = _healthSystem.Health;
            _healthSystem = GameManager.instance.Player.GetComponent<HealthSystem>();
        }

        private void Update()
        {
            healthSlider.value = _healthSystem.Health / damageHealthbarSize;
        }
    }
}
