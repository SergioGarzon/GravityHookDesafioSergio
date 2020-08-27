using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltoHaciaArriba : MonoBehaviour
{
    public Rigidbody componenteRigidbody;

    void Start()
    {
        componenteRigidbody = GetComponent<Rigidbody>();
    }


    public void FixedUpdate()
    {
        if(Input.GetKeyDown("Jump"))
        {
            componenteRigidbody.velocity = new Vector3(0, 50, 0);
        }
    }







}
