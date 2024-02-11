using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Android.Gradle;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPress : MonoBehaviour
{
    public GameObject[] TestOnOff;
    public Animator panelAnimator;

    //public GameObject TestOnOff;
    void Start()
    {
        //TestOnOff.SetActive(false);
        TestOnOff[0].SetActive(false);
        TestOnOff[1].SetActive(false);
        TestOnOff[2].SetActive(false);
        TestOnOff[3].SetActive(false);
        TestOnOff[4].SetActive(false);
    }

    IEnumerator Waiter(float seconds, int element)
    {
        yield return new WaitForSeconds(seconds);

        TestOnOff[element].SetActive(!TestOnOff[element].activeSelf);
    }

    public void SendDebugLog(int element)
    {
        Debug.Log("button was clicked");
        //TestOnOff.SetActive(!TestOnOff.activeSelf);
        TestOnOff[element].SetActive(!TestOnOff[element].activeSelf);

        panelAnimator.SetTrigger("zoomIn");
    }

    public void BackButton(int element)
    {
        panelAnimator.SetTrigger("zoomOut");

        StartCoroutine(Waiter(1, element));
    }
}
