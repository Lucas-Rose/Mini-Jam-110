using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayManager : MonoBehaviour
{
    public GameObject goat;
    public GameObject sheep;
    public GameObject cow;
    public Transform[] spawns;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(goat);
        for (int i = 0; i < 3; i++)
        {
            Instantiate(cow, spawns[0]);
            Instantiate(sheep, spawns[1]);
            Instantiate(sheep, spawns[2]);
            Instantiate(cow, spawns[3]);
            Instantiate(cow, spawns[4]);
        }
    }
}
