using UnityEngine;

public class TesteClique : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log("ACERTOU: " + hit.collider.name);
            }
            else
            {
                Debug.Log("CLICOU EM NADA");
            }
        }
    }
}