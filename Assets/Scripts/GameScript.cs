using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    private int Guess_num,min,a,max;
    System.Random rand = new System.Random();
    private int rand_num;
    void Start()
    {
        rand_num = rand.Next(1,1000);
        Guess_num = rand_num;
        a = 0;
        GameObject.Find("txtGuess").GetComponent<Text>().text = rand_num.ToString();
        min = 1;
        max = 1000;

    }
    public void PressUp()
    {
        min = Guess_num;
        Guess_num = (Guess_num + max) / 2;
        
    }
    public void PressDown()
    {
        Guess_num = (Guess_num - min) / 2;
        max = Guess_num;

    }
    
}
