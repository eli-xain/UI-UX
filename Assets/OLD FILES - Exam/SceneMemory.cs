using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneMemory
{
    public static string PreviousSceneName;

    public static void SetPreviousScene()
    {
        PreviousSceneName = SceneManager.GetActiveScene().name;
    }
}
