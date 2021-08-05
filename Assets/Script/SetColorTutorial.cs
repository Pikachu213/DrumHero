using Minis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class SetColorTutorial : MonoBehaviour
{
    [SerializeField]
    private GameObject cube = null;
    public float startTime;
    public float targetTime;


    void Start() {
        var cubeRenderer = cube.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", Color.white);
    }


    void Update() {
        startTime += Time.deltaTime;
        targetTime -= Time.deltaTime;
        if (Time.deltaTime >= startTime) {
            timerStarted();
        }
        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

    }

    void timerStarted() {
        var cubeRenderer = cube.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", Color.yellow);
    }

    void timerEnded()
    {
        var cubeRenderer = cube.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", Color.white);
    }
}


    //void OnPerformed(InputAction.CallbackContext ctx)
    //{
        /*MidiNoteControl controller = ctx.control as MidiNoteControl;
        precisionManager.PadHit(controller.noteNumber);
        */

        //color changing
        //var cubeRenderer = cube.GetComponent<Renderer>();
/*
        System.Random ran = new System.Random();
        int r = (int)(255 * controller.velocity / (ran.NextDouble() * 8));
        int g = (int)(255 * controller.velocity / (ran.NextDouble() * 8));
        int b = (int)(255 * controller.velocity / (ran.NextDouble() * 8));
        */


        //cubeRenderer.material.SetColor("_Color", Color.green);


    //}

