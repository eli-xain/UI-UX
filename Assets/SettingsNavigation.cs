using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsNavigation : MonoBehaviour
{
    [Header("Panels")]
    public GameObject graphicsPanel;
    public GameObject audioPanel;
    public GameObject languagePanel;

    [Header("Navigation Buttons")]
    public Button graphicsButton;
    public Button audioButton;
    public Button languageButton;

    [Header("Return")]
    public string previousSceneName;

    void Start()
    {
        // Default tab when opening Settings
        OpenGraphics();

        // Button listeners
        graphicsButton.onClick.AddListener(OpenGraphics);
        audioButton.onClick.AddListener(OpenAudio);
        languageButton.onClick.AddListener(OpenLanguage);
    }

    void HideAllPanels()
    {
        graphicsPanel.SetActive(false);
        audioPanel.SetActive(false);
        languagePanel.SetActive(false);
    }

    public void OpenGraphics()
    {
        HideAllPanels();
        graphicsPanel.SetActive(true);
    }

    public void OpenAudio()
    {
        HideAllPanels();
        audioPanel.SetActive(true);
    }

    public void OpenLanguage()
    {
        HideAllPanels();
        languagePanel.SetActive(true);
    }

    public void ReturnToPreviousScene()
    {
        if (!string.IsNullOrEmpty(SceneMemory.PreviousSceneName))
            SceneManager.LoadScene(SceneMemory.PreviousSceneName);
        else
            Debug.LogWarning("Previous scene not set!");
    }

}
