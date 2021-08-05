using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startColor : MonoBehaviour
{
    SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = new Color(1, 0, 0, 1);
    }
}
