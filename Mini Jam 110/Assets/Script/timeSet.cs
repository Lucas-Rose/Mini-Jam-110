using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timeSet : MonoBehaviour
{
    public TMP_Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = "Day " + PlayerPrefs.GetInt("day").ToString();
    }
}
