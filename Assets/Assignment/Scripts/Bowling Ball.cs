using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    Vector2 slide;
    public Rigidbody2D rigidbody;
    public float rotateSpeed = 20f;
    public float force = 150f;
    public GameObject ballPrefab;
    public Transform ballSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float aim = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, aim * rotateSpeed * Time.deltaTime);
        slide.x = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ballPrefab, ballSpawn.position, ballSpawn.rotation);
        }
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(slide * force * Time.deltaTime);
    }
}
