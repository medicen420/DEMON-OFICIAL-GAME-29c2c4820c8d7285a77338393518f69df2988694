using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    float velocidad = 5;



    public void MovimientoAdelante()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
    }

    public void MovimientoAtrás()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
    }



    /*public void MovimientoArriba()
    {
        transform.Translate(Vector2.up * velocidad * Time.deltaTime);
    }*/

}

