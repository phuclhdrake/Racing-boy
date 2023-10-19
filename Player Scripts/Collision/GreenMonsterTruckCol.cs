using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenMonsterTruckCol : MonoBehaviour
{
    public AudioSource impact;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "AIGreenMonsterTruck")
        {
            impact.pitch = Random.Range(0.8f, 1.2f);
            impact.Play();
        }
    }
}
