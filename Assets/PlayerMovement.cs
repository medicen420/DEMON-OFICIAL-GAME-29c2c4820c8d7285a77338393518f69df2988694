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

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMov();
        
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
}
