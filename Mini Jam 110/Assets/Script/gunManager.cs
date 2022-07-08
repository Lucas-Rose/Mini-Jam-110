using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunManager : MonoBehaviour
{
    public ParticleSystem ps;
    public GameObject parSys;
    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
        swap();
    }

    public void shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
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
