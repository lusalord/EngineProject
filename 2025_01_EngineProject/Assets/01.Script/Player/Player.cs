using _01.Script.Manager;
using UnityEngine;

namespace _01.Script.Player
{
    public class Player : MonoBehaviour
    {
        private HealthSystem _healthSystem;
        public bool isGetPa;
        public bool isGetNapa;

        private void Awake()
        {
            _healthSystem = GetComponent<HealthSystem>();
            _healthSystem.OnDamaged += UpdateHealthUI; //  UpdateHealthUI 메서드를 OnDamaged 델리게이트에 추가함.
        
        }

        private void Start()
        {
            UIManager.Instance.HealthUI.InitHealth(_healthSystem.Health);
        }

        private void UpdateHealthUI()
        {
            UIManager.Instance.HealthUI.UpdateHealthUI(_healthSystem.Health);
        }

        private void OnDestroy()
        {
            _healthSystem.OnDamaged -= UpdateHealthUI;
        }
    }
}
