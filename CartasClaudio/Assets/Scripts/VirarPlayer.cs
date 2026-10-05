using UnityEngine;

public class VirarPlayer : MonoBehaviour
{
    public SpriteRenderer sprite;

    void Update()
    {
        // Direita: D ou seta direita
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            sprite.flipX = true;
        }

        // Esquerda: A ou seta esquerda
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            sprite.flipX = false;
        }
    }
}