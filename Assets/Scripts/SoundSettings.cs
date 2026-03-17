using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SoundSettings : MonoBehaviour
{
    public Slider SoundSlider;
    public AudioMixer MasterMixer;

    void Start()
    {
        SetVolume(PlayerPrefs.GetFloat("MasterVolume", 100));
    }

    public void SetVolume(float Value)
    {
        if(Value < 1)
        {
            Value = 0.001f;
        }

        RefreshSlider(Value);
        PlayerPrefs.SetFloat("MasterVolume", Value);
        MasterMixer.SetFloat("MasterVolume", Mathf.Log10(Value/100) * 20f);
    }

    public void SetVolumeFromSlider()
    {
        SetVolume(SoundSlider.value);
    }

    public void RefreshSlider(float Value)
    {
        SoundSlider.value = Value;
    }
}
