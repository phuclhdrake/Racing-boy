using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerVictoryTrigger : MonoBehaviour
{
    public int currentLap;
    public int maxLap;
    public GameObject playerVictoryTrigger;

    void Start()
    {
        currentLap = maxLap;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            currentLap--;
            if (currentLap <= 0)
            {
                SceneManager.LoadScene("PlayerVictoryScreen");
            }
            playerVictoryTrigger.SetActive(false);
        }
    }
}
