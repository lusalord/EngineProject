using _01.Script.Interface;
using UnityEngine;

namespace _01.Script.Item
{
    public class NapaCabbage : MonoBehaviour, IItem
    {
        private GameObject _point;
    
        [SerializeField] GameObject player;
        private Player.Player _player;
        public void Use(GameObject target)
        {
            var player = target.GetComponent<Player.Player>();
            if (player != null)
            {
                player.isGetPa = false;
                player.isGetNapa = true;
                Debug.Log("아이템 사용됨! hasItem = ");
            }
            else
            {
                Debug.LogWarning("Player 컴포넌트를 찾지 못함");
            }
            
        }
    }
}
