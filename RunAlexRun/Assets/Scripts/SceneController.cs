using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public GameObject gameObject1;
    public GameObject gameObject2;
    public GameObject gameObject3;
    public GameObject gameObject4;
    public GameObject gameObject5;
    public GameObject gameObject6;
    public GameObject gameObject7;
    public GameObject gameOverText;

    private int cnt = 0;

    private void Start()
    {
        gameObject3.SetActive(false);
        gameObject4.SetActive(false);
        gameObject5.SetActive(false);
        gameObject6.SetActive(false);
        gameObject7.SetActive(false);
        gameOverText.SetActive(false);
    }

    public void startGame()
    {
        gameObject1.GetComponent<scrollingObject>().enabled = true;
        gameObject1.GetComponent<repeatingBackground>().enabled = true;
        gameObject2.GetComponent<scrollingObject>().enabled = true;
        gameObject2.GetComponent<repeatingBackground>().enabled = true;

        GameObject.Find("StartButton").SetActive(false);

        gameObject3.SetActive(true);
        gameObject4.SetActive(true);
        gameObject5.SetActive(true);
        gameObject6.SetActive(true);
        gameObject7.SetActive(true);
    }


    public void gameOver()
    {
        gameObject1.GetComponent<scrollingObject>().enabled = false;
        gameObject1.GetComponent<repeatingBackground>().enabled = false;
        gameObject2.GetComponent<scrollingObject>().enabled = false;
        gameObject2.GetComponent<repeatingBackground>().enabled = false;

        gameOverText.SetActive(true);
    }
}
