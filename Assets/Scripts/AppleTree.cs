using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject applePrefab;
    public float leftAndRightEdge = 10f;
    // Depend on Difficult"
    private float speed;
    private float changeToChangeDirections;
    private float secondsBetweenAppleDrops;

    void Awake()
    {
        if (PlayerPrefs.GetInt("Difficulty") == 1)
        {
            speed = 10f;
            changeToChangeDirections = 0.02f;
            secondsBetweenAppleDrops = 1f;
        }
        if (PlayerPrefs.GetInt("Difficulty") == 2)
        {
            speed = 20f;
            changeToChangeDirections = 0.03f;
            secondsBetweenAppleDrops = 0.75f;
        }
        if (PlayerPrefs.GetInt("Difficulty") == 3)
        {
            speed = 30f;
            changeToChangeDirections = 0.04f;
            secondsBetweenAppleDrops = 0.5f;
        }
    }

    void Start()
    {
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x > leftAndRightEdge)
            speed = -Mathf.Abs(speed);
        else if (pos.x < -leftAndRightEdge)
            speed = Mathf.Abs(speed);
    }

    void FixedUpdate()
    {
        if (Random.value < changeToChangeDirections)
            speed *= -1;
    }
}
