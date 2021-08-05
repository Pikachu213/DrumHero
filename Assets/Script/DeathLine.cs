using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "note")
        {
            Destroy(other.gameObject);
        }
    }
}
