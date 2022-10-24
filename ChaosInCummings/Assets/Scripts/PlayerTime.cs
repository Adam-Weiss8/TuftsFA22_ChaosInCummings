using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTime : MonoBehaviour
{
    public Timer script;
    public TextMeshProUGUI pTime;

    void Update() 
    {
        pTime.text = script.currentTime.ToString("0.000");
    }


}
