using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRespawn : MonoBehaviour
{
    private GameObject[] princess;
    private Vector2 princessPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;
    private float spawnPositionX = 10f;
    private int currentPrincess = 0;


    public int princessPoolSize = 5;
    public GameObject princessPrefab;
    public float spawnRate = 3f;
    public float princessMin = -1f;
    public float princessMax = 3.5f;

    
    // Start is called before the first frame update
    void Start()
    {
        timeSinceLastSpawned = 0f;
        princess = new GameObject[princessPoolSize];
        for(int i=0; i<princessPoolSize; i++)
        {
            princess[i] = (GameObject) Instantiate(princessPrefab, princessPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if(timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0f;
            float spawnPositionY = Random.Range(princessMin, princessMax);
            princess[currentPrincess].transform.position = new Vector2(spawnPositionX, spawnPositionY);
            currentPrincess++;

            if(currentPrincess >= princessPoolSize)
            {
                currentPrincess = 0;
            }
        }
    }
}
