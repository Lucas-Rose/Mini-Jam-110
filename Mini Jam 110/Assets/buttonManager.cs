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
}
