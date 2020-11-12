using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour

{
    public Animator anim;
    public GameObject Camera;
    Rigidbody2D rb;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {


        float xSpeed = 8.0f;
        float ySpeed = -8.0f;

        if (Input.GetKey("a"))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("idle", false);
            xSpeed = -8.0f;
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Euler(0, 180f, 0);

        }

        if (Input.GetKey("d"))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("idle", false);
            xSpeed = 8.0f;
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Euler(0, 0f, 0);
        }


        if (Input.GetKey("w"))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("idle", false);
            ySpeed = 7.0f;
            transform.position += new Vector3(0, ySpeed * Time.deltaTime, 0);



        }

        if (Input.GetKey("s"))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("idle", false);
            ySpeed = -8.0f;
            transform.position += new Vector3(0, ySpeed * Time.deltaTime, 0);



        }

        if (!Input.anyKey)
        {
            anim.SetBool("idle", true);
            anim.SetBool("isWalking", false);

        }
                
    }
}
