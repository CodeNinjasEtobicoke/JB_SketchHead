using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Game Over UI Canvas Object")]
    public GameObject gameOverCanvas;
    [Header("Platform Object")]
    public GameObject platform;

    float pos = 0;

    void Start()
    {
        for (int i = 0; i < 1000; i++)
        {
            SpawnPlatforms();
        }

    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
    }

    void Update()
    {

    }

    void SpawnPlatforms()
    {
        Instantiate(platform, new Vector3(Random.value * 10 - 5f, pos, 0.5f), Quaternion.identity);
        pos += 2.5f;
    }
}
