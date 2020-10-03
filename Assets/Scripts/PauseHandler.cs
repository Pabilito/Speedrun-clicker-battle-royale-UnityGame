using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseHandler : MonoBehaviour
{
    public Button menu;
    public Button restart;
    public Button pause;

    private void Start()
    {
        GloabalVariables.instance.paused = false;
        EnableButtons(false);
    }

    public void Pause()
    {
        GloabalVariables.instance.paused = !GloabalVariables.instance.paused;
        EnableButtons(GloabalVariables.instance.paused);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }

    void EnableButtons(bool enable)
    {
        menu.GetComponent<Image>().enabled = enable;
        restart.GetComponent<Image>().enabled = enable;
    }

    public void EnableAllButtons(bool enable)
    {
        menu.GetComponent<Image>().enabled = enable;
        restart.GetComponent<Image>().enabled = enable;
        pause.GetComponent<Image>().enabled = enable;
    } 
}
