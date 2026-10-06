using UnityEngine;
using UnityEngine.EventSystems;

public class BotaoAnimado : MonoBehaviour
{
    public float altura = 8f;
    public float velocidade = 2f;

    public float tamanhoMouse = 1.15f;
    public float velocidadeTamanho = 8f;

    private Vector3 posicaoInicial;
    private Vector3 tamanhoNormal;
    private bool mouseEmCima = false;

    void Start()
    {
        posicaoInicial = transform.localPosition;
        tamanhoNormal = transform.localScale;
    }

    void Update()
    {
        // Levitação
        float movimento = Mathf.Sin(Time.time * velocidade) * altura;

        transform.localPosition = posicaoInicial + new Vector3(0, movimento, 0);

        // Tamanho
        Vector3 tamanhoAlvo = mouseEmCima
            ? tamanhoNormal * tamanhoMouse
            : tamanhoNormal;

        transform.localScale = Vector3.Lerp(
            transform.localScale,
            tamanhoAlvo,
            Time.deltaTime * velocidadeTamanho
        );
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouseEmCima = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouseEmCima = false;
    }
}