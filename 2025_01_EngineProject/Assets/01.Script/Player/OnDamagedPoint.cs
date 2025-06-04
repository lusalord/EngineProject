using UnityEngine;

namespace _01.Script.Player
{
    public class OnDamagedPoint : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("맞았습니다");
        }
    }
}
