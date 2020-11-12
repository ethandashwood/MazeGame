using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class ratbehavior : MonoBehaviour
{
    public float speed;
    public float distance;



    private bool movingright = true;

    public Transform grounddet;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundinfo = Physics2D.Raycast(grounddet.position, Vector2.down, 2f);

        if (groundinfo.collider == false)
        {
            if (movingright == true)
            {

                transform.eulerAngles = new Vector3(0, -180, 0);
                movingright = false;

            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingright = true;
            }
        }


    }

}
