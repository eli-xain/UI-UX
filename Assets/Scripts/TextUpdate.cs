using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextUpdate : MonoBehaviour
{
    public Slider Slider;
    public TMP_Text Text;

    private const string PREF_KEY = "SliderVALUE";

    void Start()
    {
        float value = PlayerPrefs.GetFloat(PREF_KEY, 0.5f);

        Slider.value = value;
        UpdateText(value);

        Slider.onValueChanged.AddListener(OnValueChanged);
    }

    void OnValueChanged(float value)
    {
        PlayerPrefs.SetFloat(PREF_KEY, value);
        UpdateText(value);
    }

    void UpdateText(float value)
    {
        int percent = Mathf.RoundToInt(value * 100);
        Text.text = percent + "%";
    }
}
