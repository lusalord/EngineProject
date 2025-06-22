using _01.Script.Enemy;
using UnityEngine;

namespace _01.Script.Item
{
    public class Ending : MonoBehaviour
    {
        private GameObject childObj;

        private void Start()
        {
            // 자식 오브젝트 찾기
            Transform childTransform = transform.Find("Clear");
            childObj = childTransform.gameObject;
        }

        public void Use(GameObject target)
        {
            if (!childObj.activeSelf) // 현재 비활성 상태인지 확인
            {
                childObj.SetActive(true);
            }
            Time.timeScale = 0;
        }
    }
}
