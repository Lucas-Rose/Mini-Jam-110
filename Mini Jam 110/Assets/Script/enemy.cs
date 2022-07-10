using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject Seth;
    SpriteRenderer sr;
    public SpriteRenderer shadow;
    Rigidbody2D rb;
    Collider2D col;
    Animator anim;

    public int health;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = Vector2.Lerp(transform.position, Seth.transform.position, 0.5f * Time.deltaTime);
        flip();

    }
    public void flip()
    {
        if(Seth.transform.position.x < transform.position.x)
        {
            sr.flipX = true;
            shadow.flipX = true;
            return;
        }
        sr.flipX = false;
        shadow.flipX = false;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "bullet")
        {
            anim.SetTrigger("hit");
            health -= 1;
        }
    }
}
