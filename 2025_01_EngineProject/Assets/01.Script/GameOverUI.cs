using UnityEngine;
using UnityEngine.SceneManagement;

namespace _01.Script.Player
{
    public class GameOverUI : MonoBehaviour
    {
        private void Start()
        {
            gameObject.SetActive(false);
        }

        public void GameOver()
        {
            gameObject.SetActive(true);
        }

        public void Again()
        {
            SceneManager.LoadScene($"ManeScene");
        }
    }
}
