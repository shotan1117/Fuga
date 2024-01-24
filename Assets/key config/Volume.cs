using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider Slider;
    public string volumeName;

    void Start()
    {
        
    }

    public void InputSensitivity()
    {
        audioMixer.SetFloat(volumeName, Slider.value);
    }
}
