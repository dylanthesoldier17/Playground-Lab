using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class CoinDisplay : MonoBehaviour
{
    public TMP_Text textDisplay;
    private int coinCount = 0;

    public void incrementScore(int incrementAmount)
    {
        coinCount += incrementAmount;
    }
    
    public void updateText()
    {
        textDisplay.text = coinCount.ToString();
    }

    public int getCoins()
    {
        return coinCount;
    }
}
