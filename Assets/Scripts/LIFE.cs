using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LIFE : MonoBehaviour
{
    //ESTE ES EL NIVEL DE LA VIDA
    //public float _vida = 4;
    //ESTOS SON LOS CORAZONES
    public LIVES vida_canvas;
    // Start is called before the first frame update
    public int vida = 4;

    


    
   
   
    
    

    void Start()
    {
        vida_canvas = GameObject.FindObjectOfType<LIVES>();
    }


    // Update is called once per frame
    void Update()
    {
        vida_canvas.CambioVida(vida);

        //Si la vida llega a 0 entonces se nos abrirá la pantalla de LOSER
        if (vida == 0)
        {
            SceneManager.LoadScene("LOSER");
            Debug.Log("LOSER");
        }
    }

   






}
