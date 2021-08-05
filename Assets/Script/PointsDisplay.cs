using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointsDisplay : MonoBehaviour
{
    public Text points;
    //int p = 0;
    
    void Update()
    {
        points.text = PointsCalculator.score.ToString();       
    }
}
//points.text = p.ToString();
