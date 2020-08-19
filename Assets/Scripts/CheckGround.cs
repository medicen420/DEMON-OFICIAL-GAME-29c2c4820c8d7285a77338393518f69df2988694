using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    //Colcamos una variable booleana cullas respuestas pueden ser solamente 
    //SI o NO
    //Al poner static estoy indicando que puedo utilizar esta variable dentro de otra script
    public static bool isGrounded;
    public GameObject enemy_calavera;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
        //Agregaremos 
        if(collision.gameObject.tag == "ENEMY")
        {
            Debug.Log("colisionamos con enemigo");
            Destroy(enemy_calavera);
            

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
        
    }




}
