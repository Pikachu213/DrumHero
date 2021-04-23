using Minis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class ChangeColor : MonoBehaviour
{
    [SerializeField]
    private GameObject cube = null;

    [SerializeField]
    InputAction action = null;


    void OnEnable()
    {
        action.performed += OnPerformed;
        action.Enable();
    }

    void OnDisable()
    {
        action.performed -= OnPerformed;
        action.Disable();
    }

    void OnPerformed(InputAction.CallbackContext ctx)
    {
        MidiNoteControl controller = ctx.control as MidiNoteControl;
        var cubeRenderer = cube.GetComponent<Renderer>();

        //var inputForce = ctx.
        System.Random ran = new System.Random();
        int r = (int)(255 * controller.velocity/(ran.NextDouble()*8));
        int g = (int)(255 * controller.velocity / (ran.NextDouble()*8));
        int b = (int)(255 * controller.velocity / (ran.NextDouble()*8));



        cubeRenderer.material.SetColor("_Color", new Color(r/ 255f, g/ 255f, b/ 255f));


    }
}
