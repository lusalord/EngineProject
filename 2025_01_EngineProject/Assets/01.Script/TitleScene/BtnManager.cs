using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnManager : MonoBehaviour
{
    public void OnStartBtn()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnExitBtn()
    {
        Application.Quit();
    }
}
