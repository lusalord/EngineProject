using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace _01.Script
{
    public class PauseBtn : MonoBehaviour
    {   
        [SerializeField] private GameObject pausePanel;
        
        public void BtnClick()
        {
            if (pausePanel.activeSelf == false)
            {
                pausePanel.SetActive(true);
                Time.timeScale = 0;
            }
            else if (pausePanel.activeSelf == true)
            {
                pausePanel.SetActive(false);
                Time.timeScale = 1;
            }
        }
        
        private void Update()
        {
            if (Keyboard.current.escapeKey.wasPressedThisFrame)
            {
                if (pausePanel.activeSelf == false)
                {
                    pausePanel.SetActive(true);
                    Time.timeScale = 0;
                }
                else if (pausePanel.activeSelf == true)
                {
                    pausePanel.SetActive(false);
                    Time.timeScale = 1;
                }
            }
        }
    }
}
