using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public GameObject endGameBg;
    public GameObject pauseButton;
    public Text gameOverTxt;
    public GameObject coin;

    public void Update()
    {
        if(Game.lose) pauseButton.SetActive(false);
    }

    public void Click()
    {
        Game.pause = !Game.pause;
        endGameBg.SetActive(Game.pause);
        coin.SetActive(false);
        gameOverTxt.text = "Pause";
        pauseButton.SetActive(!Game.pause);
        Time.timeScale = 0f;
    }
    
    public void Play()
    {
        Game.pause = !Game.pause;
        gameOverTxt.text = "Game over";
        coin.SetActive(true);
        endGameBg.SetActive(Game.pause);
        pauseButton.SetActive(!Game.pause);
        Time.timeScale = 1f;
    }
}