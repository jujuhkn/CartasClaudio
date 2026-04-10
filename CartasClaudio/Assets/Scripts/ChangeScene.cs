using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public string CENA2;

    public void TrocarCena()
    {
        SceneManager.LoadScene(CENA2);
    }
}