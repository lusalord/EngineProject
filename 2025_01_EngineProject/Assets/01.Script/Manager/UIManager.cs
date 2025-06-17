using _01.Script.Player;
using UnityEngine;

namespace _01.Script.Manager
{
    public class UIManager : MonoBehaviour
    {
        [field: SerializeField] public GameOverUI GameOverUI { get; private set; }
        [field: SerializeField] public HealthBarUI HealthUI { get; private set; }
        public static UIManager Instance { get; private set; }

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
