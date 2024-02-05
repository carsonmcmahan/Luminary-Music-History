using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPress : MonoBehaviour
{
    public GameObject[] TestOnOff;
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

    public void SendDebugLog(int element)
    {
        Debug.Log("button was clicked");
        //TestOnOff.SetActive(!TestOnOff.activeSelf);
        TestOnOff[element].SetActive(!TestOnOff[element].activeSelf);
    }
}
