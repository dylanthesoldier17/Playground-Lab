using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveScore : MonoBehaviour
{
    public string scoreFileName;
    public Score score;
    private void OnDestroy()
    {
        string json = JsonUtility.ToJson(score);
        File.WriteAllText(Application.persistentDataPath + "/" + scoreFileName, json);
    }

    public void AddToScore(int numberToAdd)
    {
        score.value += numberToAdd;
    }
}
