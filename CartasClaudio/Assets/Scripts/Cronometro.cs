using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cronometro : MonoBehaviour
{
    public TMP_Text textoCronometro;
    public GameObject painelTempoEsgotado;

    public float tempoRestante = 300f;

    private bool acabou = false;

    void Start()
    {
        painelTempoEsgotado.SetActive(false);
        AtualizarTexto();
    }

    void Update()
    {
        if (acabou)
            return;

        tempoRestante -= Time.deltaTime;

        if (tempoRestante <= 0)
        {
            tempoRestante = 0;
            acabou = true;

            AtualizarTexto();

            painelTempoEsgotado.SetActive(true);
        }

        AtualizarTexto();
    }

    void AtualizarTexto()
    {
        int minutos = Mathf.FloorToInt(tempoRestante / 60);
        int segundos = Mathf.FloorToInt(tempoRestante % 60);

        textoCronometro.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }

    public void TentarNovamente()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Sair()
    {
        Application.Quit();
    }
}