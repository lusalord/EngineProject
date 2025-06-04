using UnityEngine;

namespace _01.Script.Manager
{
    public class UIManager : MonoBehaviour
    {
        private static UIManager Instance { get; set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    
    }
}
