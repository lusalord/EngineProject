using System;
using UnityEngine;

public class PlayerHealthSystem : MonoBehaviour
{
    [field: SerializeField] public int Health { get; set; }
    [SerializeField] private int maxHealth;
    private bool _isDead;

    private void Awake()
    {
        Health = maxHealth;
    }
    
}
