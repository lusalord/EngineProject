using System;
using _01.Script.Player;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _01.Script
{
    public class HealthBarUI : MonoBehaviour
    {
        private Slider _healthSlider;
        private HealthSystem _healthSystem;
        public TextMeshProUGUI text;
        
        /// <summary>
        /// 최대 체력을 설정함.
        /// </summary>
        private float[] _healthBarWidth;
        private float _damageHealthBarSize;

        private void Awake()
        {
            _healthSlider = GetComponent<Slider>(); //자기 자신 슬라이더 가져옴
        }

        private void Start()
        {
            _healthSystem = GameManager.Instance.Player.GetComponent<HealthSystem>();
            _damageHealthBarSize = _healthSystem.Health;
        }
        
        public void InitHealth(int life)
        {
            _healthSlider.maxValue = life; // health 슬라이더의 최대값을 life에 들어오는 값(5)으로 고정시킴.
            _healthSlider.value = life; // health 슬라이더의 현재값을 life로 변경.
        }
        
        /// <summary>
        /// 현재 체력을 반영함.
        /// </summary>
        public void UpdateHealthUI(int currentHealth)
        {
            text.text = $"{currentHealth} / {_healthSlider.maxValue}";
            _healthSlider.value = currentHealth; // health 슬라이더의 현재값을 currentHealth의 값으로 업데이트 시킨다.
            
            // healthSlider.value = _healthSystem.Health / _damageHealthBarSize;
        }
    }
}
