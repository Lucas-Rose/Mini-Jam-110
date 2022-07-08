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
    // Start is called before the first frame update
    void Start()
    {
        SetNewDestination();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, marker, speed * Time.deltaTime);
      //  if (Vector2.Distance)
    }
    void SetNewDestination()
    {
        marker = new Vector2(Random.Range( -maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
    }
}
