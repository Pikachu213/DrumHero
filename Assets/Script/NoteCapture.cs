using Minis;
using UnityEngine;
using UnityEngine.InputSystem;

public class NoteCapture : MonoBehaviour
{
    [SerializeField]
    private GameObject cube = null;

    [SerializeField]
    InputAction action = null;

    public RecordManager recordManager;

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
        recordManager.PadHit(controller.noteNumber);
    }
}
