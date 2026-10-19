
using UnityEngine;
using UnityEngine.UI;

public class ControleVolume : MonoBehaviour
{
    public Slider sliderVolume;
    public AudioSource musica;

    void Start()
    {
        sliderVolume.minValue = 0f;
        sliderVolume.maxValue = 1f;

        sliderVolume.value = musica.volume;

        sliderVolume.onValueChanged.AddListener(
            AlterarVolume
        );
    }

    public void AlterarVolume(float volume)
    {
        musica.volume = volume;
    }

    void OnDestroy()
    {
        if (sliderVolume != null)
        {
            sliderVolume.onValueChanged.RemoveListener(
                AlterarVolume
            );
        }
    }
}
