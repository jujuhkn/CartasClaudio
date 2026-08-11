using UnityEngine;

public class DicaAgua : MonoBehaviour
{
    public GameObject dicaUI;

    private bool jaMostrou = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (jaMostrou)
            return;

        if (other.CompareTag("Player"))
        {
            dicaUI.SetActive(true);
            jaMostrou = true;
        }
    }

    private void Update()
    {
        if (dicaUI.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            dicaUI.SetActive(false);
        }
    }
}
