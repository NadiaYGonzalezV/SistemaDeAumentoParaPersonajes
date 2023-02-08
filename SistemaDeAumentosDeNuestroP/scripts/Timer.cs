using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //creamos la variable desde la cual se iniciara el conteo
    public float timer = 0;
    public Text textoTimer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        textoTimer.text = "" + timer.ToString("0");
    }
}
