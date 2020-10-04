using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClicksCounterFour : MonoBehaviour
{
    int clicks1 = 0;
    int clicks2 = 0;
    int clicks3 = 0;
    int clicks4 = 0;


    public int clickToWin;
    bool countdown = true;

    public Text clicks1Txt;
    public Text clicks2Txt;
    public Text clicks3Txt;
    public Text clicks4Txt;

    public Text Win1;
    public Text Win2;
    public Text Win3;
    public Text Win4;

    public GameObject ScriptHandler;

    private void Start()
    {
        ScriptHandler.GetComponent<PauseHandler>().EnableAllButtons(false);
        Win1.GetComponent<Text>().text = "First to " + clickToWin.ToString();
        Win2.GetComponent<Text>().text = "First to " + clickToWin.ToString();
        Win3.GetComponent<Text>().text = "First to " + clickToWin.ToString();
        Win4.GetComponent<Text>().text = "First to " + clickToWin.ToString();
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        SoundManager.instance.GetComponent<AudioSource>().pitch = 1;
        SoundManager.instance.GetComponent<AudioSource>().Play();
        clicks1Txt.GetComponent<Text>().text = "3";
        clicks2Txt.GetComponent<Text>().text = "3";
        clicks3Txt.GetComponent<Text>().text = "3";
        clicks4Txt.GetComponent<Text>().text = "3";
        yield return new WaitForSeconds(1.0f);
        SoundManager.instance.GetComponent<AudioSource>().Play();
        clicks1Txt.GetComponent<Text>().text = "2";
        clicks2Txt.GetComponent<Text>().text = "2";
        clicks3Txt.GetComponent<Text>().text = "2";
        clicks4Txt.GetComponent<Text>().text = "2";
        yield return new WaitForSeconds(1.0f);
        SoundManager.instance.GetComponent<AudioSource>().Play();
        clicks1Txt.GetComponent<Text>().text = "1";
        clicks2Txt.GetComponent<Text>().text = "1";
        clicks3Txt.GetComponent<Text>().text = "1";
        clicks4Txt.GetComponent<Text>().text = "1";
        yield return new WaitForSeconds(1.0f);
        SoundManager.instance.GetComponent<AudioSource>().pitch = 0.5f;
        SoundManager.instance.GetComponent<AudioSource>().Play();
        clicks1Txt.GetComponent<Text>().text = "GO";
        clicks2Txt.GetComponent<Text>().text = "GO";
        clicks3Txt.GetComponent<Text>().text = "GO";
        clicks4Txt.GetComponent<Text>().text = "GO";
        countdown = false;
        ScriptHandler.GetComponent<PauseHandler>().EnableAllButtons(true);
        ScriptHandler.GetComponent<PauseHandler>().EnableButtons(false);
    }

    public void registerClick1()
    {
        if (!GloabalVariables.instance.paused && !countdown)
        {
            clicks1++;
            clicks1Txt.GetComponent<Text>().text = clicks1.ToString();
            if (clicks1 == clickToWin)
            {
                ScriptHandler.GetComponent<PauseHandler>().Pause();
                Win1.GetComponent<Text>().text = "Winner";
                Win2.GetComponent<Text>().text = "Loser";
                Win3.GetComponent<Text>().text = "Loser";
                Win4.GetComponent<Text>().text = "Loser";
            }
        }
    }

    public void registerClick2()
    {
        if (!GloabalVariables.instance.paused && !countdown)
        {
            clicks2++;
            clicks2Txt.GetComponent<Text>().text = clicks2.ToString();
            if (clicks2 == clickToWin)
            {
                ScriptHandler.GetComponent<PauseHandler>().Pause();
                Win1.GetComponent<Text>().text = "Loser";
                Win2.GetComponent<Text>().text = "Winner";
                Win3.GetComponent<Text>().text = "Loser";
                Win4.GetComponent<Text>().text = "Loser";
            }
        }
    }

    public void registerClick3()
    {
        if (!GloabalVariables.instance.paused && !countdown)
        {
            clicks3++;
            clicks3Txt.GetComponent<Text>().text = clicks3.ToString();
            if (clicks3 == clickToWin)
            {
                ScriptHandler.GetComponent<PauseHandler>().Pause();
                Win1.GetComponent<Text>().text = "Loser";
                Win2.GetComponent<Text>().text = "Loser";
                Win3.GetComponent<Text>().text = "Winner";
                Win4.GetComponent<Text>().text = "Loser";
            }
        }
    }

    public void registerClick4()
    {
        if (!GloabalVariables.instance.paused && !countdown)
        {
            clicks4++;
            clicks4Txt.GetComponent<Text>().text = clicks4.ToString();
            if (clicks4 == clickToWin)
            {
                ScriptHandler.GetComponent<PauseHandler>().Pause();
                Win1.GetComponent<Text>().text = "Loser";
                Win2.GetComponent<Text>().text = "Loser";
                Win3.GetComponent<Text>().text = "Loser";
                Win4.GetComponent<Text>().text = "Winner";
            }
        }
    }
}
