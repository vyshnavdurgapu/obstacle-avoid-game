using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    
    [SerializeField]float movespeed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveplayer();
    }
    void moveplayer()
    {
        float xvalue =Input.GetAxis("Horizontal")* Time.deltaTime*movespeed;
        float zvalue =Input.GetAxis("Vertical")  * Time.deltaTime*movespeed;
        transform.Translate(xvalue,0,zvalue) ; 
    }
}
