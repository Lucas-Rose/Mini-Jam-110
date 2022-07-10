using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunManager : MonoBehaviour
{
    public ParticleSystem ps;
    public GameObject parSys;
    SpriteRenderer sr;
    public GameObject rightBullet;
    public GameObject leftBullet;
    public GameObject[] bulletSpots;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
        swap();
    }

    public void shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(sr.flipX == false)
            {
                Instantiate(rightBullet, bulletSpots[1].transform);
            }
            if (sr.flipX == true)
            {
                Instantiate(leftBullet, bulletSpots[0].transform);
            }
            ps.Play();
        }
    }
    public void swap()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            parSys.transform.localPosition = new Vector2(-.5f, 0);
            parSys.transform.eulerAngles = new Vector3(0,-90,0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            parSys.transform.localPosition = new Vector2(.5f, 0);
            parSys.transform.eulerAngles = new Vector3(0, 90, 0);
        }
    }
}
