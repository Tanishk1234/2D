using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InfiniteScoreCalculator : MonoBehaviour
{
    public Text ScoreText;
    public float ScoreAmount;
    public float ScoreIncerasePerSecond;
    void Start()
    {
        ScoreAmount = 0;
        ScoreIncerasePerSecond = 1f;
    }
    void Update()
    {
        ScoreText.text = (int)ScoreAmount + " Score";
        ScoreAmount += ScoreIncerasePerSecond * Time.deltaTime;
    }
}
