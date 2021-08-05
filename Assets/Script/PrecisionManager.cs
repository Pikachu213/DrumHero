using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrecisionManager : MonoBehaviour
{
    public ZonePrecision fullPrecision;
    public ZonePrecision halfPrecision1;
    public ZonePrecision halfPrecision2;


    long milisecondsToPause = 250;
    private Dictionary<int, float> padLastTimestamp = new Dictionary<int, float>();


    public void PadHit(int pad)
    {
        /*long currentMilsec = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000;
        if (!padLastTimestamp.ContainsKey(pad))
            padLastTimestamp.Add(pad, 0);
       
        if (padLastTimestamp[pad] + milisecondsToPause > currentMilsec)
            return;

        padLastTimestamp[pad]= currentMilsec;*/


        Debug.Log("PAD " + pad);
        if (fullPrecision.CheckNotePresent(pad))
        {
            //fullPrecision.DeleteNoteFromPad(pad);
            PointsCalculator.score += 100;
            Debug.Log("100% PAD " + pad);

        }
        else if (halfPrecision1.CheckNotePresent(pad))
        {
            //halfPrecision1.DeleteNoteFromPad(pad);
            PointsCalculator.score += 50;
            Debug.Log("50% 1 PAD " + pad);

        }
        else if (halfPrecision2.CheckNotePresent(pad))
        {
            //halfPrecision2.DeleteNoteFromPad(pad);
            PointsCalculator.score += 50;
            Debug.Log("50% 2 PAD " + pad);

        }
    }
}
