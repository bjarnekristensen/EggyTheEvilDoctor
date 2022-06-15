using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void VolumeMute()
    {
        AudioListener.volume = 0.0f;
    }

    public void VolumeHalf()
    {
        AudioListener.volume = 0.25f;
    }

    public void VolumeFull()
    {
        AudioListener.volume = 1.0f;
    }
}
