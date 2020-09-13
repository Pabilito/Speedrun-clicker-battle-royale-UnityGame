using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClicksCounter : MonoBehaviour
{
    int clicks1 = 0;
    int clicks2 = 0;

    public Text clicks1Txt;
    public Text clicks2Txt;

    public void registerClick1()
    {
        if (!GloabalVariables.instance.paused)
        {
            clicks1++;
            clicks1Txt.GetComponent<Text>().text = clicks1.ToString();
        }
    }

    public void registerClick2()
    {
        if (!GloabalVariables.instance.paused)
        {
            clicks2++;
            clicks2Txt.GetComponent<Text>().text = clicks2.ToString();
        }
    }
}
