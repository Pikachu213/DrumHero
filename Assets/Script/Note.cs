using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Note 
{
    // private float time;
    public Note() { }
    public Note(int pad, float time)
    {
        this.pad = pad;
        this.t = time;
    }

    public int pad { get; set; } //noteNumber of pad
    public float t { get; set; } //time when the note should be hit

}
