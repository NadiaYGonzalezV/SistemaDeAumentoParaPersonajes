using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{

    public float velocidad;
    private Rigidbody2D rigidbodyy2D;
    public float fuerzaSalto;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyy2D = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        Salto();
    }

    void Salto()
    {
        //GetKeyDown es importante para que el salto sea exitoso
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //no es recomendable usar AddForce pero para prueba es factible.
            rigidbodyy2D.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
    }

    void Movimiento()
    {
        float inputMovimiento = Input.GetAxis("Horizontal");
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.velocity = new Vector2 (inputMovimiento * velocidad, rigidbody.velocity.y);
    }

    
    
}
