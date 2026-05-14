using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeIntro : MonoBehaviour
{
    public Image fadeImage;
    public float fadeSpeed = 1f;

    void Start()
    {
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        Color color = fadeImage.color;

        while (color.a > 0)
        {
            color.a -= fadeSpeed * Time.deltaTime;
            fadeImage.color = color;

            yield return null;
        }

        color.a = 0;
        fadeImage.color = color;
    }
}
