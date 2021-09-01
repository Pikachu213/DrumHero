using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePlayable : MonoBehaviour
{
    private float moveSpeed = 200f;
    //private Rigidbody rb = GetComponent<Rigidbody>();

    private bool wasInvoked = false;

    public int trackN;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;       
    }


    /*private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Note entered the triger");
        Destroy(this.gameObject);
    }*/

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * moveSpeed * Vector3.right;
    }

    //private void OnCollisionEnter(Collision collision)
    //{
        //if (collision.gameObject.tag == "deathline")
        //{
           // Destroy(gameObject);
        //}
   // }

}
