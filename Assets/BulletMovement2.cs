using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement2 : MonoBehaviour
{   //Mandamos llamar al transform de nuestro player
    public GameObject player;
    private Transform playertrans;


    private Rigidbody2D bulletRB;
    public float bulletSpeed;


    public float bulletlife;

    //Para mandar a llamar primero a estos metodos utilizamos Awake
    void Awake()
    {
        bulletRB = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        //estoy accesando el transform del player
        playertrans = player.transform;

        
    }
    // Start is called before the first frame update
    void Start()
    {
        //Si el valor es positivo esta mirando a la... DERECHA
        if(playertrans.localScale.x > 0)
        {
            bulletRB.velocity = new Vector2(bulletSpeed, bulletRB.velocity.y);
            //Este es el transform que controla mi bala
            //Tendremos que escribir la siguiente linea de codigo para solucionar el
            //problema de la posicion de mi bala cuando sale disparada

            //SI DISPARA A LA IZQUIERDA LA BALA SALE EN LA MISMA POSICIóN QUE 
            //LA DERECHA
            //MODIFICAREMOS ESTE PREFAP
            transform.localScale = new Vector3(1, 1, 1);
        }
        //Cuando queremos comparar lo opuesto al IF usamos el else
        else
        {
            bulletRB.velocity = new Vector2(-bulletSpeed, bulletRB.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
       
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, bulletlife);
        
    }
}
