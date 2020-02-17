using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D birdRigidbody;
    public float upForce;
    private bool isJumping = false;
    public bool isAlive = false;
    private GameObject gameObjectRef;
    private GameObject gameManagerReference;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerReference = GameObject.FindWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Im moving up!");
            birdRigidbody.AddForce(Vector2.up * upForce);
            isJumping = true;
        }

        if (transform.position.y < -5.0f)
        {
            //this is the basic way of doing this.
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        if (isJumping == true)
        {
            birdRigidbody.AddForce(Vector2.up * upForce);           
            isJumping = false;
        }
    }

    void OnCollisionEnter2D(Collision2D objectBeingHit)
    {
        Debug.Log("I hit the object " + objectBeingHit.gameObject.name);
        Destroy(gameObject);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("I hit the object " + collision.gameObject.name);
        if (collision.gameObject.tag == "PointerCounter")
        {
            gameManagerReference.GetComponent<GameController>().AddPoints();
        }
    }
}
