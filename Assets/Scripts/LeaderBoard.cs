using System;

[Serializable]
public class LeaderBoard
{
    //Put size of the leaderboard array to 6, so the last spot can be used to add and sort scores.
    public int[] scores;
    private int numberOfScoresToHold = 6;
    
    public LeaderBoard()
    {
        InstantiateLeaderBoard();
    }
    
    private void InstantiateLeaderBoard()
    {
        scores = new int[numberOfScoresToHold];
    }
    
    public int GetScore(int index)
    {
        return scores[index];
    }

    public void SetScore(int index, int score)
    {
        scores[index] = score;
    }

    public void AddScore(int score)
    {
        scores[scores.Length - 1] = score;
        Array.Sort(scores);
    }
}