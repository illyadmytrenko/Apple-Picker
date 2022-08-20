using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    static public int score = 0;
    static public bool isUpgrade;
    
    void Awake()
    {
        if (PlayerPrefs.HasKey("HighScore"))
            score = PlayerPrefs.GetInt("HighScore");

        PlayerPrefs.SetInt("HighScore", score);
        isUpgrade = false;
    }

    void Update()
    {
        TextMeshProUGUI gt = this.GetComponent<TextMeshProUGUI>();
        gt.text = "High Score: " + score;

        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            isUpgrade = true;
        }   
    }
}
