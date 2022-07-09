using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grab : MonoBehaviour
{
    public Collider2D trigCol;
    public Collider2D hardCol;
    sheepai brain;
    public Movement sethMove;


    public GameObject seth;
    public GameObject capture;
    public GameObject pen;

    scorecount sc;
    public GameObject score;
    public int value;

    public Animator anim;
    public bool held;
    public bool saved;
    SpriteRenderer sr;
    public SpriteRenderer shadow;

    // Start is called before the first frame update
    private void Start()
    {
        brain = GetComponent<sheepai>();
        pen = GameObject.Find("pen");
        capture = GameObject.Find("capture");
        seth = GameObject.Find("Seth");
        sethMove = seth.GetComponent<Movement>();
        sr = GetComponent<SpriteRenderer>();
        score = GameObject.Find("Score");
        sc = score.GetComponent<scorecount>();
    }
    // Update is called once per 
    private void Update()
    {
        if (saved)
        {
            flip();
            if (Vector2.Distance(gameObject.transform.position, capture.transform.position) < 5)
            {
                held = false;
                sethMove.holding = false;
                Destroy(trigCol);
                Destroy(hardCol);
                anim.SetTrigger("Fade");
            }
            if (held)
            {
                transform.position = Vector3.Lerp(transform.position, seth.transform.position, Time.deltaTime);
            }
            else
            {
                transform.position = Vector3.Lerp(transform.position, pen.transform.position, Time.deltaTime);
            }
        }
    }
    void flip()
    {
        if(transform.position.x < seth.transform.position.x)
        {
            sr.flipX = false;
            shadow.flipX = false;
            return;
        }
        sr.flipX = true;
        shadow.flipX = true;
    }
    public void kill()
    {
        sc.increase(value);
        Destroy(this.gameObject);
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "seth" && sethMove.holding == false)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Destroy(brain);
                held = true;
                sethMove.holding = true;
                saved = true;
            }
        }
    }
}