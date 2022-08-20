using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartScene : MonoBehaviour
{
    [Header("Set in Inspector")]
    public TextMeshProUGUI newHighScoreMessage;

    void Start()
    {
        if(!PlayerPrefs.HasKey("Difficulty"))
            PlayerPrefs.SetInt("Difficulty", 1);
        if (!PlayerPrefs.HasKey("HighScore"))
            PlayerPrefs.SetInt("HighScore", 0);

        if (SceneManager.GetActiveScene().name == "Scene_1")
        {
            this.GetComponent<AudioSource>().Play();
            if (HighScore.isUpgrade == true)
                newHighScoreMessage.text = "Your New High Score = " + HighScore.score;
            else
                newHighScoreMessage.text = "";
        }    

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("Scene_0");
        else if (Input.GetKeyDown(KeyCode.F1))
            SceneManager.LoadScene("Scene_3");
    }
}
