using UnityEngine;
using UnityEngine.SceneManagement;

namespace _01.Script
{
    public class ButtonManager : MonoBehaviour
    {
        public ButtonManager Instance {get; private set;}
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

        // Update is called once per frame
        public void OnRestartBtn()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void OnExitBtn()
        {
            Application.Quit();
        }
    }
}
