using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static MainMenu instance;
    private string trackToLoad;
    public string trackName;
    public GameObject trackSelect;

    private string credits;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        LapTime.minCount = 0;
        LapTime.secCount = 0;
        LapTime.miliCount = 0;
    }

    public void LevelSelect(string trackToload)
    {
        trackToLoad = trackToload;
        SceneManager.LoadScene(trackToLoad);
    }

    public void LevelSelectName(string trackname)
    {
        trackName = trackname;
    }

    public void OpenCredits(string creditsName) 
    {
        credits = creditsName;
        SceneManager.LoadScene(credits);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }

    public void OpenTrackSelect()
    {
        trackSelect.SetActive(true);
        trackSelect.transform.DOScale(1, 0.5f).SetEase(Ease.InOutQuint).SetUpdate(true);
    }
    public void CloseTrackSelect()
    {
        trackSelect.transform.DOScale(0, 0.5f).SetEase(Ease.InOutQuint).OnComplete(() =>
        {
            trackSelect.SetActive(false);
        });
    }
}
