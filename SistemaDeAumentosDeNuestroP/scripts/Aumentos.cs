using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





public class Aumentos : MonoBehaviour
{
    
    public GameObject aumentoV;
    public GameObject aumentoF;
    public GameObject aumentoVi;
    public Button aumento1;
    public Button aumento2;
    public Button aumento3;
    
   
    // Start is called before the first frame update
    void Start()
    {

        aumento1.onClick.AddListener(OpenaumentosV);
        aumento2.onClick.AddListener(OpenaumentosS);
        aumento3.onClick.AddListener(OpenaumentosVi);

    }
    private void OpenaumentosV()
    {
       

        aumentoV.SetActive(true);
        aumento1.interactable = false;
        //deshabilita el boton despues de 5 segundos o el tiempo que le menciones
        Invoke("ReenableButton", 5f); 

        
    }
    private void OpenaumentosS()
    {
        aumentoF.SetActive(true);
        aumento2.interactable = false;
        //deshabilita el boton despues de 5 segundos o el tiempo que le menciones
        Invoke("ReenableButton", 5f);
    }
    private void OpenaumentosVi()
    {
        aumentoVi.SetActive(true);
        aumento3.interactable = false;
        //deshabilita el boton despues de 5 segundos o el tiempo que le menciones
        Invoke("ReenableButton", 5f);
    }
      //Avtiva los botones despues del tiempo determinado
    private void ReenableButton()
    {
        aumento1.interactable = true;
        aumento2.interactable=true;
        aumento3.interactable=true;
    }

    
    
}
