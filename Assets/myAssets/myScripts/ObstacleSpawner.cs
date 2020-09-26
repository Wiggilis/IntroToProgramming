using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float spawnDelay;
    public GameObject ObstaclePrefab;
    private Vector3 randomHeightVector;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        Vector3 randomHeightVector = new Vector3(10, Random.Range(-2f, 2f), 0);
        Instantiate(ObstaclePrefab, randomHeightVector, Quaternion.identity);
        Invoke("SpawnObstacle", spawnDelay);
    }
}
