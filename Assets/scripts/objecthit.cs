using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objecthit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player" )
        {
            // Debug.Log("collided!!!");   
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "hit";
        }
    }
}
