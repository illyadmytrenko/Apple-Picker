using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Difficulty : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("Scene_0");
        else if (Input.GetKeyDown(KeyCode.F1))
            PlayerPrefs.SetInt("Difficulty", 1);
        else if (Input.GetKeyDown(KeyCode.F2))
            PlayerPrefs.SetInt("Difficulty", 2);
        else if (Input.GetKeyDown(KeyCode.F3))
            PlayerPrefs.SetInt("Difficulty", 3);
    }
}
