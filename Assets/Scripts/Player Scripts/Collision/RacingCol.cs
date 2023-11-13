using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingCol : MonoBehaviour
{
    public AudioSource impact;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "AIRacing")
        {
            impact.pitch = Random.Range(0.8f, 1.2f);
            impact.Play();
        }
    }
}
