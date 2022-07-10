using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour { 

    Rigidbody2D rb;
    public float speed;
    Animator anim;
    public Vector2 playerScale;
    public bool canMove;
    public float sprintSpeed = 1f;
    public SpriteRenderer sr;
    public SpriteRenderer Shadow;
    public bool shadow;
    public bool holding;
    Collider2D col;
    public int health;


    float hitCD = 3f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shadow)
        {
            transform.localPosition = new Vector2(0.1133333f, 0.06666667f);
        }
        speed = 5f;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprintSpeed = 2f;
        }
        else
        {
            sprintSpeed = 1f;
        }
        if(Input.GetAxisRaw("Horizontal") != 0 && Input.GetAxisRaw("Vertical") != 0)
        {
            speed = 3.5f;
        }
        movePlayer();
        flip();
        hitCD -= Time.deltaTime;
    }

    public void movePlayer()
    {
        if (canMove == true)
        {
            Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal") * speed * sprintSpeed, Input.GetAxisRaw("Vertical") * speed * sprintSpeed);
            rb.velocity = input;
        }
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            anim.SetBool("walking", true);
        }
        else
        {
            anim.SetBool("walking", false);
        }
    }
    public void flip()
    {
        if (canMove == true)
        {
            if(Input.GetAxisRaw("Horizontal") < 0)
            {
                sr.flipX = true;
                Shadow.flipX = true;
            }
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                sr.flipX = false;
                Shadow.flipX = false;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (hitCD < 0)
        {
            if (collision.gameObject.tag == "enemy")
            {
                health -= 1;
                anim.SetTrigger("hit");
                hitCD = 3F;
            }
        }
    }
}
