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

    public Track track;
    public Track track1;
    public Track track2;
    public Track track3;
    public Track track4;
    //public Track track5;
    //public Track track6;

    public void ShowNoteSequence(Song song) {
        this.song = song;
        isPlaying = true;
    }

    private void ShowNote(Note n)
    {
        int pad = n.pad;
        //Instantiate(new GameObject);
        switch (pad) {
            case 46:
                track.SpawnNote(n); break;   //to do: fix the queue of tracks
            case 42:
                track1.SpawnNote(n); break;
            case 45:
                track2.SpawnNote(n); break;
            case 40:
                track3.SpawnNote(n); break;
            case 43:
                track4.SpawnNote(n); break;
        }


        //track.SpawnNote(n);
        //Debug.Log(n.pad);
        //throw new NotImplementedException();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
