using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
        Destroy(GameObject.FindGameObjectWithTag("Music"));
    }
}
