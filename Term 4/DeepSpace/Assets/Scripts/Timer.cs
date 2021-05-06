using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer
{
    private Text timeText;
    float elapsedTime;

    public Timer(Text textField)
    {
        timeText = textField;
        elapsedTime = 0;
        textField.text = "Time: 0";
    }

    public void Update()
    {
        elapsedTime += Time.deltaTime;
        timeText.text = "Time: " + (int)elapsedTime;
    }
}
