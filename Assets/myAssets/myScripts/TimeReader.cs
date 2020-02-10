using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeReader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }


    void Update()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}
