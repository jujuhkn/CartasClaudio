
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorpoClick : MonoBehaviour
{
    void OnMouseDown()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("HistoriaFinal");
    }
}
