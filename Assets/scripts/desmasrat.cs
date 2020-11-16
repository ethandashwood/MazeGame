using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desmasrat : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {

        if (ScoreScript.scoreValue > 12)
        {
        
            Destroy(gameObject);
        }
    }
}
