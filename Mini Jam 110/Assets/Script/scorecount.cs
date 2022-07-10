using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class scorecount : MonoBehaviour
{
    public int scoreValue = 0;
    public TMP_Text score;
    public bool nonZero;
    public String display;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<TMP_Text> ();
        if (nonZero)
        {
            scoreValue = PlayerPrefs.GetInt("day");
        }
    }

    // Update is called once per frame
    void Update()
    {
        score.text = display + scoreValue;
    }

    public void increase(int val)
    {
        scoreValue += val; 
    }
    public void decrease(int val)
    {
        scoreValue -= val;
    }
}
