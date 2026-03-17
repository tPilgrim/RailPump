using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Transform Player;
    private Text ScoreText;

    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
        ScoreText = GetComponent<Text>();
    }

    void Update()
    {
        ScoreText.text = (Player.position.x * 10).ToString("0");

        if (PlayerPrefs.GetInt("Score") < Mathf.RoundToInt(Player.position.x) * 10)
        {
            PlayerPrefs.SetInt("Score", Mathf.RoundToInt(Player.position.x) * 10);
        }
    }
}
