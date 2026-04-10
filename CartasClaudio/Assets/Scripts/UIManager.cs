using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public TMP_Text hintText;

    void Awake()
    {
        instance = this;
    }

    public void ShowHint(string text)
    {
        hintText.text = text;
        hintText.gameObject.SetActive(true);
    }

    public void HideHint()
    {
        hintText.gameObject.SetActive(false);
    }
}