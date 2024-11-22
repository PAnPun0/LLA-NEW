using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    int score = 3;

    public GameObject imageFor3Points;
    public GameObject imageFor2Points;
    public GameObject imageFor1Points;

    public GameObject Good;


    public void minus()
    {
        score = score - 1;
    }
    public void meter(){

        if(score == 3)
        {
            imageFor3Points.SetActive(true);
        }
        else if(score == 2)
        {
            imageFor3Points.SetActive(false);
            imageFor2Points.SetActive(true);
        }
        else if( score == 1)
        {
            imageFor2Points.SetActive(false);
            imageFor1Points.SetActive(true);
        }
    }

    public void Gameover()
    {
        Good.SetActive(true);
    }
    
    
}