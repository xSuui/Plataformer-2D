using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
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
