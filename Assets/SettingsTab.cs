using UnityEngine;
using UnityEngine.UI;

public class SettingsTabs : MonoBehaviour
{
    [System.Serializable]
    public class Tab
    {
        public Button button;
        public GameObject panel; // The panel associated with this tab
    }

    public Tab graphicsTab;
    public Tab audioTab;
    public Tab languageTab;

    public Color selectedColor = Color.white;
    public Color defaultColor = Color.gray;

    private Tab activeTab;

    void Start()
    {
        // Open default tab
        SelectTab(graphicsTab);

        // Add listeners
        graphicsTab.button.onClick.AddListener(() => SelectTab(graphicsTab));
        audioTab.button.onClick.AddListener(() => SelectTab(audioTab));
        languageTab.button.onClick.AddListener(() => SelectTab(languageTab));
    }

    public void SelectTab(Tab tabToSelect)
    {
        if (activeTab == tabToSelect) return; // Already selected

        // Deselect previous
        if (activeTab != null)
        {
            SetTabVisual(activeTab, false);
            if (activeTab.panel != null) activeTab.panel.SetActive(false);
        }

        // Select new
        activeTab = tabToSelect;
        SetTabVisual(activeTab, true);
        if (activeTab.panel != null) activeTab.panel.SetActive(true);
    }

    private void SetTabVisual(Tab tab, bool selected)
    {
        var colors = tab.button.colors;
        colors.normalColor = selected ? selectedColor : defaultColor;
        tab.button.colors = colors;
    }
}
