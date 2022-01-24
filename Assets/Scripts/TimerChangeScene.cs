using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerChangeScene : MonoBehaviour
{
    public int timeInSecondsToSwitch;
    public string sceneName;
    private int timeElapsedInSeconds = 0;
    private void Awake()
    {
        InvokeRepeating(nameof(CheckTimer), 0f, 1f);
    }

    public void CheckTimer()
    {
        timeElapsedInSeconds++;
        if (timeElapsedInSeconds >= timeInSecondsToSwitch)
        {
            SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
        }
    }
}
