using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class scorecount : MonoBehaviour
{
    public static int scoreValue = 0;
    public TMP_Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<TMP_Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "laud herded: " + scoreValue;
    }
}