using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordIcon : MonoBehaviour
{
    public Image Image;
    private bool isRecording;
    private float currentTransparency;
    private float speed = 0.004f;
    private bool isAdd = false;
    public void StartRecording()
    {
        currentTransparency = 1;
        isRecording = true;
        isAdd = false;
    }

    public void Update()
    {
        if (isRecording)
        {
            Debug.Log(speed);
            Image.color = new Color(Image.color.r, Image.color.g, Image.color.b, currentTransparency);
            if (isAdd)
            {
                currentTransparency += speed;
            }
            else
            {
                currentTransparency -= speed;
            }


            if (currentTransparency <= 0)
                isAdd = true;
            else if(currentTransparency >= 1){
                isAdd = false;
            }

        }
    }

    public void StopRecording()
    {
        isRecording = false;
    }
}
