using TMPro;
using UnityEngine;



public class UIManager : MonoBehaviour
{
    public TMP_Text texto;

    public void MostrarTexto(string msg)
    {
        texto.text = msg;
    }
}