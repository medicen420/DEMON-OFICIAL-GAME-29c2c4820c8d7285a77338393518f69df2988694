using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JefeLife : MonoBehaviour
{
    //VIDA DEL PLAYER
    public int life= 100;
    private Slider lifebar;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        //Al momento de que iniciamos el juego el script esta buscando el objeto con la etiqueta life bar
        lifebar = GameObject.FindGameObjectWithTag("LifeBar").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {

        //el valor de mi life bar va a ser igual a la vida actual del Jefe
        lifebar.value = life;
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Plasma")
        {
            life -= damage;
            Debug.Log("una plasmaaaa");
            if (life == 0)
            {
                SceneManager.LoadScene("WIN");
                Debug.Log("EL JEFE MURIO");
            }
        }
    }
}
