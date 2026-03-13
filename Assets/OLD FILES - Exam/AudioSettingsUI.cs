using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AudioSettingUI : MonoBehaviour
{
    public Slider volumeSlider;
    public TMP_Text volumeText;

    private const string PREF_KEY = "MusicVolume";

    void Start()
    {
        // Load saved value (or default)
        float value = PlayerPrefs.GetFloat(PREF_KEY, 0.5f);

        volumeSlider.value = value;
        UpdateText(value);

        volumeSlider.onValueChanged.AddListener(OnValueChanged);
    }

    void OnValueChanged(float value)
    {
        PlayerPrefs.SetFloat(PREF_KEY, value);
        UpdateText(value);
    }

    void UpdateText(float value)
    {
        int percent = Mathf.RoundToInt(value * 100);
        volumeText.text = percent + "%";
    }
}
