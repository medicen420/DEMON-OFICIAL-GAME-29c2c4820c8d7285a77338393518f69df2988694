using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VIDA : MonoBehaviour
{
    //ESTE ES EL NIVEL DE LA VIDA
    //public float _vida = 4;
    //ESTOS SON LOS CORAZONES
    public LIVES vida_canvas;
    // Start is called before the first frame update
    public static float life = 4;




    void Start()
    {
        vida_canvas = GameObject.FindObjectOfType<LIVES>();
    }


    // Update is called once per frame
    void Update()
    {
        //vida_canvas.CambioVida(vida);
    }
}
