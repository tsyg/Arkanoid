using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkanoidBall : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(10f,100f,0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    
}
