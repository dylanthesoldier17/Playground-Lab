using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TimerDisplay : MonoBehaviour
{
    public TMP_Text displayText;
    private int secondsElapsed = 0;
    private void Awake()
    {
        InvokeRepeating(nameof(UpdateDisplay), 0f, 1f);
    }

    public void UpdateDisplay()
    {
        secondsElapsed++;
        displayText.text = secondsElapsed.ToString();
    }
}
