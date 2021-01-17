using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    private int currentSceneIndex;
    private Text myIF;

    public void SceneChanger()
    {

        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 2)                    //Başa sarma taktiğim. Videoda yeni bir method oluşturup son ekrandaki
        {                                             //butona o methodu tanımlıyordu.
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }

    public void FirstButton()
    {
        myIF = GameObject.Find("InputField").GetComponentInChildren<Text>();
        PlayerPrefs.SetInt("number", Convert.ToInt32(myIF));
        SceneManager.LoadScene(1);
    }


}