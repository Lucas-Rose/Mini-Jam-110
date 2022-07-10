using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour
{

    public bool lazy;
    // Start is called before the first frame 

    // Update is called once per frame
    void Update()
    {
        if (lazy)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                loadNext();
            }
        }
    }

    public void loadNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void nextDay()
    {
        SceneManager.LoadScene(2);
        PlayerPrefs.SetInt("day", PlayerPrefs.GetInt("day") + 1);
    }
    public void loadMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void loadFail()
    {
        SceneManager.LoadScene(4);
    }
    public void retry()
    {
        SceneManager.LoadScene(2);
        PlayerPrefs.SetInt("day", 1);
    }
}
