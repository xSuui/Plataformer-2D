using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    /*public string tagtoCompare = "Player";
    public GameObject uiEndgame;

    private bool gamePaused = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag(tagtoCompare))
        {
            CallEndGame();
            PauseGame();
        }
    }

    public void CallEndGame()
    {
        uiEndgame.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !gamePaused)
        {
            PauseGame();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && gamePaused)
        {
            ResumeGame();
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
        gamePaused = true;
    }

    private void ResumeGame()
    {
        Time.timeScale = 1;
        gamePaused = false;
    }*/

    // aula 4/5
    public string tagtoCompare = "Player";

    public GameObject uiEndgame;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag(tagtoCompare))
        {
            CallEndGame();
        }
    }

    public void CallEndGame()
    {
        uiEndgame.SetActive(true);
    }
}
