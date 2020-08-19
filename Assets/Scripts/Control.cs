using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    //Mandamos llamar al código Movimiento
    Movimiento mov;
    //Mandamos llamar a nuestro Rigidbody para que nuestro personaje pueda moverse
    //y debe de ser de tipo 2D
    Rigidbody2D rb2D;

    //Esta es la variable que define la velocidad del primer salto
    public float JumpSpeed = 3;
    //Asignamos una nueva variable que contendra la fuerza del doble salto
    public float dobleJumpSpeed= 2.5f;
    //Variable para indicar cuando puedo hacer un doble salto
    private bool canDoubleJump;
    //La siguiente variable será para el doble salto y es de tipo Bool 

    public GameObject calavera;
    public GameObject calavera2;
    public GameObject ojo;
    public GameObject ojo2;
    public GameObject vampiro;


    //A continuación trabajeremos en el disparo

        //Necesitamos saber la posicion de donde saldra la bala
    public Transform bulletSpawner;
    //Este es nuestro proyectil
    public GameObject bulletPrefap;


    public LIFE lf;
    

   


    public Animator anim;
    //public GameObject diama;

    // Start is called before the first frame update
    void Start()
    {
        mov = GetComponent<Movimiento>();
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        lf.GetComponent<LIFE>();
        //diama = GetComponent<GameObject>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Se mete en el Update dado a que siempre que presione B la acción se realizará
        PlayerShooting();
        
        //Si presionamos la tecla derecha de nuestro teclado... el personaje
        //se moverá a la derecha
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Si esta condición se cumple entonces en consola me arrojara el siguiente mensaje
            Debug.Log("a la derecha");
            //Nuestra variable mov contiene el código que hará que el personaje se mueva
            //es por ello que la ponemos junto con el comportamiento que requerimos del otro
            //script, se podría decir que estamos utilizando un código externo, dentro de este.
            mov.MovimientoAdelante();
            anim.SetBool("Right", true);


        }
        else
        {
            Debug.Log("soltaste right");
            anim.SetBool("Right", false);
        }

        //Si presionamos la tecla izquierda de nuestro teclado... el personaje
        //se moverá a la izquierda
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Si esta condición se cumple entonces en consola me arrojara el siguiente mensaje
            Debug.Log("a la izquierda");
            mov.MovimientoAtrás();
            anim.SetBool("Left", true);
        }
        else
        {
            Debug.Log("soltaste left");
            anim.SetBool("Left", false);
        }

        if (Input.GetKey("space")) 
        {
            if (CheckGround.isGrounded)
            {
                Debug.Log("hacia arriba");

                //mov.MovimientoArriba();
                canDoubleJump = true;
                rb2D.velocity = new Vector2(rb2D.velocity.x, JumpSpeed);

            }
            else
            {
                //Se le pone GetKeyDown, pulsar por segunda ocacion la barra espaciadora
                //para realizar el segundo salto
                if (Input.GetKeyDown("space"))
                {
                    if (canDoubleJump)
                    {
                        //El segundo salto es igual que el primero así que solo copiamos la misma
                        //línea de código y la pegamos aquí, pero el JumpSpeed, ahora será nuestro doubleJumpSpeed
                        rb2D.velocity = new Vector2(rb2D.velocity.x, dobleJumpSpeed);
                        //En el momento que se haga este salto el can double jump se pasa a false
                        canDoubleJump = false; 

                    }

                }
            }

        }
        
        

    }
    //aqui indicamos a mi personaje que al momento de collisionar con
    //una plataforma o un game object en este caso denominado bajo el nombre de la etiqueta "Platform"
    //mi personaje se emparentara al transform de mi plataforma 

       

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Platform")
        {

            gameObject.transform.SetParent(collision.gameObject.transform);
            Debug.Log("estoy aqui");

        }

    }
    //para desenparentarme de el tranform de mi plataforma 
    //colocamos un OnCollisionExit2D 
    //al poner esto estamos indicando que cuando salga de dicha colision regresara a 
    //su tranform normal
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            Debug.Log("no estoy aqui");
            gameObject.transform.parent = null;

        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag== "Calavera")
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
        if(collision.gameObject.tag== "Gard")
        {
            Debug.Log("aqui esta mi calavera");
            Destroy(vampiro);

        }
        if (collision.gameObject.tag == "Calavera_2")
        {
            Debug.Log("aqui esta mi calavera");
            Destroy(calavera2);

        }
        if (collision.gameObject.tag == "PisoLava")
        {
            SceneManager.LoadScene("LOSER");
        }


        //Estas son las lineas de codigo para el jefe final 
        if(collision.gameObject.tag == "JEFE")
        {
            
            Debug.Log("PIZZA");
        }


    }

    public void PlayerShooting()
    {
        if (Input.GetButtonDown("Shoot"))
        {
            //Nos generara una copia de ese prefap o de la bala
            Instantiate(bulletPrefap, bulletSpawner.position, bulletSpawner.rotation);
        }
    }




}
