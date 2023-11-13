using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CallOut : MonoBehaviour
{
    public AudioSource sound;
    public GameObject callOut;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // am thanh khi co canh sat
            sound.Play();
            callOut.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
