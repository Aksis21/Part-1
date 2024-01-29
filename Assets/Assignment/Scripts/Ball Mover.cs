using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMover : MonoBehaviour
{
    public float force = 15f;
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddRelativeForce(rigidbody.position * force * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {

    }


}
