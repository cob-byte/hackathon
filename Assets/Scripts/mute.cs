using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mute : MonoBehaviour
{
    private bool isOn;
    public Button button;
    public AudioSource audioSource;
    public void ButtonClicked()
    {
        if (isOn)
        {
            audioSource.mute = true;
        }
        else
        {
            audioSource.mute = false;
        }
    }

}
