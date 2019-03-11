using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    private bool isDead = false;
    private Rigidbody2D rb2d;

    public float jumpSpeed;

    public GameObject rightBullet;
    private Transform firepos;

    public float FireWaitReset,FireRate;
    private float FireWait;

    public Text scoreText;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        FireWait = FireWaitReset;
        score = 0;
        setScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        FireWait -= FireRate;
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

    public void Fire()
    {
        if (FireWait <= 0.0f)
        {
            FireWait = FireWaitReset;
            firepos = transform.Find("Fire_Position");
            Instantiate(rightBullet, firepos.position, Quaternion.identity);
        }
    }

    void setScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
