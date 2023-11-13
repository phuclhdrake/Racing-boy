using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsBack : MonoBehaviour
{
    private string menuToLoad;

    public void BackToMenu(string menuToLoadName)
    {
        menuToLoad = menuToLoadName;
        SceneManager.LoadScene(menuToLoad);
    }
}
