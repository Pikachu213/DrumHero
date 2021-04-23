using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongManager : MonoBehaviour
{
    public NoteSequencer ns;

    void Start()
    {
        var song = XMLSaveLoader.LoadAllSongs();
        ns.ShowNoteSequence(song[0]);
    }

}
