using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    public AudioSource source;
    public AudioClip GetAudioClip(string soundName)
    {
        AudioClip audioClip = Resources.Load<AudioClip>(soundName);
        if (audioClip == null)
        {
            Debug.LogError("Audioclip " + soundName + " not found");
        }
        return audioClip;
    }

    public void Start()
    {
        string songName = SongContainer.pickedSong.title;

        AudioClip clip = GetAudioClip(songName);
        source.clip = clip;
        source.Play();
    }
}
