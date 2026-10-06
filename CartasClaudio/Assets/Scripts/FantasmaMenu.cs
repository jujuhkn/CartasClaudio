using UnityEngine;

public class FantasmaMenu : MonoBehaviour
{
    public float velocidade = 50f;
    public float distancia = 250f;

    private Vector3 posicaoInicial;
    private bool indoDireita = true;

    public SpriteRenderer sprite;

    void Start()
    {
        posicaoInicial = transform.localPosition;
    }

    void Update()
    {
        if (indoDireita)
        {
            transform.localPosition += Vector3.right * velocidade * Time.deltaTime;

            sprite.flipX = false;

            if (transform.localPosition.x >= posicaoInicial.x + distancia)
            {
                indoDireita = false;
            }
        }
        else
        {
            transform.localPosition += Vector3.left * velocidade * Time.deltaTime;

            sprite.flipX = true;

            if (transform.localPosition.x <= posicaoInicial.x - distancia)
            {
                indoDireita = true;
            }
        }
    }
}