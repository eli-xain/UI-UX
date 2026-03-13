using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject pausePanel;
    public Button pauseButton;

    [Header("Settings")]
    public string mainMenuSceneName = "MainMenu";

    void Start()
    {
        pausePanel.SetActive(false);
        pauseButton.gameObject.SetActive(true);
    }

    public void PauseGame()
    {
        pausePanel.SetActive(true);    
        pauseButton.gameObject.SetActive(false); 
        Time.timeScale = 0f;      
    }

    public void ContinueGame()
    {
        pausePanel.SetActive(false);   
        pauseButton.gameObject.SetActive(true); 
        Time.timeScale = 1f;           
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(mainMenuSceneName);
    }
}