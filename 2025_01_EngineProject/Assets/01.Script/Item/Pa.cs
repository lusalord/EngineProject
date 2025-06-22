using System;
using _01.Script.Interface;
using _01.Script.Player;
using UnityEngine;

namespace _01.Script.Item
{
    public class Pa : MonoBehaviour, IItem
    {
        private GameObject _point;
        private OnDamagedPoint _onDamagedPoint;
    
        [SerializeField] GameObject player;
        private Player.Player _player;

        private void Awake()
        {
            player = GameObject.FindGameObjectWithTag("Player");
            _player = player.GetComponent<Player.Player>();
            _point = GameObject.Find("Point");
            _onDamagedPoint = _point.GetComponent<OnDamagedPoint>();
        }

        

        public void Use(GameObject target)
        {
            _player.isGetPa = true;
            _player.isGetNapa = false;
            _onDamagedPoint.damage = 2;
        }
    }
}
