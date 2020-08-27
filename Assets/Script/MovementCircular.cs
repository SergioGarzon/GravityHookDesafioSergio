using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCircular : MonoBehaviour
{
    public CharacterController objetoNadador;
    [SerializeField] private float valorDerecha;
    [SerializeField] private float valorIzquierda;
    [SerializeField] private float valorSalto;
    public float velocidadMovimiento;

    void Start()
    {
        this.objetoNadador = GetComponent<CharacterController>();
        //Vector3 vec = new Vector3(this.valorDerecha * 0.5f, valorIzquierda * 0.5f, 1);

    }

    void Update()
    {
        this.valorDerecha = Input.GetAxis("Horizontal");
        this.valorIzquierda = Input.GetAxis("Vertical");


        this.valorSalto = Input.GetAxis("Jump");


    }

    private void FixedUpdate()
    {
        this.objetoNadador.Move(new Vector3(this.valorDerecha, 0, this.valorIzquierda) * velocidadMovimiento * Time.deltaTime);
    }

}
