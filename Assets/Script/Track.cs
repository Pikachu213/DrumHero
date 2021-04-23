using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track : MonoBehaviour
{
    public int trackNumber;
    public GameObject notePrefab;

    //NotePlayable[] noteOnTrack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnNote(Note n) {
        if (n.pad == trackNumber) {
            Debug.Log(n.pad+" note spawned on " + trackNumber + " track.");
            Instantiate(notePrefab, transform.position, Quaternion.identity);
        }
    }
}
