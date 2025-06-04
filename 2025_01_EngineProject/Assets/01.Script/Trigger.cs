using UnityEngine;
using UnityEngine.Tilemaps;

namespace _01.Script
{
    public class Trigger : MonoBehaviour
    {
        [SerializeField] private Tilemap tilemap;

        private void Start()
        {
            tilemap.gameObject.SetActive(false);//초기 문 안보이게 하기
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            tilemap.gameObject.SetActive(true); // 플레이어 방에 들어오면 문 활성화
            Destroy(gameObject); // 트리거 삭제;
        }
    }
}
