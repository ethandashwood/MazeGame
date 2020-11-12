using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ratdestruction : MonoBehaviour
{

    public GameObject scoreText;
    public string score = 0;
    public string rscore;



    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);

        score = score + 1;

        scoreText.GetComponent <Text>().text = score;



    }




    void Update()
    {


    }
}
