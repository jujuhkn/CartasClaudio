using UnityEngine;

public class IdlePlayer : MonoBehaviour
{
    public float altura = 0.05f;
    public float velocidade = 2f;

    private Vector3 posicaoInicial;

    void Start()
    {
        posicaoInicial = transform.localPosition;
    }

    void Update()
    {
        float movimento = Mathf.Sin(Time.time * velocidade) * altura;

        transform.localPosition = posicaoInicial + new Vector3(0, movimento, 0);
    }
}