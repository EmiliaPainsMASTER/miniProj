using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour
{
    //program will use four values (pos x neg x, pos z, and neg z to generate obstacles in random places
    private double _posX = -100.00d;
    private double _negX = -400.00d;
    private double _posZ = 6.50d;
    private double _negZ = -6.50d;
    // Start is called before the first frame update
    public GameObject[] obstacles;
    public float interval = 2.0f;
    void Start()
    {
        interval = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        interval -= Time.deltaTime;
        if (interval < 0)
        {
            SpawnObstacle();
        }
    }

    void SpawnObstacle()
    {
        float randX = (float)Random.Range((float)_negX, (float)_posX);
        float randZ = (float)Random.Range((float)_negZ, (float)_posZ);
        Vector3 spawnPos = new Vector3(randX, 0, randZ);

        // Choose a random obstacle prefab
        int index = Random.Range(0, obstacles.Length);
        GameObject obstacleToSpawn = obstacles[index];

        // Instantiate the obstacle at the random position with no rotation
        Instantiate(obstacleToSpawn, spawnPos, obstacleToSpawn.transform.rotation);
    }
}
