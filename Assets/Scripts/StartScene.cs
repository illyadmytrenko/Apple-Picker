using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    void Start()
    {
        if(!PlayerPrefs.HasKey("HighScore"))
            PlayerPrefs.SetInt("Difficulty", 1);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("Scene_0");
        else if (Input.GetKeyDown(KeyCode.F1))
            SceneManager.LoadScene("Scene_3");
    }
}
