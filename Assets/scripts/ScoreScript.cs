using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public static int scoreValue = 0;
    Text score;

    void Start()
    {
        score = GetComponent<Text> ();
    }




    void Update()
    {
        score.text = "" + scoreValue;



        if (playermove.isdead== true)
            score.text = "DEAD";
    }
}
