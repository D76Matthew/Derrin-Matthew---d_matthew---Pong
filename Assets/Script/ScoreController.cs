using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text ScoreLeft;
    public Text ScoreRight;

    public ScoreManager manager;

    private void Update()
    {
        ScoreLeft.text = manager.scoreleft.ToString();
        ScoreRight.text = manager.scoreright.ToString();
    }
}
