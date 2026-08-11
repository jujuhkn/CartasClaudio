using UnityEngine;



public class PistaImagem : MonoBehaviour
{
    public GameObject pistaUI;

    private bool aberta = false;

    void OnMouseDown()
    {
        if (aberta)
            return;

        aberta = true;

        pistaUI.SetActive(true);

        Time.timeScale = 0f;
    }

    void Update()
    {
        if (aberta && Input.GetKeyDown(KeyCode.Escape))
        {
            pistaUI.SetActive(false);

            aberta = false;

            Time.timeScale = 1f;
        }
    }
}