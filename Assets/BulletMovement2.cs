using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletMovement2 : MonoBehaviour
{   //Mandamos llamar al transform de nuestro player
    public GameObject player;
    private Transform playertrans;

    //Mandamos llamar al código Movimiento
    Movimiento mov;
    //Mandamos llamar a nuestro Rigidbody para que nuestro personaje pueda moverse
    //y debe de ser de tipo 2D
    Rigidbody2D rb2D;


    private Rigidbody2D bulletRB;
    public float bulletSpeed;


    public float bulletlife;

    public GameObject calavera;
    public GameObject calavera2;
    public GameObject ojo;
    public GameObject ojo2;
    public GameObject vampiro;
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
        mov = GetComponent<Movimiento>();
        rb2D = GetComponent<Rigidbody2D>();
        //Si el valor es positivo esta mirando a la... DERECHA
        if (playertrans.localScale.x > 0)
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Calavera")
        {
            Debug.Log("aqui esta mi calavera");
            Destroy(calavera);
        }
        if (collision.gameObject.tag == "Ojo")
        {
            Debug.Log("aqui esta mi calavera");
            Destroy(ojo);
        }
        if (collision.gameObject.tag == "Ojo_2")
        {
            Debug.Log("aqui esta mi calavera");
            Destroy(ojo2);
        }
        if (collision.gameObject.tag == "Gard")
        {
            Debug.Log("aqui esta mi calavera");
            Destroy(vampiro);

        }
        if (collision.gameObject.tag == "Calavera_2")
        {
            Debug.Log("aqui esta mi calavera");
            Destroy(calavera2);

        }
        
        //Estas son las lineas de codigo para el jefe final 
        if (collision.gameObject.tag == "JEFE")
        {

            Debug.Log("PIZZA");
        }



    }
    
}
