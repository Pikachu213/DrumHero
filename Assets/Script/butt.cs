using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class butt : MonoBehaviour
{
    public Dropdown d;

    private List<Song> allSongs;
    // Start is called before the first frame update
    void Start()
    {
        d.options.Clear();
        allSongs = XMLSaveLoader.LoadAllSongs();
        foreach (Song s in allSongs)
        {
            d.options.Add(new Dropdown.OptionData() { text = s.title });
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPlayButtonClick()
    {
        SongContainer.pickedSong = allSongs[d.value];
        PlayerPrefs.SetInt("selectedSong", d.value);
        SceneManager.LoadScene("ColorScene");
    }
}
