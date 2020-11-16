using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class masterrat : MonoBehaviour
{
    public float speed; //6
    public float stoppingDistance; //10
    public float retreatDistance; //5
    
    Text score;

    public Transform player;

    public Transform grounddet;

    private Vector3 prevloc;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        prevloc = transform.position;




    }


    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;

        }
        else if (Vector2.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);

        }

        Vector3 currentvelocity = (transform.position - prevloc) / Time.deltaTime;
        if (currentvelocity.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, -180, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        prevloc = transform.position;


    


        if (ScoreScript.scoreValue > 12)
        
        {

            speed = 2;


        }

    } 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy (gameObject);

        }
            

    }

}
