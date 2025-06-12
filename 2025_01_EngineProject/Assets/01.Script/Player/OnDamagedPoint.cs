using UnityEngine;

namespace _01.Script.Player
{
    public class OnDamagedPoint : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other) // 플레이어 공격 콜라이더
        {
            Debug.Log("맞았습니다");
        }
    }
}
