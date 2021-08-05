using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSequencer : MonoBehaviour
{
    int NextNote = 0;
    float timer;
    Song song;
    bool isPlaying = false;
    public List<Track> tracks;
    public List<ChangeColor> cubes = new List<ChangeColor>();

    public void ShowNoteSequence(Song song) {
        this.song = song;
        isPlaying = true;
    }

    private void ShowNote(Note n)
    {
        int pad = n.pad;

        for(int i = 0; i < tracks.Count; i++)
        {
            if (tracks[i].trackNumber == pad)
            {
                tracks[i].SpawnNote(n);
            }
            
            if (i < cubes.Count && cubes[i].trackNumber == pad)
            {
                cubes[i].ChangePadColor();
            }              
        }
    }

    void Update()
    {
        if (isPlaying)
        {
            timer += Time.deltaTime;

            if (song.notes != null && NextNote < song.notes.Count)
            {
                Note n = song.notes[NextNote];
                if (timer > n.t)
                {
                    ShowNote(n);
                    NextNote++;
                }
            }
        }
    }
}
