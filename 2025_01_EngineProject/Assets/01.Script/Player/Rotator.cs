using UnityEngine;

namespace _01.Script.Player
{
    public class Rotator : MonoBehaviour
    {
        private Camera _camera;
        public Transform player;

        private void Awake()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            transform.position = player.position;
            Vector2 mousePos = _camera.ScreenToWorldPoint(Input.mousePosition); // 마우스 좌표 위치 찾아줌
            Vector2 dirVec = mousePos - (Vector2)transform.position;
        
            transform.up = dirVec.normalized;
        }
    }
}
