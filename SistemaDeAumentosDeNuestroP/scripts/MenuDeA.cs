using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDeA : MonoBehaviour
{

    //Este script ayuda a que el menu de habilidades se abra y cierre

    [SerializeField] private GameObject botonAumentos;
    [SerializeField] private GameObject menuAmentos;

    //ayuda a que el boton de "Aumentos" abra un sub menu
    public void Aumentos()
    {
        //al entrar al sub menu el juego se detiene como si estuviera en pausa
        Time.timeScale = 0f;
        botonAumentos.SetActive(false);
        menuAmentos.SetActive(true);
    }

    //Ayuda a que el boton de "atras" te regrese al juego
    public void Reanudar()
    {
        //al seguir de sub menu el tiempo vuelve a correr.
        Time.timeScale = 1f;
        botonAumentos.SetActive(true);
        menuAmentos.SetActive(false);
    }
}
