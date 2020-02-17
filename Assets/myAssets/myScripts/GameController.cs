using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject birdPrefab;
    public Transform birdSpawnLocation;
    public GameObject playButton;
    public ObstacleSpawner obstacleSpawnerRef;

    bool isAlive = false;

    // Spawns bird 


    // Start is called before the first frame update
    void Start()
    {
        playButton.SetActive(true);
        obstacleSpawnerRef.enabled = false;
    }

    void Update()
    {
        if(birdPrefab == null)
        {
            EndGame();
        }
        
    }

    public void BeginGame()
    {
        if (birdPrefab != null)
        {
            SpawnBird();
            obstacleSpawnerRef.enabled = true;
            playButton.SetActive(false);
        }
    }

    void EndGame()
    {
        SceneManager.LoadScene("FlappyBirdHome");
    }

    void SpawnBird()
    {
        Instantiate(birdPrefab,birdSpawnLocation.position, birdSpawnLocation.rotation);
    }
}
