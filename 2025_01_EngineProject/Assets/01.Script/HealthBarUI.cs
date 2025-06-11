using System;
using _01.Script.Player;
using UnityEngine;
using UnityEngine.UI;

namespace _01.Script
{
    public class HealthBarUI : MonoBehaviour
    {
        public Slider healthSlider;
        private HealthSystem _healthSystem;
        
        /// <summary>
        /// 최대 체력을 설정함.
        /// </summary>
        private float[] _healthBarWidth;
        private float _damageHealthBarSize;

        private void Start()
        {
            _healthSystem = GameManager.instance.Player.GetComponent<HealthSystem>();
            _damageHealthBarSize = _healthSystem.Health;
        }
        
        public void InitHealth(int life)
        {
            healthSlider.maxValue = life;
            healthSlider.value = life;
        }
        
        /// <summary>
        /// 현재 체력을 반영함.
        /// </summary>
        public void UpdateHealthUI(int currentHealth)
        {
            healthSlider.value = currentHealth;
            // healthSlider.value = _healthSystem.Health / _damageHealthBarSize;
        }
    }
}
