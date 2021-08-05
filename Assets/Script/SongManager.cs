using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongManager : MonoBehaviour
{
    public NoteSequencer ns;

    void Start()
    {
        PointsCalculator.score = 0;
        //var song = XMLSaveLoader.LoadAllSongs();
        if (SongContainer.pickedSong == null) {
            ns.ShowNoteSequence(XMLSaveLoader.LoadAllSongs()[0]);
            //ns.ShowNoteSequence(XMLSaveLoader.LoadSong(Application.streamingAssetsPath + "/Songs/atutorial song.xml")); 
        }
        else
            ns.ShowNoteSequence(SongContainer.pickedSong);
    }

}
