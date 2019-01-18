using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volume;


    /*public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }*/

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }


    public void OnValueChange()
    {
        AudioListener.volume = volume.value;
    }


}
