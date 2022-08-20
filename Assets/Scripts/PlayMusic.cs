using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMusic : MonoBehaviour
{
    [Header("Set in Inspector")]
    public AudioSource musicOnPlay;
    [Header("Tag")]
    [SerializeField] private string CreatedTag;

    void Start()
    {
        GameObject obj = GameObject.FindWithTag(this.CreatedTag);
        if (obj != null)
            Destroy(this.gameObject);
        else
        {
            musicOnPlay.Play();
            this.gameObject.tag = this.CreatedTag;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Update()
    {
            if (!musicOnPlay.isPlaying)
            {
                musicOnPlay.Stop();
                musicOnPlay.Play();
            }

        if (SceneManager.GetActiveScene().name == "Scene_1")
            musicOnPlay.mute = true;
        if (SceneManager.GetActiveScene().name != "Scene_1")
            musicOnPlay.mute = false;
    }

}
