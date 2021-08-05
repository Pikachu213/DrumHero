using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioooo : MonoBehaviour
{
    public AudioSource source;
    public AudioClip audio1;
    public AudioClip audio2;
    public AudioClip audio3;

    public void Start() {
        int selectedIndex = PlayerPrefs.GetInt("selectedSong");
        if (selectedIndex == 4) {
            source.clip = audio1;
            source.Play();
        }       
    }
}
