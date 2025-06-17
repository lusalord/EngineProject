using System;
using _01.Script.Interface;
using _01.Script.Manager;
using _01.Script.Player;
using UnityEngine;

public class Pa : MonoBehaviour, IItem
{
    private GameObject _point;
    private OnDamagedPoint _onDamagedPoint;

    private void Awake()
    {
        _point = GameObject.Find("Point");
        _onDamagedPoint = _point.GetComponent<OnDamagedPoint>();
    }

    public void Use(GameObject target)
    {
        _onDamagedPoint.damage = 2;
    }
}
