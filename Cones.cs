using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cones : MonoBehaviour
{
    public GameObject coneFallRef = null;
    public AudioSource coneSound = null;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!coneSound.isPlaying)
            {
                coneSound.pitch = UnityEngine.Random.Range(1, 1.2f);
                coneSound.Play();
                if (coneFallRef != null)
                {
                    GameObject coneFall = (GameObject)Instantiate(coneFallRef);
                    coneFall.transform.position = transform.position;
                    coneFall.transform.rotation = transform.rotation;
                    Destroy(gameObject);
                }
            }
        }
    }
}
