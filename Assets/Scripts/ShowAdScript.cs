using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ShowAdScript : MonoBehaviour
{
    string gameId = "3849215";
    bool testMode = false;
    string adName = "video";

    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
        int num = Random.Range(0, 6);
        if (num==0) //every 6 games ad is dispalyed
        {
            StartCoroutine(WaitForAd());
        }
    }

    IEnumerator WaitForAd()
    {
        while (!Advertisement.IsReady(adName))
        {
            yield return new WaitForSeconds(1.0f);
        }
        Advertisement.Show(adName);
    }
}
