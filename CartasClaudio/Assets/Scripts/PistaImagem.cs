using UnityEngine;
using UnityEngine.UI;

public class PistaImagem : MonoBehaviour
{
    public GameObject painelImagem;
    public Image imagemGrande;
    public Sprite imagemDaPista;

    private void OnMouseDown()
    {
        painelImagem.SetActive(true);
        imagemGrande.sprite = imagemDaPista;
    }

    private void Update()
    {
        if (painelImagem.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            painelImagem.SetActive(false);
        }
    }

}
