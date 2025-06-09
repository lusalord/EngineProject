using System;
using _01.Script.Manager;
using _01.Script.Player;
using UnityEngine;

public class Player : MonoBehaviour
{
    private HealthSystem _healthSystem;

    private void Awake()
    {
        _healthSystem = GetComponent<HealthSystem>();
    }

    private void Start()
    {
        // UIManager.Instance.HealthUI.InitHealth();
            
    }
}
