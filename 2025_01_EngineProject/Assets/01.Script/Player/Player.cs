using System;
using _01.Script.Manager;
using _01.Script.Player;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private HealthSystem _healthSystem;

    private void Awake()
    {
        _healthSystem = GetComponent<HealthSystem>();
        _healthSystem.OnDamaged += UpdateHealthUI;
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
