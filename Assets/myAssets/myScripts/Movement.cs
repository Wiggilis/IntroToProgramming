using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hey this is being called once!");
    }

    // Update is called once per frame
    void Update()
    {
        //Controls for movement
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Moveup();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Moveforward();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Moveleft();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Moveback();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Moveright();
        }
    }

    //Movement Coding
    void Moveup()
    {
        Debug.Log("Moving Up!");
        transform.Translate(Vector3.up * moveSpeed, Space.World);
    }
    void Moveforward()
    {
        Debug.Log("Moving Forward!");
        transform.position = transform.position + new Vector3(0, 0, -1) * moveSpeed;
    }
    void Moveleft()
    {
        Debug.Log("Moving Left!");
        transform.position = transform.position + new Vector3(-1, 0, 0) * moveSpeed;
    }
    void Moveback()
    {
        Debug.Log("Moving Back!");
        transform.position = transform.position + new Vector3(0, 0, 1) * moveSpeed;
    }
    void Moveright()
    {
        Debug.Log("Moving Right!");
        transform.position = transform.position + new Vector3(1, 0, 0) * moveSpeed;
    }

}
