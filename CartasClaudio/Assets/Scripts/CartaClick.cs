

using UnityEngine;

public class CartaClick : MonoBehaviour
{
    public GameObject cartaUI;
    public GameObject corpo;

    private bool aberta = false;
    private bool jaFoiLida = false;

    void Start()
    {
        corpo.SetActive(false);
    }

    void OnMouseDown()
    {
        if (jaFoiLida)
            return;

        aberta = true;
        cartaUI.SetActive(true);

        Time.timeScale = 0f;
    }

    void Update()
    {
        if (aberta && Input.GetKeyDown(KeyCode.Escape))
        {
            cartaUI.SetActive(false);

            aberta = false;
            jaFoiLida = true;

            corpo.SetActive(true);

            Time.timeScale = 1f;
        }
    }
}

