using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameOverStart : MonoBehaviour
{
    public GameObject GameOverCanvas;
    void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
}
