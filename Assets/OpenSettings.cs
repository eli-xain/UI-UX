using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenSettings : MonoBehaviour
{
    public string settingsSceneName = "Settings";

    public void OpenSettingsScene()
    {
        SceneMemory.SetPreviousScene();
        SceneManager.LoadScene(settingsSceneName);
    }
}
