using UnityEngine;

public class ExitGameBtn : MonoBehaviour
{
    public void OnClick()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }
}
