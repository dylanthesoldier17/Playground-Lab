using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public string saveFileName;
    public string scoreFileName;

    private LeaderBoard leaderBoard;
    public Text[] scoreTextObjects;

    private void Awake()
    {
        int score = LoadScoreFromJsonFile();
        LoadLeaderboardFromJsonFile();
        AddScoreToLeaderBoard(score);
        UpdateScoreTextObjectsFromLeaderboard();
    }

    private int LoadScoreFromJsonFile()
    {
        try
        {
            string scoreSavePath = Application.persistentDataPath + "/" + scoreFileName;
            string json = File.ReadAllText(scoreSavePath);
            Score score = JsonUtility.FromJson<Score>(json);
            return score.value;
        }
        catch (Exception e)
        {}

        return 0;
    }

    private void LoadLeaderboardFromJsonFile()
    {
        try
        {
            string json = File.ReadAllText(Application.persistentDataPath + "/" + saveFileName);
            leaderBoard = JsonUtility.FromJson<LeaderBoard>(json);
        }
        catch (Exception e)
        {}

        if (leaderBoard == null)
            leaderBoard = new LeaderBoard();
    }

    public void AddScoreToLeaderBoard(int score)
    {
        leaderBoard.AddScore(score);
    }

    private void UpdateScoreTextObjectsFromLeaderboard()
    {
        for (int i = 0; i < 5; i++)
        {
            int leaderBoardPosition = i + 1;
            scoreTextObjects[i].text = $"#{i.ToString()} - {leaderBoard.GetScore(i).ToString()} coins";
        }
    }
    
    public void saveLeaderboardToJson(string path)
    {
        string json = JsonUtility.ToJson(leaderBoard);
        if (!Directory.Exists(Application.persistentDataPath))
            Directory.CreateDirectory(Application.persistentDataPath);
        File.WriteAllText(path, json);
    }

    private void OnDestroy()
    {
        saveLeaderboardToJson(Application.persistentDataPath + "/" + saveFileName);
    }
}

