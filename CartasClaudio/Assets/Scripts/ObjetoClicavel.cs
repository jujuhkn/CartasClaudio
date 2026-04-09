using UnityEngine;


public class ObjetoClicavel : MonoBehaviour
{
    public UIManager uiManager;
    public string mensagem;

    private void OnMouseDown()
    {
        Debug.Log("CLICOU");
        uiManager.MostrarTexto(mensagem);
    }
}