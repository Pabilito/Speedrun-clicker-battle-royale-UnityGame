using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClicksCounter : MonoBehaviour
{
    int clicks1 = 0;
    int clicks2 = 0;

    public int clickToWin;
    bool countdown = true;

    public Text clicks1Txt;
    public Text clicks2Txt;

    public Text Win1;
    public Text Win2;

    public GameObject ScriptHandler;

    private void Start()
    {
        ScriptHandler.GetComponent<PauseHandler>().EnableAllButtons(false);
        Win1.GetComponent<Text>().text = "First to " + clickToWin.ToString();
        Win2.GetComponent<Text>().text = "First to " + clickToWin.ToString();
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        clicks1Txt.GetComponent<Text>().text = "3";
        clicks2Txt.GetComponent<Text>().text = "3";
        yield return new WaitForSeconds(1.0f);
        clicks1Txt.GetComponent<Text>().text = "2";
        clicks2Txt.GetComponent<Text>().text = "2";
        yield return new WaitForSeconds(1.0f);
        clicks1Txt.GetComponent<Text>().text = "1";
        clicks2Txt.GetComponent<Text>().text = "1";
        yield return new WaitForSeconds(1.0f);
        clicks1Txt.GetComponent<Text>().text = "GO";
        clicks2Txt.GetComponent<Text>().text = "GO";
        countdown = false;
        ScriptHandler.GetComponent<PauseHandler>().EnableAllButtons(true);
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
            }
        }
    }
}
