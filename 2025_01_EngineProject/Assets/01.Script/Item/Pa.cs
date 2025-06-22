using System;
using _01.Script.Interface;
using _01.Script.Manager;
using _01.Script.Player;
using UnityEngine;

public class Pa : MonoBehaviour, IItem
{
    private GameObject _point;
    private OnDamagedPoint _onDamagedPoint;
    
    [SerializeField] GameObject player;
    private Player _player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        _player = player.GetComponent<Player>();
        _point = GameObject.Find("Point");
        _onDamagedPoint = _point.GetComponent<OnDamagedPoint>();
    }

    public void Use(GameObject target)
    {
        _player.isGetPa = true;
        _player.isGetNapa = false;
        if (_player.isGetPa)
        {
            _onDamagedPoint.damage = 2;
        }
        else
        {
            _onDamagedPoint.damage = 1;
        }
        
    }
}
