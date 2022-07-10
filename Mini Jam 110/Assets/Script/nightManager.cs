using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nightManager : MonoBehaviour
{
    public GameObject enemy;
    public scorecount playerHealth;
    public scorecount devilCount;
    public Animator cover;
    // Start is called before the first frame update
    void Start()
    {
        devilCount.scoreValue = (PlayerPrefs.GetInt("day") * 2) + 5;
        for(int i = 0; i < 5 + PlayerPrefs.GetInt("day")*2; i++){
            GameObject spawn = new GameObject();
            spawn.transform.position = new Vector3(Random.Range(-8f, 8f), Random.Range(-9f, 3f), 0f);
            Instantiate(enemy, spawn.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth.scoreValue <= 0)
        {
            cover.SetTrigger("Fin");
        }
        if(devilCount.scoreValue <= 0)
        {
            cover.SetTrigger("next");
        }
    }
}
