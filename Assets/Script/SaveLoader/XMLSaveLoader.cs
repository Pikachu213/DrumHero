using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using UnityEngine;

public class XMLSaveLoader
{

    public static void WriteSong(Song song) {
        try
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Song));
            FileStream stream = new FileStream(Application.streamingAssetsPath + "/Songs/" + song.title + ".xml", FileMode.Create);
            serializer.Serialize(stream,song);
            stream.Close();
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }


    public static Song LoadSong(string path)
    {
        Song song = null;
        try
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Song));
            FileStream stream = new FileStream(path, FileMode.Open);
            song = serializer.Deserialize(stream) as Song;
            stream.Close();

        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
        return song;  
    }

    public static List<Song> LoadAllSongs()
    {
        List<Song> songList = new List<Song>();
        var a = Directory.EnumerateFiles(Application.streamingAssetsPath + "/Songs", "*.xml");
        //foreach on all files in folder
        foreach (string file in Directory.EnumerateFiles(Application.streamingAssetsPath + "/Songs", "*.xml"))
        {          
            songList.Add(LoadSong(file));
        }
        //load song

        //add it to list

        return songList;
    }
}
