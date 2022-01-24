using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public string saveFileName;
    private string saveFilePath;
    private LeaderBoard leaderBoard;
    public Text[] scoreTextObjects;

    private void Awake()
    {
        saveFilePath = Application.persistentDataPath + "/" + saveFileName;
        
        loadFromJson(saveFilePath);
        if (leaderBoard == null)
            leaderBoard = new LeaderBoard();

        updateScoreTextObjects();
    }

    public void addToLeaderBoard(int score)
    {
        leaderBoard.AddScore(score);
        updateScoreTextObjects();
    }

    private void updateScoreTextObjects()
    {
        for (int i = 1; i < 6; i++)
        {
            scoreTextObjects[i-1].text = $"#{i} - {leaderBoard.GetScore(i).ToString()} coins";
        }
    }
    
    public void saveToJson(string path)
    {
        string json = JsonUtility.ToJson(leaderBoard);
        if (!Directory.Exists(Application.persistentDataPath))
            Directory.CreateDirectory(Application.persistentDataPath);
        File.WriteAllText(path, json);
    }

    public void loadFromJson(string path)
    {
        try
        {
            leaderBoard = JsonUtility.FromJson<LeaderBoard>(path);    
        }catch(Exception exception)
        {}
    }

    private void OnDestroy()
    {
        saveToJson(saveFilePath);
    }
}

