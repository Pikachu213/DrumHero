using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Song 
{
    public string title { get; set; }
    public int bpm { get; set; }
    public List<Note> notes { get; set; }
}
