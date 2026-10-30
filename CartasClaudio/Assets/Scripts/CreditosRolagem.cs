
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditosRolagem : MonoBehaviour
{
    public float velocidade = 50f;

    private RectTransform texto;

    void Start()
    {
        texto = GetComponent<RectTransform>();

        texto.anchoredPosition = new Vector2(
            texto.anchoredPosition.x,
            -Screen.height / 2f - texto.rect.height / 2f
        );
    }

    void Update()
    {
        texto.anchoredPosition += Vector2.up *
            velocidade * Time.deltaTime;

        if (texto.anchoredPosition.y >
            Screen.height / 2f + texto.rect.height / 2f)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
