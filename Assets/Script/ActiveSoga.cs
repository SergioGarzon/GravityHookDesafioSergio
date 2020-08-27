using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSoga : MonoBehaviour
{

    public GameObject objetoSoga1;
    public GameObject objetoSoga2;
    public bool activarObjeto1;
    public bool activarObjeto2;


    void Start()
    {
        this.objetoSoga1 = GetComponent<GameObject>();
        this.objetoSoga2 = GetComponent<GameObject>();

        this.activarObjeto1 = false;
        this.activarObjeto2 = false;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.G))
        {
            this.activarObjeto1 = true;
        }
        if(Input.GetKey(KeyCode.H))
        {
            this.activarObjeto2 = true;
        }
        if(Input.GetKey(KeyCode.J))
        {
            this.activarObjeto1 = false;
            this.activarObjeto2 = false;
        }

        this.ActivarObjetos();
    }

    public void ActivarObjetos()
    {
        if (this.activarObjeto1)
        {
            this.objetoSoga1.SetActive(true);
        } else
        {
            this.objetoSoga1.SetActive(false);
        }


        if(this.activarObjeto2)
        {
            this.objetoSoga2.SetActive(true);
        }
        else
        {
            this.objetoSoga2.SetActive(false);
        }
        
    }

}
