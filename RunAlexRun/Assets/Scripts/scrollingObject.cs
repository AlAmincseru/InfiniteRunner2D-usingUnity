using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingObject : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float rateOfIncreasingVelocity;
    private int frameCount;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(-1.5f, 0);
        rateOfIncreasingVelocity = 1.0f;
        frameCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        frameCount++;

        if(frameCount == 700)
        {
            frameCount = 0;
            rateOfIncreasingVelocity += 0.5f;
            rb2d.velocity = new Vector2(-1.5f * rateOfIncreasingVelocity, 0);
        }
    }
}
