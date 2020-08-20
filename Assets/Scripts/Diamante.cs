using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Diamante : MonoBehaviour
{
    public float puntos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Este comportamiento nos ayuda a que cuando el personaje colisione con el diamante 
    //este desaparecerá
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Puntaje.score += puntos;
            Debug.Log("ooo un diamante");
            Destroy(gameObject);
            if (Puntaje.score == 1)
            {
                SceneManager.LoadScene("JEFE");
                Debug.Log("listooo");
            }
          
        }
    }
}
