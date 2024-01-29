using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMover : MonoBehaviour
{
    Vector2 direction = new Vector2(0, 10);
    public float force = 10000f;
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddRelativeForce(direction * force * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
