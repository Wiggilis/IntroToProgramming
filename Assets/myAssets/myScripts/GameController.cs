using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject birdPrefab;
    public Transform birdSpawnLocation;

    // Spawns bird 
    void SpawnBird()
    {
        Instantiate(birdPrefab,birdSpawnLocation.position, birdSpawnLocation.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        SpawnBird();
    }

    void Update()
    {

        //Instantiate(birdPrefab, birdSpawnLocation.position, birdSpawnLocation.rotation);

        //if (birdPrefab)
        {
            //if (birdPrefab == null)
            {
                //Instantiate(birdPrefab, birdSpawnLocation.position, birdSpawnLocation.rotation);
                //birdPrefab.enabled;
            }   
        }
        //else
        {
            //if (birdPrefab != null)
            {
                //birdPrefab.enabled = false;
            }
        }
    }
}
