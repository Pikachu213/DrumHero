using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RecordManager : MonoBehaviour
{
    List<Note> notes = new List<Note>();
    private float time;
    private bool isRec;
    public InputField inputField;
    public RecordIcon RecordIcon;

    void Update()
    {
        if (isRec)
        {
            time += Time.deltaTime;
        }
    }

    public void PadHit(int pad) {
        Note note = new Note(pad, time);
        notes.Add(note);
    }

    public void StartRecording() {
        time = 0;
        isRec = true;
        RecordIcon.StartRecording();
    }

    public void FinishRecording() {
        isRec = false;
        RecordIcon.StopRecording();
        string title = string.IsNullOrEmpty(inputField.text) ? "Unknown" : inputField.text;
        Song song = new Song(notes, title);
        XMLSaveLoader.WriteSong(song);      
    }

    public void ToMainMenu() {
        SceneManager.LoadScene("MainMenu");
    }
}
