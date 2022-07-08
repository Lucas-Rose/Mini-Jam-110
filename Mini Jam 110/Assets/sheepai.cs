using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheepai : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float range;
    [SerializeField]
    float maxDistance;
    Vector2 marker;
    public Vector2 spawn;

    SpriteRenderer sr;
    public SpriteRenderer shadow;
    // Start is called before the first frame update
    void Start()
    {
        SetNewDestination();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, marker, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, marker) < range)
        {
            SetNewDestination();
        }
        flip();
    }
    void SetNewDestination()
    {
        marker = new Vector2(spawn.x + Random.Range( -maxDistance, maxDistance), spawn.y + Random.Range(-maxDistance, maxDistance));
    }

    void flip()
    {
        if(transform.position.x < marker.x)
        {
            sr.flipX = false;
            shadow.flipX = false;
            return;
        }
        sr.flipX = true;
        shadow.flipX = true;

    }
}
