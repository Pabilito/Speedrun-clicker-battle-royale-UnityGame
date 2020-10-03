using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuHandler : MonoBehaviour
{
    public Sprite On;
    public Sprite Off;
    public Button SoundButton;

    private void Start()
    {
        if (!SoundManager.soundOn)
        {
            SoundButton.GetComponent<Image>().sprite = Off;
        }
    }

    public void OnSound()
    {
        if (SoundManager.soundOn)
        {
            SoundButton.GetComponent<Image>().sprite = Off;
        }
        else
        {
            SoundButton.GetComponent<Image>().sprite = On;
        }
        SoundManager.instance.muteOrUnmute();
    }

    public void GoToCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void GoToDuel()
    {
        SceneManager.LoadScene("DuelScene");
    }

    public void GoToDuel10()
    {
        SceneManager.LoadScene("DuelScene10");
    }

    public void GoTo4Players10()
    {
        SceneManager.LoadScene("FourTo10");
    }

    public void GoTo4Players50()
    {
        SceneManager.LoadScene("FourTo100");
    }

}
