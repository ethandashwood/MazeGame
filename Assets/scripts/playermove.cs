using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour

{
    public GameObject Camera;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        float xSpeed = 8.0f;
        float ySpeed = -8.0f;
        if (Input.GetKey("right"))
        {
            // registers a key held down and returns true
            xSpeed = -8.0f;
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey("left"))
        {
            // registers a key held down and returns true

            xSpeed = 8.0f;
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);

        }


        if (Input.GetKey("up"))
        {
            // registers a key held down and returns true

            ySpeed = 7.0f;
            transform.position += new Vector3(0, ySpeed * Time.deltaTime, 0);
    
           
        }

        if (Input.GetKey("down"))
        {
            // registers a key held down and returns true

            ySpeed = -7.0f;
            transform.position += new Vector3(0, ySpeed * Time.deltaTime, 0);


        }
    }
}
