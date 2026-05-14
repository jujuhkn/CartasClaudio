using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public string CenaCena;

    public void TrocarCena()
    {
        SceneManager.LoadScene("CenaCena");
    }
}