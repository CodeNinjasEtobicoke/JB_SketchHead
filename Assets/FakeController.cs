using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FakeController : MonoBehaviour
{
    [Header("Game Over UI Canvas Object")]
    public GameObject gameOverCanvas;
    [Header("Platform Object")]
    public GameObject platform;

    float pos = 0;

    void Start()
    {
        for (int i = 0; i < 100; i++)
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
        Instantiate(platform, new Vector3(Random.value * 10 - 5f, pos, -6f), Quaternion.identity);
        pos += 2.5f;
    }
}
