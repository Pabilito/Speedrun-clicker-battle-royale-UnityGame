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
}
