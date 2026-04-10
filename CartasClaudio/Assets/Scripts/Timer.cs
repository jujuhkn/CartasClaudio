using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time = 300f;
    public Text timerText;

    void Update()
    {
        time -= Time.deltaTime;

        int min = Mathf.FloorToInt(time / 60);
        int sec = Mathf.FloorToInt(time % 60);

        timerText.text = min.ToString("00") + ":" + sec.ToString("00");

        if (time <= 0)
        {
            UIManager.instance.ShowHint("Tempo acabou!");
        }
    }
}
