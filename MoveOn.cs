using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveOn : MonoBehaviour
{
    // load screen
    public int moveOnwards;
    public string Scene;

    void Start()
    {
        StartCoroutine(SceneChange());
    }

    IEnumerator SceneChange()
    {
        yield return new WaitForSeconds(moveOnwards);
        if (Scene == "")
        {
            if (MainMenu.Instance.trackName != null)
            {
                SceneManager.LoadScene(MainMenu.Instance.trackName);
            }
        }
        else
        {
            SceneManager.LoadScene(Scene);
        }
    }
}
