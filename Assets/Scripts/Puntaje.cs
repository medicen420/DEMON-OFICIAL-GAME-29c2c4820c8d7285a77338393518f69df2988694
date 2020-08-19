using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    public static float score;
    //Este es mi texto de score que aparece en pantalla
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        //Mandamos llamar al texto del score
        //ponemos que primero tendra Puntaje y le sumaremos el score o número que tenga en mi variable score
        //Enlazamos texto con variable score
        scoreText.text = "Puntaje: " + score;
    }
}
