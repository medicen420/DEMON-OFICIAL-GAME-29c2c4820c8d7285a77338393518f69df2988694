﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement_Gaps_Skull : MonoBehaviour
{
    //Variable que será para la velocidad
    public float speed;
    //Variable que sera la distancia que recorrera
    public float distancia;
    //Variable privada que será el contador
    private float counter;
    //Variable privada que será la posicion inicial del jugador
    private float startPosition;


    private float actualPosition;
    private float lastPosition;




    // Start is called before the first frame update

    void Start()
    {
        //setearemos nuestra posicion inicial que sera igual a la posicion en x de nuestro enemigo, sera en x
        //puesto que nos moveremos en horizontal, estilo ping pong, derecha a izquierda
        startPosition = transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        //Comenzamos llamando al contador, el += significa que en cada llamado del updtae va 
        // aumentar en el contador 
        counter += Time.deltaTime * speed;

        //Comenzaremos a hacer el movimiento PING PONG

        transform.position = new Vector2(Mathf.PingPong(counter, distancia) + startPosition, transform.position.y);

        //Nuestro enemigo cuando llegue a la posicion final de la vuelta
        //Después de hacer el movimiento de PING PONG, aquí se guardará la posición actual
        actualPosition = transform.position.x;
        //si la posicion actual es menor a la ultima posicion entonces
        //la escala va a ser -#, # , #, esto se debe a que si yo pongo estos valores en mi personaje 
        //este volteara al otro lado
        if (actualPosition < lastPosition) transform.localScale = new Vector3(-0.03246817f, 0.03246817f, 0.03246817f);
        if (actualPosition > lastPosition) transform.localScale = new Vector3(0.03246817f, 0.03246817f, 0.03246817f);

        //Si no se cumple ninguna de lass dos condiciones de arriba entonces va a guardar su posición final
        //Si se llegan a cumplir cualquiera de las 2, entonces cambia la escala y guarda la posición final
        lastPosition = transform.position.x;


    }
}
