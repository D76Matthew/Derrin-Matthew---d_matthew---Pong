using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int scoreleft;
    public int scoreright;
    public int maxScore;
    public BallController ball;

    public void AddScoreRight(int increment)
    {
        scoreright += increment;
        ball.ResetBall();

        if (scoreright >= maxScore)
        {
            GameOver();
        }
    }

    public void AddScoreLeft(int increment)
    {
        scoreleft += increment;
        ball.ResetBall();

        if (scoreleft >= maxScore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Main Menu");
    }

}