using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorecounter: MonoBehaviour
{
    int score = -1 ;
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "hit")
        {
            score++;
            Debug.Log("u bumped into things this many times : "+score);
        }
    }
}
