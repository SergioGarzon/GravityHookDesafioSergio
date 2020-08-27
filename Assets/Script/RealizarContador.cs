using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RealizarContador : MonoBehaviour
{

    public Text txtContador;
    private int contador;

    void Start()
    {
        this.txtContador = GetComponent<Text>();
        this.contador = 5;
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(TiempoDeEspera());

        if (this.contador > 0)
            this.txtContador.text = this.contador.ToString();

        this.contador -= 1;

        if(this.contador < 0)
        {
            this.txtContador.text = "";
            return;
        }
           
        
        
       
    }

    IEnumerator TiempoDeEspera()
    {
        yield return new WaitForSeconds(1000);
    }
}
