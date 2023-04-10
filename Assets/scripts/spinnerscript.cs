using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinnerscript : MonoBehaviour
{
    [SerializeField] float xr = 0;
    [SerializeField] float yr = 0.5f;
    [SerializeField] float zr = 0;
    [SerializeField] float rspeed = 4f;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xr,yr,zr);
    }
}
