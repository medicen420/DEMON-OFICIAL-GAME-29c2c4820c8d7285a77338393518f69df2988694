using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

    public Transform playertrans;


    //Aqui ingresaremos mi rigidbody
    private Rigidbody2D bulletRB;
    //Esto controlara la velocidad de mi bala
    public float bulletSpeed;
    // Start is called before the first frame update
    public float bulletlife;

    void Awake()
    {
        bulletRB = GetComponent<Rigidbody2D>();
    }


    void Start()
    {
        if (playertrans.localScale.x > 0)
        bulletRB.velocity = new Vector2(bulletSpeed, bulletRB.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, bulletlife);
    }
}
