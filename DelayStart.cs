using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayStart : MonoBehaviour
{
    public GameObject startAnim;
    public AudioSource goAudio;

    void Start()
    {
        StartCoroutine(StartGame());
    }

    private IEnumerator StartGame()
    {
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 4f;
        goAudio.Play();
        while (Time.realtimeSinceStartup < pauseTime)
            yield return 0;
        startAnim.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
