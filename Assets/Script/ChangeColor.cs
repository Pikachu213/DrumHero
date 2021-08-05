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
    public int trackNumber;
    [SerializeField]
    InputAction action = null;

    public PrecisionManager precisionManager;


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
        precisionManager.PadHit(controller.noteNumber);


        //color changing
        var cubeRenderer = cube.GetComponent<Renderer>();

        System.Random ran = new System.Random();
        //int r = (int)(255 * controller.velocity / (ran.NextDouble() * 8));
        //int g = (int)(255 * controller.velocity / (ran.NextDouble() * 8));
        //int b = (int)(255 * controller.velocity / (ran.NextDouble() * 8));

        int r = (int)(255 * 2.5 / (ran.NextDouble() * 8));
        int g = (int)(255 * 2 / (ran.NextDouble() * 8));
        int b = (int)(255 * 2 / (ran.NextDouble() * 8));

        cubeRenderer.material.SetColor("_Color", new Color(r / 255f, g / 255f, b / 255f));
    }

    public void ChangePadColor() {

        var cubeRenderer = cube.GetComponent<Renderer>();

        System.Random ran = new System.Random();
        int r = (int)(255 * 2.5 / (ran.NextDouble() * 8));
        int g = (int)(255 * 2 / (ran.NextDouble() * 8));
        int b = (int)(255 * 2.5 / (ran.NextDouble() * 8));

        cubeRenderer.material.SetColor("_Color", new Color(r / 255f, g / 255f, b / 255f));

        StartCoroutine(SetToDefaultColor());
    }

    public IEnumerator SetToDefaultColor()
    {
        yield return new WaitForSeconds(7);
        var cubeRenderer = cube.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", new Color(1, 1, 1));
    }
}
