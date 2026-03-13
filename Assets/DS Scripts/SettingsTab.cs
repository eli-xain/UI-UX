using UnityEngine;
using UnityEngine.UI;

public class SettingsTab : MonoBehaviour
{
    [System.Serializable]
    public class Tab
    {
        public Toggle toggle; 
        public GameObject panel; 
    }

    public Tab graphicsTab;
    public Tab audioTab;
    public Tab languageTab;

    public Color selectedColor = Color.white;
    public Color defaultColor = Color.gray;

    void Start()
    {
        InitializeTab(graphicsTab);
        InitializeTab(audioTab);
        InitializeTab(languageTab);

        graphicsTab.toggle.isOn = true;
        SelectTab(graphicsTab, true);
    }

    private void InitializeTab(Tab tab)
    {
        tab.toggle.onValueChanged.AddListener((isOn) => {
            if (isOn) SelectTab(tab, true);
            else SelectTab(tab, false);
        });
    }

    public void SelectTab(Tab tab, bool isSelected)
    {
        if (tab.panel != null) 
            tab.panel.SetActive(isSelected);

        SetTabVisual(tab, isSelected);
    }

    private void SetTabVisual(Tab tab, bool selected)
    {
        var colors = tab.toggle.colors;
        colors.normalColor = selected ? selectedColor : defaultColor;
        tab.toggle.colors = colors;
    }
}