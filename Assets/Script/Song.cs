using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Song 
{
    public Song() { }
    public Song(List<Note> notes, string title)
    {
        this.notes = notes;
        this.title = title;
    }

    public string title { get; set; }
    public int bpm { get; set; }
    public List<Note> notes { get; set; }
}
