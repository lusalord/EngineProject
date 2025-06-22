using UnityEngine;

namespace _01.Script
{
    public class GameOver : MonoBehaviour
    {
        [SerializeField] private GameObject gameOverPanel;
        private HealthSystem _playerScript;

        private void Awake()
        {
            _playerScript = GetComponent<HealthSystem>();
        }

        private void Update()
        {
            if (_playerScript.isDead)
            {
                gameOverPanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
