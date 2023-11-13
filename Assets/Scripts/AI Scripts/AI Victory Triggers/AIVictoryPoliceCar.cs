using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AIVictoryPoliceCar : MonoBehaviour
{
    public int currentLap;
    public int maxLap;

    void Start()
    {
        currentLap = maxLap;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "AIPolice")
        {
            currentLap--;
            if (currentLap <= 0)
            {
                SceneManager.LoadScene("AIVictoryScreen");
            }
        }
    }
}
