using UnityEngine;

public class VirarPlayer : MonoBehaviour
{
    public SpriteRenderer sprite;

    void Update()
    {
        
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            sprite.flipX = true;
        }
      
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            sprite.flipX = false;
        }
    }// nossa que legal fazer um trabalhoem dupla, absolutamente sozinha. a inutilidade das pessoas é algo impressionante, tal como a incapacidade de aprender...
}