using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get => instance; }


    public int currentLives = 3;
    public float respawnTime = 2f;

    // pause game
    public GameObject pauseScreen;
    public string levelLoad;
    public bool isPause;

    public AudioSource engine;
    public AudioSource car1, car2, car3, heli;

    private bool isSpacePressed = false;

    private void Awake()
    {
        instance = this;
        StartCoroutine(PauseStartTime());
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isSpacePressed == true)
        {
            pauseUnpause();
        }
    }
    private IEnumerator PauseStartTime()
    {
        yield return new WaitForSeconds(1f);
        isSpacePressed = true;
    }

    public void pauseUnpause()
    {
        isPause = !isPause;
        if (isPause)
        {
            pauseScreen.SetActive(true);
            pauseScreen.transform.DOScale(1, 0.5f).SetEase(Ease.OutElastic).SetUpdate(true);
            Time.timeScale = 0;
            engine.Stop();
            if(car1 != null && car1 != null && car1 != null && heli != null)
            {
                car1.Stop();
                car2.Stop();
                car3.Stop();
                heli.Stop();
            }
        }
        else
        {
            pauseScreen.transform.DOScale(0, 0.5f).SetEase(Ease.InOutElastic).OnComplete(() =>
            {
                pauseScreen.SetActive(false);
            });
            Time.timeScale = 1;
            engine.Play();
            if (car1 != null && car1 != null && car1 != null && heli != null)
            {
                car1.Play();
                car2.Play();
                car3.Play();
                heli.Play();
            }
        }
    }

    public void ExitRace()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(levelLoad);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit game");
    }
    public void KillPlayer()
    {
        currentLives--;
        if (currentLives > 0)
        {
            StartCoroutine(RespawnCo());
        }
    }

    public IEnumerator RespawnCo()
    {
        yield return new WaitForSeconds(respawnTime);
        HealthManager.Instance.Respawn();
    }

    //BlueMonster
    public void KillBlueMonster()
    {
        currentLives--;
        if (currentLives > 0)
        {
            StartCoroutine(RespawnBlueMonster());
        }
    }
    public IEnumerator RespawnBlueMonster()
    {
        yield return new WaitForSeconds(respawnTime);
        BlueMonsterHealthManager.Instance.Respawn();
    }

    //BlueBuggy
    public void KillBlueBuggy()
    {
        currentLives--;
        if (currentLives > 0)
        {
            StartCoroutine(RespawnBlueBuggy());
        }
    }
    public IEnumerator RespawnBlueBuggy()
    {
        yield return new WaitForSeconds(respawnTime);
        BlueBuggyHealthManager.Instance.Respawn();
    }

    //Tractor
    public void KillTractor()
    {
        currentLives--;
        if (currentLives > 0)
        {
            StartCoroutine(RespawnTractor());
        }
    }
    public IEnumerator RespawnTractor()
    {
        yield return new WaitForSeconds(respawnTime);
        TractorHealthManager.Instance.Respawn();
    }

    public void KillTaxi()
    {
        currentLives--;
        if (currentLives > 0)
        {
            StartCoroutine(RespawnTaxi());
        }
    }
    public IEnumerator RespawnTaxi()
    {
        yield return new WaitForSeconds(respawnTime);
        TaxiHealthManager.Instance.Respawn();
    }

    //PurpleBuggy
    public void KillPurpleBuggy()
    {
        currentLives--;
        if (currentLives > 0)
        {
            StartCoroutine(RespawnPurpleBuggy());
        }
    }
    public IEnumerator RespawnPurpleBuggy()
    {
        yield return new WaitForSeconds(respawnTime);
        PurpleBuggyHealthManager.Instance.Respawn();
    }

    //GoKart
    public void KillGoKart()
    {
        currentLives--;
        if (currentLives > 0)
        {
            StartCoroutine(RespawnGoKart());
        }
    }
    public IEnumerator RespawnGoKart()
    {
        yield return new WaitForSeconds(respawnTime);
        GoKartHealthManager.Instance.Respawn();
    }

    //Police
    public void KillPolice()
    {
        currentLives--;
        if (currentLives > 0)
        {
            StartCoroutine(RespawnPolice());
        }
    }
    public IEnumerator RespawnPolice()
    {
        yield return new WaitForSeconds(respawnTime);
        PoliceHealthManager.Instance.Respawn();
    }

    //Sport
    public void KillSport()
    {
        currentLives--;
        if (currentLives > 0)
        {
            StartCoroutine(RespawnSport());
        }
    }
    public IEnumerator RespawnSport()
    {
        yield return new WaitForSeconds(respawnTime);
        SportHealthManager.Instance.Respawn();
    }

    //GreenMonster
    public void KillGreenMonster()
    {
        currentLives--;
        if (currentLives > 0)
        {
            StartCoroutine(RespawnGreenMonster());
        }
    }
    public IEnumerator RespawnGreenMonster()
    {
        yield return new WaitForSeconds(respawnTime);
        GreenMonsterHealthManager.Instance.Respawn();
    }

    //Racing
    public void KillRacing()
    {
        currentLives--;
        if (currentLives > 0)
        {
            StartCoroutine(RespawnRacing());
        }
    }
    public IEnumerator RespawnRacing()
    {
        yield return new WaitForSeconds(respawnTime);
        RacingHealthManager.Instance.Respawn();
    }


}
