using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    public float time;
    public TMP_Text timeLeft;
    public GameObject cover;
    Animator coverAnim;


    private void Start()
    {
        coverAnim = cover.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timeLeft.text = "Time: " + (int)time;
        if(time <= 0)
        {
            time = 0;
            coverAnim.SetTrigger("Fade");
        }
    }
}
