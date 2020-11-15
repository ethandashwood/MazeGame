using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{

    public GameObject projectile;
    private float timebshots;
    public float stimebshots;

    void Start()
    {
        timebshots = stimebshots;
    }

    void Update()
    {
        if (timebshots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timebshots = stimebshots;
        }
        else
        {
            timebshots -= Time.deltaTime;

        }
    }
}
