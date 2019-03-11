using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private bool isDead = false;
    private Rigidbody2D rb2d;

    public float jumpSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void doJump()
    {
        if (isDead == false)
        {
            Vector2 moveVertical = new Vector2(0.0f, 1.0f);
            rb2d.AddForce(moveVertical * jumpSpeed);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Princess"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
