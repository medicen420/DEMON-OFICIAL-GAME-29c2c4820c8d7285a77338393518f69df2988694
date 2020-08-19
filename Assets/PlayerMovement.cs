using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRB;
    private Animator playerAnim;
    //Velocidad de mi player
    [SerializeField]
    private float playerSpeed;

    //Fuerza del brinco
    public float verticalSpeed;

    //Estas variables nos ayudaran a detectar un piso
    //Para que mi personaje no salte en el aire, si no hasta que detecte el suelo
    public Transform groundCheck;
    public float checkradius;
    public LayerMask whatIsground;

    private bool grounded;

    //esta variable 
    private bool doubleJumped;

    //Aqui sabremos en que posicion se esta disparando el proyectil
    public Transform bulletSpawner;
    //
    public GameObject bulletPrefap;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, checkradius, whatIsground);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //No es necesario abrir mis corchetes puesto que si solo se ocupara una linea de código
        //Puedo escribirlo sin ningun problema asi tal cuál
        if (grounded)

            doubleJumped = false;


        PlayerJump();
        PlayerMov();
        PlayerShoting();
        
        
    }

    public void PlayerMov()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            playerRB.velocity = new Vector2(playerSpeed, playerRB.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            playerRB.velocity = new Vector2(-playerSpeed, playerRB.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }

        //No importa hacia donde me estoy moviendo siempre el valor va a ser positivo
        playerAnim.SetFloat("speed", Mathf.Abs(playerRB.velocity.x));

        
    }

    public void PlayerJump()
    {
        //double jump es falso y tampoco el jugador esta en el grounded
        //si estas dos condiciones son falsas puedo hacer el double jump
        if (Input.GetButtonDown("Jump") && grounded)
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, verticalSpeed);
            doubleJumped = true;
        }
        if (Input.GetButtonDown("Jump") && !doubleJumped && !grounded)
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, verticalSpeed);
            doubleJumped = true;
        }

    }

    public void PlayerShoting()
    {
        if (Input.GetButtonDown("Shoot"))
        {
            Instantiate(bulletPrefap, bulletSpawner.position, bulletSpawner.rotation);
               
        }
    }
}
