using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
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
