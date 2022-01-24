using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

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
}
