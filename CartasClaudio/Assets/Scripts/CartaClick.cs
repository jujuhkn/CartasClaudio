using UnityEngine;

public class CartaClick : MonoBehaviour
{
    public GameObject cartaUI;

    private bool aberta = false;
    private bool jaFoiLida = false;

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

            Time.timeScale = 1f;
        }
    }
}