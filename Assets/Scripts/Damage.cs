using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    public int damage;
    public LIFE lif;
    
    


    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            lif.vida -= damage;
            Debug.Log("ya me desespere");
        }
    }





}
