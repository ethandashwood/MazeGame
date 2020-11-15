using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ratdestruction : MonoBehaviour
{


    void Start()
    {


    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        Destroy(gameObject);
        ScoreScript.scoreValue += 1;

    }


    void Update()
    {
    

    }
}
