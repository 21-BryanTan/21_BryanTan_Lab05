using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{

    private float scoreValue;

    public float totalCoins;

    public float timeLeft;

    public int timeRemaining;

    public Text TimerText;

    private float TimerValue;

    // Start is called before the first frame update
    void Start()
    {
        TimerText.text = "Timer: " + timeRemaining.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        timeRemaining = Mathf.FloorToInt(timeLeft%60);

        TimerText.text = "Timer: " + timeRemaining.ToString();

        if(scoreValue == totalCoins)
        {
            if(timeLeft <= TimerValue)
            {
                SceneManager.LoadScene("GameWinScene");
            }
        }
        else if(timeLeft <= 0)
        {
            SceneManager.LoadScene("GameLoseScene");
        }
    }
}
