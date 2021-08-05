using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ZonePrecision : MonoBehaviour
{
    public List<NotePlayable> notes;
    public GameObject particle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "note")
        {
            notes.Add(other.gameObject.GetComponent<NotePlayable>());
            Debug.Log("ENTER " + other.gameObject.GetComponent<NotePlayable>().trackN);

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "note")
        {
            notes.Remove(other.gameObject.GetComponent<NotePlayable>());
            Debug.Log("EXIT " + other.gameObject.GetComponent<NotePlayable>().trackN);
        }
    }

    public bool CheckNotePresent(int pad) {
        //return notes.Any(n => n.trackN == pad);
        var note = notes.FirstOrDefault(n => n.trackN == pad);
        if (note == null)
            return false;

        notes.Remove(note);
        Instantiate(particle, note.transform.position + new Vector3(0, 50, 0), Quaternion.Euler(90, 0, 0));
        Destroy(note.gameObject);

        return true;
    }

    public void DeleteNoteFromPad(int pad) {
        var note = notes.FirstOrDefault(n => n.trackN == pad);
        if (note != null)
        {
            Instantiate(particle, transform.position, transform.rotation);
        }
        notes.Remove(note);
        Destroy(note.gameObject);


    }
}
