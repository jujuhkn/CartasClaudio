
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject painelCreditos;
    public GameObject painelConfiguracoes;

    public string nomeCenaJogo = "RealFinalBoss";

    public void Play()
    {
        SceneManager.LoadScene(nomeCenaJogo);
    }

    public void Creditos()
    {
        painelCreditos.SetActive(true);
    }

    public void Configuracoes()
    {
        painelConfiguracoes.SetActive(true);
    }

    public void Sair()
    {
        Application.Quit();
    }

    public void FecharCreditos()
    {
        painelCreditos.SetActive(false);
    }

    public void FecharConfiguracoes()
    {
        painelConfiguracoes.SetActive(false);
    }
}
