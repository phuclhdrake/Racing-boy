using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfwayTrigger : MonoBehaviour
{
    public GameObject halfwayTrig;
    public GameObject lapCompleteTrig;
    public GameObject playerVictoryTrackTrigger;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            lapCompleteTrig.SetActive(true);
            halfwayTrig.SetActive(false);
            playerVictoryTrackTrigger.SetActive(true);
        }
    }
}
