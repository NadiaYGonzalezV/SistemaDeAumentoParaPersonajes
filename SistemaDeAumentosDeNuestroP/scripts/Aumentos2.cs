using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Aumentos2 : MonoBehaviour
{
    //valor a modificar
    public int velocidadPoint = 0;
    public int fuerzaPoint = 0;
    public int vidaPoint = 0;
    //Texto a modificar
    public TMP_Text puntosvelocidad;
    public TMP_Text puntosfuerza;
    public TMP_Text puntosvida;


    
    // Update is called once per frame
    void Update()
    {
        //Se le asigna el nuevo valor que estamos asignando 

        puntosvelocidad.text =  velocidadPoint.ToString();

        puntosfuerza.text = fuerzaPoint.ToString();

        puntosvida.text =  vidaPoint.ToString();
    }

    public void IncrementodePuntosVE() //aumento de puntos de cada variable por separado.
    {
        velocidadPoint++;
        
        
    }

    public void IncrementosdepuntosFuerza()
    {
        fuerzaPoint++;
    }

    public void Incrementodepuntosvida()
    {
        vidaPoint++;

    }

    public void Decrementosdepuntos() //disminuyen puntos de todas las variables juntas
    {
        velocidadPoint--;
        fuerzaPoint--;
        vidaPoint--;
    }
}
